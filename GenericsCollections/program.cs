using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GenericsCollections;

namespace GenericsCollections
{
    class Programm
    {
        static void Main(string[] args)
        {
            

            Console.ForegroundColor = ConsoleColor.Cyan;

            Console.WriteLine("\t Instantiation of an instance collections using the generic LIST<T> class");
            Console.WriteLine("\n\t-Iterating through the list");
            Console.WriteLine("\n  ");

            List<int> numbers = new List<int>();

            foreach (int number in new int[5] { 50, 12, 56, 10, 85 })
            {
                numbers.Add(number);
            }

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine("\n\t............................................................................... ");
            Console.WriteLine("\tInstantiation of an instance collection class using LinkedList<T> class");

            LinkedList<string> names = new LinkedList<string>();
            foreach (string name in new string[] { "michel", "ngako", "emou", "mssa", "Microsoft" })
            {
                names.AddLast(name);

            }
            Console.WriteLine("\n\t-Iterating through the LinkedList");

            for (LinkedListNode<string> node = names.First; node != null; node = node.Next)
            {
                string name = node.Value;
                Console.WriteLine(name);
            }


            Console.WriteLine("\n\t................................................................................ ");
            Console.WriteLine("\t Instantiation of an instance collection class using Queue<T> class");

            Queue<int> nums = new Queue<int>();
            Console.WriteLine("Generate the queue: ");

            foreach (int num in new int[5] { 56, 25, 32, 67, 15 })
            {
                nums.Enqueue(num);
                Console.WriteLine($"{num} is now part of the queue");
            }
            Console.WriteLine("\n\t-Iterating through the Queue");
            Console.WriteLine("\nThe queue contains these elements: ");

            foreach (int num in nums)
            {
                Console.WriteLine(num);
            }

            Console.WriteLine("\n\t................................................................................ ");
            Console.WriteLine("\t Instantiation of an instance collection class using Stack<T> class");

            Stack<string> cars = new Stack<string>();
            Console.WriteLine("\nPushing items onto the stack:");

            foreach (string car in new string[5] { "Bugatti Chiron", "Masserati", "Renault", "Mazda", "Jaguar" })
            {
                cars.Push(car);
                Console.WriteLine($"\n{car} has been pushed on the stack");
            }

            Console.WriteLine("\n\t-Iterating through the stack");

            Console.WriteLine("\n\tThe stack contains: ");
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
            Console.WriteLine("\n\t-Iterating through the Queue");

            Console.WriteLine("\n\t................................................................................ ");
            Console.WriteLine("\t Instantiation of an instance collection class using Dictionary<TKey, TValue> class");

            Dictionary<string, int> ages = new Dictionary<string, int>();
            ages.Add("aicha", 87);
            ages.Add("polo", 5);
            ages.Add("antoine", 45);
            ages.Add("gaston", 11);
            ages.Add("steph", 35);

            Console.WriteLine("\n\t-Iterating through the Dictionary");
            foreach (KeyValuePair<string, int> element in ages)
            {
                string name = element.Key;
                int age = element.Value;
                Console.WriteLine($"Name: {name}, Age: {age}");
            }



            Console.WriteLine("\n\t................................................................................ ");
            Console.WriteLine("\t Instantiation of an instance collection class using SortedList<Tkey, TValue>");


            SortedList<string, int> sizes = new SortedList<string, int>();
            sizes["joseph"] = 25;
            sizes["grace"] = 12;
            sizes["Edouardo"] = 11;
            sizes["Felix"] = 13;
            sizes["gaby"] = 10;


            Console.WriteLine("\n\t-Iterating through the SortedList");

            foreach (KeyValuePair<string, int> element in sizes)

            {
                string name = element.Key;
                int size = element.Value;
                Console.WriteLine($"Name : {name}, Size: {size}");
            }


            Console.WriteLine("\n\t................................................................................ ");
            Console.WriteLine("\t Instantiation of an instance collection class using HashSet<T>");

            HashSet<string> Countries = new HashSet<string>(new string[] { "Cameroon", "Morrocco", "Lybia", "Tunisia", "Niger" });

            Console.WriteLine("\n\t-Iterating through the Hashset<T>");
            Console.WriteLine("\nCountries are:  ");

            foreach (string Country in Countries)
            {
                Console.WriteLine(Country);
            }

        }
    }
}
