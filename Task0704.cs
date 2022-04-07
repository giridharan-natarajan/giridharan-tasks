using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;


namespace LYNK
{
    class Task0704
    {
        public static void Main()
        {

            IList<book> bookData = new List<book>()
            {
                new book() { Bookprice = 100, BookName = "Room on the roof", Author = "Aa"},
                new book() { Bookprice = 200, BookName = "Davinci code", Author = "Bb"},
                new book() { Bookprice = 300, BookName = "Think like a monk", Author = "Cc"},
                new book() { Bookprice = 400, BookName = "Alchemist", Author = "Dd"}
            };


            //all data display
            //var myqry = from list in bookData
            //             select list;
            //foreach (var Det in myqry)
            //    Console.WriteLine("{0} {1} {2}", Det.Bookprice, Det.BookName, Det.Author);

            //particular authors
           // Console.WriteLine("Enter the author name");
           //string v = Console.ReadLine(); ;
           // var qry = from books in bookData
           //      select books;
           // foreach (var d in qry)
           //    if (v==d.Author)
           //     {
           //         Console.WriteLine(d.BookName);
           //     }

             //sorted by price
            //var qry = from books in bookData
            //        orderby books.Bookprice
            //       select books;
            //foreach (var names in qry)
            //    Console.WriteLine(names.Bookprice + " " + names.BookName);

            ////books by ascending order by author name
            //var qry = from books in bookData
            //         orderby books.Author
            //         select books;
            //foreach (var names in qry)
            // Console.WriteLine(names.Author+ " "+ names.BookName);


        }
        class book
        {

            public int Bookprice { get; set; }
            public string BookName { get; set; }
            public String Author { get; set; }
        }

    }
}
    

