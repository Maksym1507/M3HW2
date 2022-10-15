using System.Globalization;
using M3HW2.Comparers;
using M3HW2.Models;
using M3HW2.Services.Abstractions;

namespace M3HW2
{
    public class Starter
    {
        public Starter(IContactService contactService)
        {
            ContactService = contactService;
        }

        private IContactService ContactService { get; }

        private Contact[] Contacts { get; } =
        {
            new Contact("Vlad", "Petrov", "Olegovich", "0957178012"),
            new Contact("Діма", "Кравцов", "Іванович", "0638166583"),
            new Contact("Anton", "Gromov", string.Empty, "0951946156"),
            new Contact("Gennadiy", "Panov", "Oleksandrovich", "0508641585"),
            new Contact("Максим", "Ілларіонов", "Юрійович", "0680243923"),
            new Contact("Роман", "Каменюка", "Павлович", "0980427548"),
            new Contact("Robert", "Filatov", "Timurovich", "0680285993"),
            new Contact("Ostap", "Vushnya", "Evgenovich", "0560235775"),
            new Contact("Vlad", "%Denisov", "Oleksandrovich", "0999257379"),
            new Contact("Міша", "Шкарлат", "Дмитрович", "0680348434"),
            new Contact("Nikolay", "3Piantkovskiy", "Kirillovich", "0679389592"),
            new Contact("Валерій", "Латов", "Olegovich", "0539891868"),
        };
        public void Run()
        {
            Console.WriteLine("Choose locale: en - 1 | ua - 2");

            CultureInfo culture = Convert.ToInt32(Console.ReadLine()) switch
            {
                1 => new CultureInfo("en-US"),
                2 => new CultureInfo("uk-UA"),
                _ => new CultureInfo("en-US"),
            };

            ContactService.SetCulture(culture);

            ContactService.InitializeContactBook();

            ContactService.AddContacts(Contacts);

            ContactService.ShowContacts();

            ContactService.ContactsSort(new ContactFullNameComparer());

            ContactService.ShowContacts();
        }
    }
}
