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
    /// <summary>
    /// Реализация сериализации и десериализации данных.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Создаёт экземпляр класса <see cref="ProjectSerializer"/>.
        /// </summary>
        static ProjectSerializer()
        {
            Path = $@"{GetFolderPath(SpecialFolder.ApplicationData)}" + "/Makarov/ListOfEstablishments/";
            FileName = "data.json";

            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="establishments">Коллекция класса <see cref="Establishment"/></param>
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

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию заведений.</returns>
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

        /// <summary>
        /// Возвращает и задает путь куда будут сериализоватся данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Возвращает и задает имя файла.
        /// </summary>
        public static string FileName { get; set; }
    }
}
