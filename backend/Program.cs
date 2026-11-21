using System.Drawing;
using System.Runtime.Intrinsics.X86;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace TaskCsharpSession2 {
    internal class Program {
        static void Main(string[] args) {


            //     q 1
            Book b = new Book();
            b.Pages = 135; b.Title = "Harry Potter";
            Console.WriteLine($"page number = {b.Pages}, \n title is {b.Title}"); // 1
            ///////////////////////////////////////
            
            //  q2

            Console.WriteLine(b.ToString());
            Console.WriteLine(b.Equals(b));
            Console.WriteLine(b.GetHashCode());
            Console.WriteLine(b.GetType());
            /////////////////////////////////////////// 
           
            // q 3


            //int pages = "123"; // syntax error (compile time)
            // fix
            int pages = int.Parse("123");

            ///////////////////////////////////////
            

            //   q 4

            int A = 10, B = 0, ans;
            try {
                ans = A / B;
            }
            catch (DivideByZeroException){
                Console.WriteLine("Cannot divide by zero");
            }
            finally {
                Console.WriteLine("done");
            }

            ///////////////////////////////////////////
            
            //   q 5

            int Pages = 300;
            double pages_ = 300d;

            ////////////////////////////////////////////


            //   q 6
            double price = 49.99;
            int price_ = (int)price;

            //////////////////////////////////////////
              

            //   q 7


            string PagesText = "464";
            int PagesText_ = Convert.ToInt32(PagesText);

            //////////////////////////////////////////

            // q 8


            string yearText = "2023";
            int yearText_ = int.Parse(yearText);

            string badText = "abc";

            if(int.TryParse(badText, out int num)) {
                Console.WriteLine($"bad no is  {num}");
            }
            else {
                Console.WriteLine("Invalid");
            }

            //////////////////////////////////////////////

            //    q 9

            int pages__ = 464;
            string pages_s = pages__.ToString();

            Console.WriteLine(pages_s.GetType());

            ///////////////////////////////////////////////

            //  q 10

            int copies = 100;
            object o = copies;   // boxing

            int copies_unboxing = (int)o;
            Console.WriteLine(copies);
            Console.WriteLine(o);
        }
    }
}
