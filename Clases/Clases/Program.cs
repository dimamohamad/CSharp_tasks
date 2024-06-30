using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 obj = new Class1();  
            obj.firsName = "Dima";
            obj.lastName = "ahmad";
            obj.age = 26;
            obj.fullName();
            Class1 obj1= new Class1();
            obj1.firsName = "ali";
            obj1.lastName = "mohammad";
            obj1.age = 27;
            obj1.fullName();

            Class2 book1 = new Class2();
            book1.bookName = "To Kill a Mockingbird";
           book1.author = "Harper Lee";
            book1.realeseYear = 1960;
            book1.bookstore();

            Class2 book2 = new Class2();
            book2.bookName = "Pride and Prejudice";
            book2.author = "Jane Austen";
            book2.realeseYear = 1813;
            book2.bookstore();
            Class2 book3 = new Class2();
            book3.bookName = "The Great Gatsby";
            book3.author = "Jane AustenF. Scott Fitzgerald";
            book3.realeseYear = 1925;
            book3.bookstore();
             
        }
    }
}
