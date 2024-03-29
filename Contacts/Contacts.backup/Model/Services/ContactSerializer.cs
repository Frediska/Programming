﻿using View.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace View.Model.Services
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
        public static ObservableCollection<ContactVM> Load()
        {
            var contacts = new ObservableCollection<ContactVM>();

            if (File.Exists(Path))
            {
                using (StreamReader sr = new StreamReader(Path))
                {
                    contacts
                        = JsonConvert.
                        DeserializeObject<ObservableCollection<ContactVM>>
                        (sr.ReadToEnd());
                }
            }
            else
            {
                File.Create(Path).Close();
            }

            return contacts;
        }

        /// <summary>
        /// Сохраняет список объектов в файл.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        public static void Save(ObservableCollection<ContactVM> contacts)
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
