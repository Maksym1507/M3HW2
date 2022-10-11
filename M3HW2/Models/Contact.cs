using System.Text.RegularExpressions;

namespace M3HW2.Models
{
    public class Contact
    {
        public Contact(string name, string surName, string patronymic, string phoneNumber)
        {
            Name = name;
            SurName = surName;
            Patronymic = patronymic;
            PhoneNumber = phoneNumber;
            FullName = $"{SurName} {Name} {Patronymic}";
        }

        public string Name { get; set; }

        public string SurName { get; set; }

        public string Patronymic { get; set; }

        public string PhoneNumber { get; set; }

        public string FullName { get; }

        public override string ToString()
        {
            return $"FIO: {FullName} | Phone number: {string.Format("+38 ({0}) {1}-{2}-{3}", PhoneNumber[..3], PhoneNumber.Substring(3, 3), PhoneNumber.Substring(6, 2), PhoneNumber.Substring(8, 2))}";
        }
    }
}
