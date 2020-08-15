using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipEx1Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            var array = new Person[3];
            array[0] = new Person() { Id = 10, Name = "Tatiana" };
            array[1] = new Person() { Id = 21, Name = "Anna" };
            array[2] = new Person() { Id = 33, Name = "Diana" };

            var array2 = new Person[] {
                new Person() { Id = 4, Name = "Andrei"},
                new Person() { Id = 23, Name = "Daniel"}
            };

            Display(array);
            Display(array2);

            Console.ReadLine();
        }

        static void Display(Person[] persons)
        {
            foreach (var person in persons)
            {
                Console.WriteLine("{0}:{1}", person.Id, person.Name);
            }

            Console.WriteLine();
        }
    }

    class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
