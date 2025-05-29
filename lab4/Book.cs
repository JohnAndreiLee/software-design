using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Book
    {
        public String Title { get; set; }
        public String Author { get; set; }
        public virtual string GetInfo()
        {
            return $"{Title} by {Author}";
        }

    }
}
