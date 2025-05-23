using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.Strategy
{
    class SortBySize : IFileSortStrategy
    {
        
        public List<FileItem> Sort(List<FileItem> files)
        {
            return files.OrderBy(f => f.Size).ToList();
        }
    }
}
