using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab4
{
    public class Magazine : Book
    {
        public int IssueNumber { get; set; }

        public override string GetInfo()
        {
            return $"{Title} by {Author} - Issue: {IssueNumber}";
        }
    }
}
