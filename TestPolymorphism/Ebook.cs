﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolymorphism
{
    public class Ebook : Book
    {
        public int SizeMB { get; set; }
        public override string GetInfo()
        {
            return $"{Title} by {Author} - Size: {SizeMB}MB";
        }
    }
}
