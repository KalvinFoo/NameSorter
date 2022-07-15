using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameSorter
{
    public interface INamePersistence
    {
        void SaveToFile(string filePath, string[] names);
        string[] ReadFile(string filePath);
    }
}
