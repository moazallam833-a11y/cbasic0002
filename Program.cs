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





        }
    }
}
