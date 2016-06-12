using System;
using System.Collections.Generic;
using System.Linq;

    class Program
    {
        static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        HashSet<string> alfa = new HashSet<string>();
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split().ToArray();
            for (int x = 0; x < input.Length; x++)
            {
                alfa.Add(input[x]);

            }
        }
        Console.WriteLine(string.Join(" ",alfa));
        }
    }