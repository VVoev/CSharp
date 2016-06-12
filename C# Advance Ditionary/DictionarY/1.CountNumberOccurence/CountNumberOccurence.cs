using System;
using System.Collections.Generic;
using System.Linq;
class CountNumberOccurence
{
    static void Main()
    {
        // 1.Напишете програма, която брои колко пъти се среща всяко число в дадена редица от числа.
        List<int> numbers = Console.ReadLine().Split(' ').Select(int.Parse).ToList();     //int[] numbers = { 3, 4, 4, 2, 3, 3, 4, 3, 2 };
        SortedDictionary<int,int> numbercount = new  SortedDictionary<int, int>();
        foreach (var num in numbers)
        {
            if (numbercount.ContainsKey(num))
                numbercount[num]++;
            else
                numbercount[num] = 1;
        }
        foreach (var item in numbercount)
        {
            Console.WriteLine("{0} -> {1} times", item.Key, item.Value);
        }
    }
}