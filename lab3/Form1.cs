using System.Runtime.InteropServices;

namespace lab3
{
    public partial class Form1 : Form
    {
        Book[] bookLibrary = new Book[3];
        List<String> bookInfo = new List<String>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bookLibrary[0] = new Book { Title = "Neuromancer", Author = "William Gibson" };
            bookLibrary[1] = new Ebook { Title = "Snow Crash", Author = "Neal Stephenson", SizeMB = 5 };
            bookLibrary[2] = new Magazine { Title = "Wired", Author = "Conde Nast", IssueNumber = 146 };

            foreach (Book books in bookLibrary)
            {
                bookInfo.Add(books.GetInfo());
            }
            listBox.DataSource = bookInfo;
        }

        private void btnDisplay_Click(object sender, EventArgs e)
        {
            MessageBox.Show(bookLibrary[1].GetInfo());
        }
    }
}
