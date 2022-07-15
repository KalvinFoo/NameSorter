using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NameSorter : INameSorter
    {
        /// <summary>
        /// Return names sorted by last name, then by full name
        /// </summary>
        /// <returns>Sorted names as string array</returns>
        public string[] SortByLastName(string[] names)
        {
            var sortingResult = names.OrderBy(x => x.Split(' ').Last())
                .ThenBy(n => n)
                .ToArray();

            return sortingResult;
        }
    }
}
