using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        var comand = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        Dictionary<string, int> dictionary = new Dictionary<string, int>();

        while (comand[0] != "stop")
        {
            int number = int.Parse(Console.ReadLine());
            if (!dictionary.ContainsKey(comand[0]))
            {
                dictionary[comand[0]] = number;
            }
            else
            {
                dictionary[comand[0]] += number;
            }



             comand = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        foreach (var kvp in dictionary)
        {
            Console.WriteLine("{0} -> {1}", kvp.Key, kvp.Value);
        }
    }
}