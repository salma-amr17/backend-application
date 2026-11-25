using System.Drawing;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskCsharp3 {
    internal class Program {
        static void Main(string[] args) {

            //  1
            string title = "clean code";
            string upperTitle = title.ToUpper();

            Console.WriteLine(title);
            Console.WriteLine(upperTitle);


            // 2
            string a = "Clean Code";
            string b = "Clean Code";

            Console.WriteLine(ReferenceEquals(a, b));


            // 3

            StringBuilder s = new StringBuilder();
            s.Append("Book List ");
            s.Append("Updated");

            Console.WriteLine(s);

            //  4

            s.Replace("Book List ", "Library");

            // 5

            string title_ = "Clean Code";
            int pages = 464;
            string sentence = "Book: " + title_ + " pages : " + pages;
            Console.WriteLine(sentence);

            // 6

            string sentence2 = $"Book: {title_}  pages : {pages}";
            Console.WriteLine(sentence2);

            // 7

            string sentence3 = string.Format("Book {0}  pages: {1}", title_, pages);
            Console.WriteLine(sentence3);

            // 8

            int pages_ = 464;
            if(pages_ > 300) Console.WriteLine("Long book");
            else Console.WriteLine("Short book");

            // 9

            int pages__ = 464;
            bool isAvailable = true;
            if(pages__ > 300 && isAvailable) Console.WriteLine("You can borrow this book");

            // 10

            string title__ = "Refactoring";
            switch(title__) {
                case "Clean Code":
                    Console.WriteLine("Great Choice");
                    break;

                case "Refactoring":
                    Console.WriteLine("Nice Pick!");
                    break;

                default:
                    Console.WriteLine("Never heard of it");
                    break;
                        
            }


            // 11


            string sizeLabel = pages > 300 ? "Long book" : "short book";


            // 12
    

            string[] books = { "Clean Code", "The Pragmatic Programmer", "Refactoring" };
            for(int i = 0; i < books.Length; ++i) {
                Console.WriteLine($"book {i + 1} is {books[i]}");
            }

            // 13

            int cnt = 0;
            while(cnt < books.Length) {
                Console.WriteLine(books[cnt++]);
            }

            // 14


            int cnt_ = 2;
            do {
                Console.WriteLine("Checking book...");

            } while (cnt_-- > 0);


            // 15
            //Using the same books array, use a foreach loop to print every book title.
            foreach(string x in books) {
                Console.WriteLine(x);
            }

            // 16
            

            for (int i = 0; i < books.Length; ++i) {
                if (books[i] == "Refactoring") break;
                Console.WriteLine($"book {i + 1} is {books[i]}");
            }


            // 17
    
            for (int i = 0; i < books.Length; ++i) {
                if (books[i] == "The Pragmatic Programmer") continue;
                Console.WriteLine($"book {i + 1} is {books[i]}");
            }


            // 18
            PrintFirstBook(books);

        }

        public static void PrintFirstBook(string[] books) {
            if (books.Length == 0) return;
            for (int i = 0; i < books.Length; ++i) {
                Console.WriteLine($"book {i + 1} is {books[i]}");
            }
        }
     }
}
