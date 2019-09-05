using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_book
{ //LIAM SULLIVAN STUDENT ID: 30022060
    public class Book
    {
        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }

        public Book()
        {

        }
        public Book(string tle, string au, string pub)
        {
            Console.WriteLine("\n***New Book has been processed***");
            title = tle;
            author = au;
            publisher = pub;
        }
        public string GetBook()
        {
            return $"Book Title: {title}\nBook Author: {author}\nBook Publisher: {publisher}";
        }
    }
}
