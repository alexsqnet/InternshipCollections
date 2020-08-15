using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InternshipEx4SortedList
{
    class Program
    {
        public static void Main()
        {
            // Creates and initializes a new SortedList.
            SortedList mySL = new SortedList();
            mySL.Add("Third", "!");
            mySL.Add("Second", "World");
            mySL.Add("First", "Hello");

            // Displays the properties and values of the SortedList.
            Console.WriteLine("mySL");
            Console.WriteLine("  Count:    {0}", mySL.Count);
            Console.WriteLine("  Capacity: {0}", mySL.Capacity);
            Console.WriteLine("  Keys and Values:");
            PrintKeysAndValues(mySL);

            Console.ReadLine();
        }

        public static void PrintKeysAndValues(SortedList myList)
        {
            Console.WriteLine("\t-KEY-\t-VALUE-");
            for (int i = 0; i < myList.Count; i++)
            {
                Console.WriteLine("\t{0}:\t{1}", myList.GetKey(i), myList.GetByIndex(i));
            }
            Console.WriteLine();
        }
    }
}
