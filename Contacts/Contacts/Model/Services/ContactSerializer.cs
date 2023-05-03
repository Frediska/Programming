using View.ViewModel;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contacts.ViewModel;

namespace View.Model.Services
{
    public class ContactSerializer
    {
        /// <summary>
        /// Возвращает и задает путь сохранения файла.
        /// </summary>
        public string Path { get; set; }
            = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments)
            + @"\Contacts\contacts.json";

        /// <summary>
        /// Создает экземпляр класса <see cref="ContactSerializer"/>.
        /// </summary>
        public ContactSerializer()
        {

        }

        /// <summary>
        /// Загружает данные из файла в приложение.
        /// </summary>
        /// <returns>Список контактов.</returns>
        public ObservableCollection<ContactVM> Load()
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

            return contacts;
        }

        /// <summary>
        /// Сохраняет список объектов в файл.
        /// </summary>
        /// <param name="contacts">Список контактов.</param>
        public void Save(ObservableCollection<ContactVM> contacts)
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

        ///// <summary>
        ///// Сериализацию данных.
        ///// </summary>
        ///// <param name="contact">Контакт.</param>
        ///// <param name="path">Путь сериализации.</param>
        //public static void Serialize(Contact contact, string path)
        //{
        //    if (!Directory.Exists(Path.GetDirectoryName(path)))
        //    {
        //        Directory.CreateDirectory(Path.GetDirectoryName(path));
        //    }

        //    using (StreamWriter writer = new StreamWriter(path))
        //    {
        //        writer.Write(JsonConvert.SerializeObject(contact));
        //    }
        //}

        ///// <summary>
        ///// Десериализация данных.
        ///// </summary>
        ///// <param name="path">Путь.</param>
        ///// <returns>Возвращает экземпляр класса <see cref="Contact"/>.</returns>
        //public static Contact Deserialize(string path)
        //{
        //    if (!File.Exists(path))
        //    {
        //        Directory.CreateDirectory(Path.GetDirectoryName(path));
        //    }

        //    var contact = new Contact();

        //    try
        //    {
        //        using (StreamReader reader = new StreamReader(path))
        //        {
        //            contact = JsonConvert.DeserializeObject<Contact>(reader.ReadToEnd());
        //        }

        //        if (contact == null) contact = new Contact();
        //    }
        //    catch (FileNotFoundException e)
        //    {
        //        return contact;
        //    }

        //    return contact;
        //}
    }
}
