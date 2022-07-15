using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NamePersistence
    {
        public string FilePath { get; set; }
        public string[] Names { get; set; }

        /// <summary>
        /// Write or overwrite the result into the targeted text file
        /// </summary>
        public void SaveToFile()
        {
            File.WriteAllLines(FilePath, Names);
        }

        /// <summary>
        /// Read source text file
        /// </summary>
        /// <returns>Names as string array</returns>
        public string[] ReadFile()
        {
            if (!File.Exists(FilePath))
            {
                throw new Exception("'File is not found. Please check again...");
            }

            string[] names = File.ReadLines(FilePath).ToArray();

            return names;
        }
    }
}
