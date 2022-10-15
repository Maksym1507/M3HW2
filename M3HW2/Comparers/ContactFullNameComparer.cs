using M3HW2.Models;

namespace M3HW2.Comparers
{
    public class ContactFullNameComparer : Comparer<Contact>
    {
        public override int Compare(Contact x, Contact y)
        {
            if (x.FullName.CompareTo(y.FullName) > 0)
            {
                return 1;
            }
            else if (x.FullName.CompareTo(y.FullName) < 0)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
