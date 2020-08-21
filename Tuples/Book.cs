namespace Tuples
{
    public class Book
    {
        public Book(int id, string title, string author)
        {
            Id = id;
            Title = title;
            Author = author;
        }

        public void Deconstruct (out int id, out string title, out string author)
        {
            id = Id;
            title = Title;
            author = Author;
        }

        public void Deconstruct(out string title, out string author)
        {
            title = Title;
            author = Author;
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }

        public override string ToString()
        {
            return $"{Title} by {Author} ({Id})";
        }
    }
}
