using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipCollection2.Classes
{
    public class BookLibrary : IEnumerator, IEnumerable
    {
        Book[] books;

        public BookLibrary()
        {
            books = new Book[7];
            InitializeBooks();
        }

        int position = -1;

        public object Current => books[position];

        public bool MoveNext()
        {
            if (position < books.Length - 1)
            {
                position++;
                return true;
            }

            Reset();
            return false;
        }

        public void Reset()
        {
            position = -1;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this as IEnumerator;
        }

        private void InitializeBooks()
        {
            books[0] = new Book() { Title = "C# 6.0 in a Nutshell", Author = "Joseph Albahari" };
            books[1] = new Book() { Title = "Head First C#", Author = "Jennifer Greene" };
            books[2] = new Book() { Title = "C# in Depth", Author = "Jon Skeet" };
            books[3] = new Book() { Title = "C# 5.0 Unleashed", Author = "Bart De Smet" };
            books[4] = new Book() { Title = "The C# Player’s Guide", Author = "RB Whitaker" };
            books[5] = new Book() { Title = "C# Programming Yellow Book", Author = "Rob Miles" };
            books[6] = new Book() { Title = ".NET Book Zero", Author = "Charles Petzold" };

        }

    }
}
