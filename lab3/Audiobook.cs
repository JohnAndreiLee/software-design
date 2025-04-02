using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab3
{
    public class Audiobook : Book
    {
        public int Duration { get; set; }
        public string Narrator { get; set; }

        public override string GetInfo()
        {
            return $"{Title} by {Author} - Narrated by: {Narrator} ({Duration} minutes)";
        }
    }
}
