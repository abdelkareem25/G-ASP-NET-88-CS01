namespace S02
{
    public class Book
    {
        public string Title { get; set; }
        public int Pages { get; set; }
        public override string ToString()
        {
            return $"Title: {Title}, Pages: {Pages}";
        }
    }
}
