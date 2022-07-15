using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public interface INameSorter
    {
        string[] SortByLastName(string[] Names);
    }
}
