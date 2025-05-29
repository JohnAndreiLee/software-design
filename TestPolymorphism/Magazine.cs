using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestPolymorphism
{
    public class Magazine : Book
    {
        //Error handling code
        private int _issueNumber;
        public int IssueNumber { 
            get => _issueNumber;
            set
            {
                if (value < 0)
                {
                    throw new ArgumentException("Issue number must be non-negative.");
                }
                _issueNumber = value;
            }
        }

        public override string GetInfo()
        {
            return $"{Title} by {Author} - Issue: {IssueNumber}";
        }
    }
}
