using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NamePrinter
    {
        public string[] Names { get; set; }

        /// <summary>
        /// Print the results of the sorted names to the screen
        /// </summary>
        public void Print()
        {
            Array.ForEach(Names, Console.WriteLine);
            Console.ReadLine();
        }

    }
}
