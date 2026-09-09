using System.Text;

namespace c_0002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Q1 
            string title = "clean code";

            string upperTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(upperTitle);
            #endregion

            #region Q2

            string str1 = "Clean Code";
            string str2 = "Clean Code";

            bool sameReference = ReferenceEquals(str1, str2);

            Console.WriteLine(sameReference);
            #endregion

            #region q3
            StringBuilder sb = new StringBuilder();

            sb.Append("Book List");
            sb.Append(" - Updated");

            Console.WriteLine(sb);

            #endregion

            #region Q8
            // Given int pages = 464;, write an if / else statement that prints
            // "Long Book" if pages is greater than 300, otherwise prints "Short Book".

            int pages4 = 464;

            if (pages4 > 300)
            {
                Console.WriteLine("Long Book");
            }
            else
            {
                Console.WriteLine("Short Book");
            }
            #endregion

            #region Q9
            // Given int pages = 464; and bool isAvailable = true;, print
            // "You can borrow this book" only if pages is greater than 300
            // and isAvailable is true. Use the && operator.

            int pages5 = 464;
            bool isAvailable = true;

            if (pages5 > 300 && isAvailable)
            {
                Console.WriteLine("You can borrow this book");
            }
            #endregion

            #region Q10
            // Given string title = "Refactoring";, write a switch statement that prints
            // "Great choice!" if the title is "Clean Code",
            // "Nice pick!" if it's "Refactoring",
            // and "Never heard of it" for anything else.

            string title4 = "Refactoring";

            switch (title4)
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

            #region Q11
            // Given int pages = 464;, use the ternary operator to store
            // "Long Book" or "Short Book" into a variable sizeLabel.
            // Long if pages > 300.

            int pages6 = 464;

            string sizeLabel = pages6 > 300 ? "Long Book" : "Short Book";

            Console.WriteLine(sizeLabel);
            #endregion

            #region Q12
            // Given string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };,
            // use a for loop to print each book with its position number,
            // like 1. Clean Code.

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };

            for (int s = 0; s < books.Length; s++)
            {
                Console.WriteLine($"{s + 1}. {books[s]}");
            }
            #endregion











        }
    }
}
