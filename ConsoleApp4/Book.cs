using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Book
    {
        private string title;
        private string author;
        private int numPage;
        private string owner;
        private int numTimes;
        public Book(string Ptitle, string pauthor, int pNumpage, string powner)
        {
            title = Ptitle;
            author = pauthor;
            numPage = pNumpage;
            owner = powner;
            numTimes = 0;
        }

        public string Gettitle()
        {
            return title;
        }
        public string Gauthor()
        {
            return author;

        }
        public int Gpages()
        {
            return numPage;
        }
        public string Gowner
        {
            get
            {
                return owner;
            }
            set
            {
                owner = value;
            }

        }
        public int Gtimes
        {
            get
            {
                return numTimes;
            }
            set
            {
                numTimes = value;
            }
        }
        public void Print()
        {
            Console.WriteLine("Title : " + title);
            Console.WriteLine("Author : " + author);
            Console.WriteLine("Pages : " + numPage);
            Console.WriteLine(Gowner + " read this book  " + Gtimes + " times.");


        }
    }
}
