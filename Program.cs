using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace day_5_assign7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an ArrayList
            ArrayList fruits = new ArrayList();

            // Add elements to the ArrayList
            fruits.Add("apple");
            fruits.Add("banana");
            fruits.Add("cherry");
            fruits.Add("date");
            fruits.Add("elderberry");

            // Print the total number of elements in the ArrayList
            Console.WriteLine("Total number of elements: " + fruits.Count);

            // Check if the ArrayList contains the element "date" and print the result
            bool containsDate = fruits.Contains("date");
            Console.WriteLine("ArrayList contains 'date': " + containsDate);

            // Insert an element at a specific position in the ArrayList
            Console.Write("Enter the element to insert: ");
            string insertElement = Console.ReadLine();

            Console.Write("Enter the position to insert (0 - " + fruits.Count + "): ");
            int insertPosition = int.Parse(Console.ReadLine());

            fruits.Insert(insertPosition, insertElement);

            Console.WriteLine("Elements after inserting in the ArrayList:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }

            // Remove an element from the ArrayList
            Console.Write("Enter the element to remove: ");
            string removeElement = Console.ReadLine();

            fruits.Remove(removeElement);

            // Print all the elements in the ArrayList using a loop
            Console.WriteLine("Elements in the ArrayList:");
            foreach (var fruit in fruits)
            {
                Console.WriteLine(fruit);
            }
            Console.ReadKey();
        }
    }
}
