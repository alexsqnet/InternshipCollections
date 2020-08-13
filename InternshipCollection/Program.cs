using InternshipCollection.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipCollection
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookLibrary = new BookLibrary();

            while (bookLibrary.MoveNext())
            {
                Console.WriteLine(bookLibrary.Current);
            }

            Console.ReadLine();
        }
    }

}
