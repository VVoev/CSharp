using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
        var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
        HashSet<int> firstElement = new HashSet<int>();
        HashSet<int> secondElement = new HashSet<int>();
        int numberOne = input[0];
        int numerTwo = input[1];
        for (int i = 0; i < numberOne; i++)
        {
            int x = int.Parse(Console.ReadLine());
            firstElement.Add(x);
        }
        for (int i = 0; i < numerTwo; i++)
        {
            int x = int.Parse(Console.ReadLine());
            secondElement.Add(x);
        }
        var mui=(firstElement.Intersect(secondElement));
        Console.WriteLine(string.Join(" ",mui));

    }
}