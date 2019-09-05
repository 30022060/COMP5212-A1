using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_book
{
    class Program
    { //LIAM SULLIVAN STUDENT ID: 30022060
        static void Main(string[] args)
        {
        }
    }
    public class Book
    {
        private string author;
        private string title;
        private string publisher;

        public string au { get { return author; } set { author = value; } }
        public string tle { get { return title; } set { title = value; } }
        public string pub { get { return publisher; } set { publisher = value; } }

        public string Details()
        {
            return $"Book Author: {au}\nBook Title: {tle}\nBook Publisher: {pub}";
        }

    }
}
