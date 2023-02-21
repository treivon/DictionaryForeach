using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
          Dictionary<int, string> schools = new Dictionary<int, string>();


            schools.Add(1, "Tallinna südalinna kool");
            schools.Add(2, "Gustav Adolfi gümnaasium");
            schools.Add(3, "Tallinna reaalkool");
     

            foreach (KeyValuePair<int, string> school in schools)
            {
                Console.WriteLine("Kool #" + school.Key + ": " + school.Value);
            }
        }
    }
}

