using System;
using System.Collections.Generic;
using System.Linq;

class NumbersOfWordInText
{
    static void Main()
    {
        string input = Console.ReadLine().ToLower();
        SortedDictionary<string, int> counts = new SortedDictionary<string, int>();
        List<string> clearInput = input.Split(new char[] { ' ', ',', '-', '.', ':', ';', '?', '!' }).ToList();
        foreach (var item in clearInput)
        {
            if(counts.ContainsKey(item))
                counts[item]++;
            else
                counts[item] = 1;
        }
        var SortWords = counts.OrderBy(sort => sort.Value);//Here the dictionary is getting sorted
        foreach (var item in SortWords)// if you use couts it will give you unsorted result
        {
            if (item.Key!="")
            Console.WriteLine("{0}--->{1}", item.Key, item.Value);
        }

    }
}