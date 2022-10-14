using System.Globalization;
using M3HW2.Configs;
using M3HW2.Models;
using M3HW2.Services.Abstractions;

namespace M3HW2.Services
{
    public class ContactService : IContactService
    {
        public ContactService(IAlphabetConfigurationService alphabetConfigurationService)
        {
            ContactBook = new Dictionary<string, List<Contact>>();

            AlphabetConfigurationService = alphabetConfigurationService;

            AlphabetConfig = AlphabetConfigurationService.DeserializeAlphabet("../../../config.json");
        }

        private CultureInfo Culture { get; set; }

        private IAlphabetConfigurationService AlphabetConfigurationService { get; }

        private Dictionary<string, List<Contact>> ContactBook { get; set; }

        private AlphabetConfig AlphabetConfig { get; }

        public void AddContacts(Contact[] contacts)
        {
            for (int i = 0; i < contacts.Length; i++)
            {
                if (char.IsDigit(contacts[i].FullName[0]))
                {
                    ContactBook["0-9"].Add(contacts[i]);
                }
                else if (ContactBook.ContainsKey(contacts[i].FullName.ToUpper()[0].ToString()))
                {
                    ContactBook[contacts[i].FullName[0].ToString()].Add(contacts[i]);
                }
                else
                {
                    ContactBook["#"].Add(contacts[i]);
                }
            }
        }

        public void ShowContacts()
        {
            Console.WriteLine("Contack book");

            foreach (var contacts in ContactBook)
            {
                int contactCounter = 0;

                if (contacts.Value.Count > 0)
                {
                    Console.WriteLine(contacts.Key);

                    foreach (var contact in contacts.Value)
                    {
                        Console.WriteLine($"{++contactCounter}. {contact}");
                    }
                }
            }
        }

        public void ContactsSort(IComparer<Contact> comparer)
        {
            foreach (var item in ContactBook)
            {
                if (item.Value.Count > 0)
                {
                    item.Value.Sort(comparer);
                }
            }
        }

        public void SetCulture(CultureInfo culture)
        {
            Culture = culture;
        }

        public void InitializeContactBook()
        {
            for (int i = 0; i < AlphabetConfig.Alphabet.Alphabets[Culture.Name].Length; i++)
            {
                ContactBook.Add(AlphabetConfig.Alphabet.Alphabets[Culture.Name][i].ToString(), new List<Contact>());
            }

            ContactBook.Add("0-9", new List<Contact>());
            ContactBook.Add("#", new List<Contact>());
        }
    }
}
