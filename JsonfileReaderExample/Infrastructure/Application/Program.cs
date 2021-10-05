using JsonfileReaderExample.Core.Interfaces;
using System;
using System.Diagnostics;
using System.IO;

namespace JsonReaderExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch sw = Stopwatch.StartNew();

            //IRepository<Employee> repo = new EmployeeJsonRepository(new StreamReader("../../../Data/Employees.json"));
            IRepository<MovieRating> repo = new MovieRatingJsonRepository(new StreamReader("../../../Data/ratings.json"));

            sw.Stop();
            Console.WriteLine("Time = {0:f4} seconds", sw.ElapsedMilliseconds /1000d);

            Console.WriteLine($"\nTotal items: {repo.Items.Length:N0}");

            //Console.WriteLine("\nAll items: ");
            //foreach(Employee e in repo.Items)
            //{
            //    Console.WriteLine(e);
            //}

            Console.WriteLine("\nFirst 3 ratings:");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(repo.Items[i].ToString());
            }

            Console.WriteLine("\nLast 3 ratings:");
            for (int i = repo.Items.Length - 3; i < repo.Items.Length; i++)
            {
                Console.WriteLine(repo.Items[i].ToString());
            }
        
    }
} 
}
