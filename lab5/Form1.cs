namespace lab5
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
        }
        
    }

    public class Author
    {
        public int AuthorID { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Book> Books { get; set; }
    }

    public class Book
    {
        public int BookID { get; set; }
        public string Title { get; set; }
        public int AuthorID { get; set; }
        public virtual Author Author { get; set; }
    }
}
}
