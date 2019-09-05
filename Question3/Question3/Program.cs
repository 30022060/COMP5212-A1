using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using class_book;
namespace Question3
{
    class Program
    {//LIAM SULLIVAN STUDENT ID: 30022060
        static void Main(string[] args)
        {
            Console.WriteLine("\t***PLEASE ENTER BOOK DETAILS***\n");
            Book b1 = new Book();
            Console.Write("Enter Book Title Name: ");
            b1.title = Console.ReadLine();
            Console.Write("Enter Book Author Name: ");
            b1.author = Console.ReadLine();
            Console.Write("Enter Book Publisher Name: ");
            b1.publisher = Console.ReadLine();

            Console.WriteLine("\n***BOOK DETAILS***\n");
            Console.WriteLine(b1.GetBook());
            Console.ReadLine();
        }
    }
}
