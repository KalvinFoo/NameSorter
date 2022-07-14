using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NameSorters
    {
        static readonly string inputFileName = "unsorted-names-list.txt";
        static readonly string outputFileName = "sorted-names-list.txt";
        static readonly string fileDirectory = AppDomain.CurrentDomain.BaseDirectory;

        public static void Main(string[] args)
        {
            var nameSorter = new NameSorters();
            var result = nameSorter.ReadAndSortByLastName(inputFileName);

            Array.ForEach(result, Console.WriteLine);
            Console.ReadLine();
        }

        /// <summary>
        /// Return names sorted by last name, then by full name
        /// </summary>
        /// <param name="prmInputFileName">The source text file containing the names that need to be sorted</param>
        /// <returns>Sorted names as string array</returns>
        public string[] ReadAndSortByLastName(string prmInputFileName)
        {
            string inputFilePath = Path.Combine(fileDirectory, prmInputFileName);
            string outputFilePath = Path.Combine(fileDirectory, outputFileName);

            if (!File.Exists(inputFilePath))
            {
                throw new Exception("'File is not found. Please check again...");
            }

            string[] names = File.ReadLines(inputFilePath).ToArray(); //Read source text file

            var sortingResult = names.OrderBy(x => x.Split(' ').Last()) //Sort by last name, then by full name
                .ThenBy(n => n)
                .ToArray();

            File.WriteAllLines(outputFilePath, sortingResult); //Write or overwrite the result into the targeted text file

            return sortingResult;
        }
    }
}
