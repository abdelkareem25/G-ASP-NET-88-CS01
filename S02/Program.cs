namespace S02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1
            Console.WriteLine("Q1:");
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
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Q2:");
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
            //Cannot understand the question
            #endregion
            #region Q4
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Q4:");
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
            #region Q5
            /*
             Declare an int pages = 300; then store it in a double variable without using a cast.
             */
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Q5:");
            int pages = 300;
            double pagesDouble = pages;
            Console.WriteLine(pagesDouble);
            #endregion
            #region Q6
            /*
             Declare a double price = 49.99; then convert it into an int using a cast.
             */
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Q6:");
            double price = 49.99;
            int priceInt = (int)price;
            Console.WriteLine(priceInt);
            #endregion
            #region Q7
            /*
             * Given string pagesText = "464";, convert it into an int using the Convert class.
             */
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Q7:");
            string pagesText = "464";
            int pagesInt = Convert.ToInt32(pagesText);
            Console.WriteLine(pagesInt);
            #endregion
            #region Q8
            /*
             * Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
             * use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
             */
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Q8:");
            string yearText = "2023";
            int year = int.Parse(yearText);
            Console.WriteLine($"Year: {year}");
            string badText = "abc";
            if (int.TryParse(badText, out int badNumber))
            {
                Console.WriteLine($"Parsed number: {badNumber}");
            }
            else
            {
                Console.WriteLine("Invalid number");
            }
            #endregion
            #region Q9
            /*Given int pages = 464;,
             * convert it into a string using ToString() and print its type using GetType() to prove it's now a string.*/
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("Q9:");
            int pagesQ9 = 464;
            string PagesString = pagesQ9.ToString();
            Console.WriteLine(PagesString.GetType());
            #endregion




        }
    }
}
