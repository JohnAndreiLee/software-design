namespace TestPolymorphism
{
    public class Textbook : Book
    {
        private string _subject;
        public string Subject { 
            get => _subject;
            set
            {
                if (String.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Subject cannot be null or empty.");
                }
                _subject = value;
            } 
        }

        public override string GetInfo()
        {
            return $"{Title} by {Author} - Subject: {Subject}";
        }
    }
}
