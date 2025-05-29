using lab4;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Test
    {
        public void TestTextBookCreation()
        {
            Book book = new Book { Title = "The C Programming Language", Author = "Brian Kernighan" };
            Assert.AreEqual("The C Programming Language", book.Title);
            Assert.AreEqual("Brian Kernighan", book.Author);
        }

        public void TestMagazineCreation()
        {
            Magazine magazine = new Magazine { Title = "Wired", Author = "Conde Nast", IssueNumber = 146 };
            Assert.AreEqual("Wired", magazine.Title);
            Assert.AreEqual(146, magazine.IssueNumber);
        }
    }
}
