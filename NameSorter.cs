using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NameSorter
    {
        public string InputFileName { get; set; }
        public string OutputFileName { get; set; } = "sorted-names-list.txt";
        public string FileDirectory { get; set; } = AppDomain.CurrentDomain.BaseDirectory;

        private readonly NamePersistence namePersistence;

        public NameSorter()
        {
            namePersistence = new NamePersistence();
        }

        /// <summary>
        /// Return names sorted by last name, then by full name
        /// </summary>
        /// <returns>Sorted names as string array</returns>
        public string[] SortByLastName()
        {
            string inputFilePath = Path.Combine(FileDirectory, InputFileName);
            string outputFilePath = Path.Combine(FileDirectory, OutputFileName);

            //Read file containing the names
            namePersistence.FilePath = inputFilePath;
            var names = namePersistence.ReadFile();

            //Sort by last name, then by full name
            var sortingResult = names.OrderBy(x => x.Split(' ').Last())
                .ThenBy(n => n)
                .ToArray();

            //Write the sorted names to a text file
            namePersistence.FilePath = outputFilePath;
            namePersistence.Names = sortingResult;
            namePersistence.SaveToFile();

            return sortingResult;
        }
    }
}
