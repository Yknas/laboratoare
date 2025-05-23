﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
     class FileItem
    {
        public string Name { get; set; }
        public  DateTime DateCreated { get; set; }
        public int Size { get; set; }

        public override string ToString()
        {
            return $"{Name} - {DateCreated.ToShortDateString()} - {Size}KB";
        }
    }
}
