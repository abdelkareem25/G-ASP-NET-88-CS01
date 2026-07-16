namespace S02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            /*
             Create a Book class with a Title (string) and Pages (int).
             Create a Book object and store it in a variable of type object. Print it.
             */
            object b = new Book()
            {
                Title = "Harry Potter",
                Pages = 500
            };
            Console.WriteLine(b);
            #endregion


            #region Q2
            /*
             * Using the Book class above, print the result of calling ToString(),
             * Equals() (compare book with itself), GetHashCode(), and GetType() on book
             */
            Console.WriteLine(b.ToString());
            Console.WriteLine(b.Equals(b));
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(b.GetType());
            #endregion
        }
    }
}
