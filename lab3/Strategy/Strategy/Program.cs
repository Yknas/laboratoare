using ConsoleApp1.Strategy;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Strategy

{
    internal class Program
    {
        static void Main(string[] args)
        {
            //strategia de sortare dupa data 
            IFileSortStrategy filesSortByDate = new SortByDate();

            //sorter care foloseste strategia 
            FileSorter sorter = new FileSorter(filesSortByDate);
            FileItem file1 = new FileItem { Name = "Document.txt", DateCreated = new DateTime(2024, 10, 1), Size = 120 };
            FileItem file2 = new FileItem { Name = "Presentation.ppt", DateCreated = new DateTime(2023, 5, 12), Size = 350 };
            FileItem file3 = new FileItem { Name = "Archive.zip", DateCreated = new DateTime(2025, 1, 20), Size = 800 };

            sorter.AddFile(file1);
            sorter.AddFile(file2);
            sorter.AddFile(file3);

            sorter.SortFiles();

            //strategia de sortare dupa marime
            IFileSortStrategy filesSortBySize = new SortBySize();

            //sorter care foloseste strategia 
            sorter.SetSorter(filesSortBySize);
            sorter.SortFiles();







        }
    }
}
