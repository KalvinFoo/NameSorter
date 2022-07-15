using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public class NamePersistence : INamePersistence
    {
        /// <summary>
        /// Write or overwrite the result into the targeted text file
        /// </summary>
        public void SaveToFile(string filePath, string[] names)
        {
            File.WriteAllLines(filePath, names);
        }

        /// <summary>
        /// Read source text file
        /// </summary>
        /// <returns>Names as string array</returns>
        public string[] ReadFile(string filePath)
        {
            if (!File.Exists(filePath))
            {
                throw new Exception("'File is not found. Please check again...");
            }

            string[] names = File.ReadLines(filePath).ToArray();

            return names;
        }
    }
}
