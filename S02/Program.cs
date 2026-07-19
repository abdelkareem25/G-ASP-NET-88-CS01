namespace S02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region G-NET-88-CS01
            #region Q1
            //Console.WriteLine("Q1:");
            /*
             Create a Book class with a Title (string) and Pages (int).
             Create a Book object and store it in a variable of type object. Print it.
             */
            //object b = new Book()
            //{
            //    Title = "Harry Potter",
            //    Pages = 500
            //};
            //Console.WriteLine(b);
            #endregion
            #region Q2
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q2:");
            /*
             * Using the Book class above, print the result of calling ToString(),
             * Equals() (compare book with itself), GetHashCode(), and GetType() on book
             */
            //Console.WriteLine(b.ToString());
            //Console.WriteLine(b.Equals(b));
            //Console.WriteLine(b.GetHashCode());
            //Console.WriteLine(b.GetType());
            #endregion
            #region Q3
            //Cannot understand the question
            #endregion
            #region Q4
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q4:");
            ///*
            // Write code that divides 10 by 0 inside a try block,
            // catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            // */
            //try
            //{
            //    int result = 10, divisor = 0;
            //    int DivisionResult = result / divisor;
            //    Console.WriteLine(DivisionResult);
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}
            #endregion
            #region Q5
            /*
             Declare an int pages = 300; then store it in a double variable without using a cast.
             */
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q5:");
            //int pages = 300;
            //double pagesDouble = pages;
            //Console.WriteLine(pagesDouble);
            #endregion
            #region Q6
            /*
             Declare a double price = 49.99; then convert it into an int using a cast.
             */
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q6:");
            //double price = 49.99;
            //int priceInt = (int)price;
            //Console.WriteLine(priceInt);
            #endregion
            #region Q7
            /*
             * Given string pagesText = "464";, convert it into an int using the Convert class.
             */
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q7:");
            //string pagesText = "464";
            //int pagesInt = Convert.ToInt32(pagesText);
            //Console.WriteLine(pagesInt);
            #endregion
            #region Q8
            /*
             * Given string yearText = "2023";, convert it using int.Parse(). Then given string badText = "abc";,
             * use int.TryParse() to safely try converting it, and print "Invalid number" if it fails.
             */
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q8:");
            //string yearText = "2023";
            //int year = int.Parse(yearText);
            //Console.WriteLine($"Year: {year}");
            //string badText = "abc";
            //if (int.TryParse(badText, out int badNumber))
            //{
            //    Console.WriteLine($"Parsed number: {badNumber}");
            //}
            //else
            //{
            //    Console.WriteLine("Invalid number");
            //}
            #endregion
            #region Q9
            /*Given int pages = 464;,
             * convert it into a string using ToString() and print its type using GetType() to prove it's now a string.*/
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q9:");
            //int pagesQ9 = 464;
            //string PagesString = pagesQ9.ToString();
            //Console.WriteLine(PagesString.GetType());
            #endregion
            #region Q10
            /*Declare int copies = 100;. Box it into an object variable, then unbox it back into a new int variable, and print both.
             */
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q10:");
            //int copies = 100;
            //object Box = copies; // Boxing
            //int UnBox = (int)Box; // Unboxing
            //Console.WriteLine($"Boxed value: {Box}");
            //Console.WriteLine($"Unboxed value: {UnBox}");
            #endregion
            #region Q11
            /*
             * Declare an int? year = null;. Print whether it has a value, then assign it 2023 and print its value.
             */
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q11:");
            //int? yearQ11 = null;
            //Console.WriteLine($"Year has value: {yearQ11.HasValue}");
            //yearQ11 = 2023;
            //Console.WriteLine($"Year value: {yearQ11}");
            #endregion
            #region Q12
            /*
             Declare a string? reviewer = null;. Print whether it is null.
             */
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q12:");
            //string? reviewer = null;
            //Console.WriteLine($"Reviewer is null: {reviewer}");
            #endregion
            #region Q13
            /*
             * Declare a Book? book = null;. Use ?. to safely read book.Title without crashing the program, and print the result.
             */
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q13:");
            //Book? bookQ13 = null;
            //Console.WriteLine($"Book title: {bookQ13?.Title}");
            #endregion

            #region Q14
            /*
             * Using title from the previous question, use ?? to print "Untitled" if title is null.
             * Then use ??= to assign title the value "Untitled" only if it's still null.
             */
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q14:");
            //string? title = null;
            //Console.WriteLine($"Title: {title ?? "Untitled"}");
            //title ??= "Untitled";
            //Console.WriteLine($"Title: {title}");
            #endregion
            #region Q15
            /*
             * Given string? name = "Ahmed"; (you are sure it's not null here),
             * assign it to a non-nullable string confirmedName using the ! operator.
             */
            //Console.WriteLine("-----------------------------------");
            //Console.WriteLine("Q15:");
            //string? name = "Ahmed";
            //string confirmedName = name!;
            //Console.WriteLine(confirmedName);
            #endregion
            #endregion

            #region G-NET-88-CS02
            
            
            #region Q1
            Console.WriteLine("Question 01 ");
            Console.WriteLine("-------------------------");
            /*
             Given int pages = 464;, write an if / else statement that
            prints “Long Book” if pages is greater than 300, otherwise prints “Short
            Book”.
            */
            int D2pages = 464;
            if (D2pages > 300)
            {
                Console.WriteLine("Long Book");

            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion
            #region Q2
            Console.WriteLine("-------------------------");
            Console.WriteLine("Question 02 ");
            /*
            Given int pages = 464; and bool isAvailable = true;, print
            “You can borrow this book” only if pages is greater than 300 and
            isAvailable is true. Use the && operator.
            */
            int pages = 464;
            bool isAvailable = true;
            if(pages > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            else
            {
                Console.WriteLine("You cannot borrow this book");
            }
            #endregion
            #region Q3
            Console.WriteLine("-------------------------");
            Console.WriteLine("Question 03 ");
            /*
                Given string title = “Refactoring”;, write a switch
                statement that prints: - “Great choice!” if the title is “Clean Code” -
                “Nice pick!” if it’s “Refactoring” - “Never heard of it” for anything
                else.
            */
            string title = "Refactoring";
            switch(title)
            {
                case "Clean Code":
                    Console.WriteLine("Great choice!");
                    break;
                case "Refactoring":
                    Console.WriteLine("Nice pick!");
                    break;
                default:
                    Console.WriteLine("Never heard of it");
                    break;
            }
            #endregion
            #region Q4
            Console.WriteLine("-------------------------");
            Console.WriteLine("Question 04");
            /*
             * Given string[] books = { “Clean Code”, “The Pragmatic
             *Programmer”, “Refactoring” };, use a for loop to print each book with
             *its position number, like: 1. Clean Code
             */
             string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
             for(int i= 0 ; i < books.Length; i++)
             {
                Console.WriteLine($"{i + 1}. {books[i]}");
             }
            #endregion
            #region Q5
            Console.WriteLine("-------------------------");
            Console.WriteLine("Question 05");
            /*
            * Using the same books array, use a while loop to print every book title.
            */
            int bookIndex = 0;
            while(bookIndex < books.Length)
            {
                Console.WriteLine(books[bookIndex]);
                bookIndex++;
            }
            #endregion
            #region Q6
            Console.WriteLine("-------------------------");
            Console.WriteLine("Question 06");
            /*
            * Write a do-while loop that prints “Checking book…” exactly 3 times.
            */
            int Q6bookIndex = 0;
            do
            {
                Console.WriteLine("Checking book...");
                Q6bookIndex++;
            }while (Q6bookIndex < 3);
            #endregion
            #region Q7
            Console.WriteLine("-------------------------");
            Console.WriteLine("Question 07");
            /*
             * Using the same books array, use a foreach loop to print every book title.
             */
             foreach(string book in books)
             {
                Console.WriteLine(book);
             }
            #endregion
            #endregion
        }
    }
}
