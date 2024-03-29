﻿using Newtonsoft.Json;
using System.Collections.ObjectModel;

namespace Model.Services
{
    public static class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает путь сохранения файла.
        /// </summary>
        public static string Path { get; set; }
            = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\contacts.json";

        /// <summary>
        /// Загружает данные из файла в приложение.
        /// </summary>
        /// <returns>Список контактов.</returns>
        public static ObservableCollection<Contact> Deserialize()
        {
            var contacts = new ObservableCollection<Contact>();

            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    contacts
                        = JsonConvert.
                        DeserializeObject<ObservableCollection<Contact>>
                        (sr.ReadToEnd()) ?? new ObservableCollection<Contact>();
                }
            }

            return contacts;
        }

        /// <summary>
        /// Сохраняет список объектов в файл.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        public static void Serialize(ObservableCollection<Contact> contacts)
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Close();
            }

            using (StreamWriter wr = new StreamWriter(Path))
            {
                wr.Write(JsonConvert.SerializeObject(contacts));
            }
        }
    }
}
