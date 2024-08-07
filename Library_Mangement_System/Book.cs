using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library_Mangement_System
{
    internal class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public int NumberOfCopies { get; set; }
        public Book(string title, string author, int numberOfCopies)
        {
            Title = title;
            Author = author;
            NumberOfCopies = numberOfCopies;
        }
    }
}
