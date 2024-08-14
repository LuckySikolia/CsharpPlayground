using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Book
    {
        public string title;
        public string author;
        public int pages;

        //the constructor of the class
        public Book(string aTitle, string aAuthor, int aPages)
        {
            title = aTitle;
            author = aAuthor;
            pages = aPages;
        }

        public Book()
        {

        }
    }
}
