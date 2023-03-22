using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
{
    public static class ContactSerializer
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
        /// Создаёт экземпляр класса <see cref="ContactSerializer"/>.
        /// </summary>
        static ContactSerializer()
        {
            Path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            FileName = "data.json";
        }

        private static JsonSerializerSettings settings = new JsonSerializerSettings
        {
            TypeNameHandling = TypeNameHandling.All
        };

        /// <summary>
        /// Проверка на существование файла.
        /// </summary>
        /// <param name="nameFile">Имя файла.</param>
        /// <returns></returns>
        public static bool IsFile(string nameFile)
        {
            return File.Exists(Path + nameFile);
        }

        /// <summary>
        /// Проводит сериализацию данных.
        /// </summary>
        /// <param name="nameFile">Имя файла.</param>
        /// <param name="obj">Объект.</param>
        public static void Serialize(string nameFile, object obj)
        {
            using (StreamWriter writer = new StreamWriter(Path + nameFile))
            {
                writer.Write(JsonConvert.SerializeObject(obj, settings));
            }
        }

        /// <summary>
        /// Проводит десериализацию данных.
        /// </summary>
        /// <param name="nameFile">Имя файла.</param>
        /// <returns>Возвращает экземпляр класса <see cref="Contact"/>.</returns>
        public static Contact Deserialize(string nameFile)
        {
            if (!File.Exists(Path))
            {
                Directory.CreateDirectory(Path);
            }

            Contact contact;

            using (StreamReader reader = new StreamReader(Path + nameFile))
            {
                contact = JsonConvert.DeserializeObject<Contact>(reader.ReadToEnd(), settings);
            }

            return contact;
        }
    }
}
