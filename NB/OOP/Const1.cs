using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace NB.OOP
{
    internal class Const1
    {
        class Book
        {
            int bookid;
            string booktitle;
            string bookauthor;
            double bookprice;
            public Book()
            {
                Console.WriteLine("Enter the BookId. :");
                bookid = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Enter the Book Title: ");
                booktitle = Convert.ToString(Console.ReadLine());
                
                Console.WriteLine("Enter the Book Author: ");
                bookauthor=Convert.ToString(Console.ReadLine());

                Console.WriteLine("Enter Book price : ");
                bookprice = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine();

                Console.WriteLine("BookId : " + bookid);
                Console.WriteLine("Book Title : " + booktitle);
                Console.WriteLine("Book Author : " + bookauthor);
                Console.WriteLine("Book Price : " + bookprice);

                Console.WriteLine();
            }
        }
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Book Details: ");
            int[] obj = new int[5];
            for(int i = 0; i < obj.Length; i++)
            {
                Book b = new Book();
                obj[i] = i;
            }
        }
    }
}
