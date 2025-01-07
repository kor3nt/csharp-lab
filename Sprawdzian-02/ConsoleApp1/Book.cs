using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Book
    {
        public Book(string Title, string Author, int Year) 
        { 
            this.Title = Title;
            this.Author = Author;
            this.YearPublished = Year;
        }

        public string Title { get; set; }
        public string Author { get; set; }
        public int YearPublished { get; set; }
    }
}
