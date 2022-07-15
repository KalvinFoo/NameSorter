using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NamePrinter : INamePrinter
    {
        /// <summary>
        /// Print the results of the sorted names to the screen
        /// </summary>
        public void Print(string[] names)
        {
            Array.ForEach(names, Console.WriteLine);
            Console.ReadLine();
        }

    }
}
