using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class Program
    {
        static readonly string _inputFileName = "unsorted-names-list.txt";

        public static void Main(string[] args)
        {
            //Sort the names
            var nameSorter = new NameSorter
            {
                InputFileName = _inputFileName
            };
            var result = nameSorter.SortByLastName();

            //Print the result
            var namePrinter = new NamePrinter
            {
                Names = result
            };
            namePrinter.Print();
        }
    }
}
