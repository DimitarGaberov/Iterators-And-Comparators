using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class NameComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int result = x.Name.Length - y.Name.Length;
        if (result == 0)
        {
            char xFirstLetter = Char.ToLower(x.Name[0]);
            char yFirstLetter = Char.ToLower(y.Name[0]);
            result = xFirstLetter.CompareTo(yFirstLetter);
        }

        return result;
    }
}
