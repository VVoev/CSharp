using System;
using System.Collections.Generic;
using System.Linq;
    class UniqueNames
    {
        static void Main()
        {
        List<string> names = Console.ReadLine().Split(' ').ToList();
        Dictionary<string, int> UniqueNames = new Dictionary<string, int>();
        foreach (var name in names)
        {
            if (UniqueNames.ContainsKey(name))
            {
                //
            }
            else
                UniqueNames.Add(name, 1);
        }
        foreach (var item in UniqueNames)
        {
            Console.WriteLine("{0}",item.Key);
        }
    }
    }