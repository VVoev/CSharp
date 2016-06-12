//using System;
//using System.Collections.Generic;
//using System.Linq;

//class Program
//{
//    static void Main()
//    {
//        var number = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
//        int sum = 0;
//        foreach (var num in number)
//        {
//            sum += num;
//        }
//        Dictionary<int, int> dublicateNumbers = new Dictionary<int, int>();
//        for (int i = 0; i < sum; i++)
//        {
//            int x = int.Parse(Console.ReadLine());
//            if (dublicateNumbers.ContainsKey(x))
//                dublicateNumbers[x]++;
//            else
//                dublicateNumbers[x] = 1;
//        }

//        var sorted = dublicateNumbers.Values.OrderBy(e => -e);
//        SortedDictionary<int,int> largest = sorted.Take(2);
//        Console.WriteLine(string.Join(" ", largest));


//        foreach (var item in dublicateNumbers)
//        {
//            Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
//        }

//    }
//}
    