using InternshipCollection2.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipCollection2
{
    class Program
    {
        static void Main(string[] args)
        {
            var bookLibrary = new BookLibrary();

            foreach (var book in bookLibrary)
            {
                Console.WriteLine(book);
            }

            Console.ReadLine();
        }
    }
}
