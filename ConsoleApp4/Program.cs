using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {//creat a new book class
            Book book1;
            book1 = new Book("SSD", "Keith", 255, "Kate");
            // creat a new string
            string choice = "";
            //make a loop
            while (choice != "done")
            {
                Console.WriteLine("Type one of the following to access your book: ");
                Console.WriteLine("title. author. page. borrow. read. print. done.");
                choice = Console.ReadLine();
                // print title to show the data
                if (choice == "title")
                {
                    Console.WriteLine("Title: " + book1.Gettitle());
                }
                //print author
                if (choice == "author")
                {
                    Console.WriteLine(book1.Gauthor());
                }
                //print the pages
                if (choice == "page")
                {
                    Console.WriteLine(book1.Gpages());
                }
                //print the old owner and replace newowner
                if (choice == "borrow")
                {
                    Console.WriteLine(book1.Gowner);
                    Console.WriteLine("who is the new borrower?");
                    string newowner;
                    newowner = Console.ReadLine();
                    book1.Gowner = newowner;
                }
                //print
                if (choice == "print")
                {
                    book1.Print();
                }

                // if you read the read time +1
                if (choice == "read")
                {
                    Console.WriteLine("you read this book...");
                    book1.Gtimes++;
                }
                // break the loop
                if (choice == "done")
                {
                    Console.WriteLine("byebye");
                    break;
                }
                //invalid input
                if (choice != "title" && choice != "author" && choice != "page" && choice != "borrow" && choice != "read" && choice != "done" && choice != "print")
                {
                    Console.WriteLine("invalid");
                }
            }
        }
    }
}
