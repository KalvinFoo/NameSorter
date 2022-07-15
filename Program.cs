using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    class Program
    {
        public static void Main(string[] args)
        {
            var nameSorterInstance = new NameSorter();
            var namePrinterInstance = new NamePrinter();
            var namePersistenceInstance = new NamePersistence();
            var program = new MyProgram(nameSorterInstance, namePrinterInstance, namePersistenceInstance);

            program.Run();
        }
    }

    public class MyProgram
    {
        static readonly string _inputFileName = "unsorted-names-list.txt";
        static readonly string _outputFileName = "sorted-names-list.txt";
        static readonly string _fileDirectory = AppDomain.CurrentDomain.BaseDirectory;

        private readonly INameSorter _nameSorter;
        private readonly INamePrinter _namePrinter;
        private readonly INamePersistence _namePersistence;

        public MyProgram(INameSorter nameSorter, INamePrinter namePrinter, INamePersistence namePersistence)
        {
            _nameSorter = nameSorter;
            _namePrinter = namePrinter;
            _namePersistence = namePersistence;
        }

        public void Run()
        {
            string inputFilePath = Path.Combine(_fileDirectory, _inputFileName);
            string outputFilePath = Path.Combine(_fileDirectory, _outputFileName);

            //Read file containing the names
            var names = _namePersistence.ReadFile(inputFilePath);

            //Sort the names
            var result = _nameSorter.SortByLastName(names);

            //Write the sorted names to a text file
            _namePersistence.SaveToFile(outputFilePath, result);

            //Print the result
            _namePrinter.Print(result);
        }
    }

}
