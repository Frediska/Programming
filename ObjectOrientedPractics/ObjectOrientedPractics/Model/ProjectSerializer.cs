using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.IO;
using static System.Environment;

namespace ObjectOrientedPractics.Model
{
    /// <summary>
    /// Реализация сериализации и десериализации данных.
    /// </summary>
    public static class ProjectSerializer
    {
        /// <summary>
        /// Возвращает и задает путь куда будут сериализоватся данные.
        /// </summary>
        public static string Path { get; set; }

        /// <summary>
        /// Возвращает и задает имя файла.
        /// </summary>
        public static string FileName { get; set; }

        /// <summary>
        /// Создаёт экземпляр класса <see cref="ProjectSerializer"/>.
        /// </summary>
        static ProjectSerializer()
        {
            Path = $@"{GetFolderPath(SpecialFolder.ApplicationData)}" + "/Makarov/ObjectOrientedPractics/";
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
        public static void Serialize(Store store)
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            using (StreamWriter writer = new StreamWriter(Path + FileName))
            {
                writer.Write(JsonConvert.SerializeObject(store));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <returns>Возвращает коллекцию заведений.</returns>
        public static Store Deserialize()
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            var store = new Store();

            try
            {
                using (StreamReader reader = new StreamReader(Path + FileName))
                {
                    store = JsonConvert.DeserializeObject<Store>(reader.ReadToEnd());
                }

                if (store == null) store = new Store();
            }
            catch
            {
                return store;
            }

            return store;
        }
    }
}
