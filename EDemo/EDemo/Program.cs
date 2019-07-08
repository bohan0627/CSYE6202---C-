using System;
using System.Collections.Generic;

namespace EDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 5, 3, 10, 9 };
            numbers.Sort();
            //numbers.ForEach(n => Console.WriteLine(n));
            foreach (var n in numbers) {
                Console.WriteLine(n);
            }
            numbers.Sort((n1, n2) => (n2.CompareTo(n1)));
            Console.WriteLine(" ");
            foreach (var n in numbers)
            {
                Console.WriteLine(n);
            }
            Console.WriteLine("Hello World!");
        }
    }
}
