using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using static System.Environment;

namespace ListOfEstablishments.Model
{
    public static class ProjectSerializer
    {
        static ProjectSerializer()
        {
            Path = $@"{GetFolderPath(SpecialFolder.ApplicationData)}" + "/Makarov/ListOfEstablishments/";
            FileName = "data.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        public static void Serialize(List<Establishment> establishments)
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            using (StreamWriter writer = new StreamWriter(Path + FileName))
            {
                writer.Write(JsonConvert.SerializeObject(establishments));
            }
        }

        public static List<Establishment> Deserialize()
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            var establishments = new List<Establishment>();

            try
            {
                using (StreamReader reader = new StreamReader(Path + FileName))
                {
                    establishments = JsonConvert.DeserializeObject<List<Establishment>>(reader.ReadToEnd());
                }

                if (establishments == null) establishments = new List<Establishment>();
            }
            catch
            {
                return establishments;
            }

            return establishments;
        }

        public static string Path { get; set; }

        public static string FileName { get; set; }
    }
}
