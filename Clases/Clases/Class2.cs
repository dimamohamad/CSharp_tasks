using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases
{
    public class Class2:Class1
    {
        
            public string author;
            public int realeseYear;
            public string bookName;
        Class1 obj=new Class1();
       

            public void bookstore()
            {
                Console.WriteLine($"the book name is: {bookName} written  by: {author}in {realeseYear} ");
            }
            



        
    }
}
