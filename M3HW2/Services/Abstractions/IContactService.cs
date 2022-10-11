using System.Globalization;
using M3HW2.Models;

namespace M3HW2.Services.Abstractions
{
    public interface IContactService
    {
        void SetCulture(CultureInfo culture);

        void InitializeContactBook();

        void AddContacts(Contact[] contacts);

        void ShowContacts();

        void ContactsSort(IComparer<Contact> comparer);
    }
}
