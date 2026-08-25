using System.Drawing;
using System.Dynamic;
using System.Timers;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace assigment_03_c__basics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //1. Create Book class, object, store it in object, then print
            //    public class Book
            //{
            //    public string Title { get; set; }
            //    public int Pages { get; set; }
            //}

            //Book book = new Book
            //{
            //    Title = "Clean Code",
            //    Pages = 464
            //};

            //object obj = book;

            //Console.WriteLine(obj);

            //Using the Book class above, print the result of calling ToString(), Equals() (compare book with itself), GetHashCode(), and GetType() on book
            //Book book = new Book
            //{
            //    Title = "Clean Code",
            //    Pages = 464
            //};

            //Console.WriteLine(book.ToString());
            //Console.WriteLine(book.Equals(book));
            //Console.WriteLine(book.GetHashCode());
            //Console.WriteLine(book.GetType());

            //3.Is this a compile-time, runtime, or logical error?
            //int pages = "464";
            //This is a compile - time error
            //Because "464" is a string, while pages is declared as an int.

            ////Fix:
            //int pages = 464;
            //int pages = int.Parse("464");

            //4.Write code that divides 10 by 0 inside a try block, catches the exception, prints "Cannot divide by zero", and then prints "Done" in a finally block.
            //try
            //{
            //    int result = 10 / 0;
            //}
            //catch (DivideByZeroException)
            //{
            //    Console.WriteLine("Cannot divide by zero");
            //}
            //finally
            //{
            //    Console.WriteLine("Done");
            //}







        }
    }
}
