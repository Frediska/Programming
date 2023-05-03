using View.ViewModel;

namespace View.Model.Services
{
    public static class ContactFactory
    {
        public static ContactVM CreateContact()
        {
            var contact = new Contact();
            contact.Name = "Макаров Александр Александрович";
            contact.Phone = "89516153315";
            contact.Email = "zuzzlk@mail.ru";
            var contactVM = new ContactVM(contact);

            return contactVM;
        }
    }
}
