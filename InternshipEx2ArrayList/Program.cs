using System;
using System.Collections;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipEx2ArrayList
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create the ArrayList
            ArrayList arrayList = new ArrayList();
            Display(arrayList);

            //Add elements
            arrayList.Add(new Student() { Name = "Tom", Mark = 9 });
            Display(arrayList);


            arrayList.Add(new Student() { Name = "Anna", Mark = 9 });
            arrayList.Add(new Student() { Name = "Andrei", Mark = 9 });
            arrayList.Add(new Student() { Name = "Dana", Mark = 10 });
            Display(arrayList);


            arrayList.Add(new Student() { Name = "Cristina", Mark = 10 });
            var daniel = new Student() { Name = "Daniel", Mark = 9 };
            arrayList.Add(daniel);
            Display(arrayList);

            //Remove elements
            arrayList.Remove(daniel);
            arrayList.RemoveAt(0);
            Display(arrayList);

            Console.ReadLine();
        }

        static void Display(ArrayList collection)
        {
            Console.WriteLine("#Count: {0}", collection.Count);
            Console.WriteLine("#Capacity: {0}", collection.Capacity);
            foreach (var el in collection)
            {
                var student = el as Student;
                Console.WriteLine("{0}: {1}", student.Name, student.Mark);
            }

            Console.WriteLine();
        }
    }

    class Student
    {
        public string Name { get; set; }
        public int Mark { get; set; }
    }
}
