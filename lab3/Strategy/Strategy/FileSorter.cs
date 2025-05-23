using ConsoleApp1.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
     class FileSorter
    {
        //lista privata
        private readonly List<FileItem> _files; 

        private IFileSortStrategy _filesSort;
         
        //initializarea listei in constructor
        public FileSorter(IFileSortStrategy filesSort)
        {
            _files = new List<FileItem>();
            _filesSort = filesSort;

        }

       public void SetSorter(IFileSortStrategy filesSort)
       {
           _filesSort = filesSort;
       } 

        public void AddFile(FileItem file)
        {
            _files.Add(file);
        }
        public void SortFiles()
        {
            var sortedFiles = _filesSort.Sort(_files); // returnează lista sortată

            Console.WriteLine(" Fișiere sortate ");
            foreach (var file in sortedFiles)
            {
                Console.WriteLine(file); 
            }
           
        }

    }
}
