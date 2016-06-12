using System;
using System.Collections.Generic;
using System.Linq;

   public class Program
    {
       public static void Main()
        {
        int n = int.Parse(Console.ReadLine());
        string comand = "";

        HashSet<string> result = new HashSet<string>();

        for (int i = 0; i < n; i++)
        {
            comand = Console.ReadLine();
            result.Add(comand);
        }
        foreach (var item in result)
        {
            Console.WriteLine(item);
        }
        }
    }