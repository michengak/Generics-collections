using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstWeekAssignment
{
    class RefactorCollection
    {
        static void Main(string[] args)
        {
            SortedList<string, int> animals = new SortedList<string, int>();
            animals.Add("Dogs", 42);
            animals.Add("Cats", 20);
            animals.Add("Mouses", 11);
            animals.Add("Lions", 5);
            animals.Add("Tigers", 8);

            foreach (KeyValuePair<string, int> element in animals)
            {
                string name = element.Key;
                int animal = element.Value;

                Console.WriteLine($"Name: {name}, Animal: {animal}");

            }

        }

    }
}