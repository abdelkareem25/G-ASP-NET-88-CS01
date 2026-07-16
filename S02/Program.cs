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

            #region Q3

            #endregion

            #region Q4
            /*
             Write code that divides 10 by 0 inside a try block,
             catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
             */
            try
            {
                int result = 10, divisor = 0;
                int DivisionResult = result / divisor;
                Console.WriteLine(DivisionResult);
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot divide by zero");
            }
            finally
            {
                Console.WriteLine("Done");
            }
            #endregion
        }
    }
}
