using System;
using System.Collections.Generic;
using System.Linq;
class RemoveAllNumbersWithOddOcurrence
{
    static void Main()
    {
        //2. Напишете програма, която премахва всички числа, които се срещат нечетен брой пъти в дадена редица.
        // { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6},
        List<int> numbers =new List<int> { 4, 2, 2, 5, 2, 3, 2, 3, 1, 5, 2, 6, 6, 6 };//Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        Dictionary<int, int> counts = new Dictionary<int, int>();
        foreach (var num in numbers)
        {
            if (counts.ContainsKey(num))
                counts[num]++;
            else
                counts[num] = 1;
        }
        List<int> novo = new List<int>();
        int counter = 1;
        foreach (var item in counts)
        {
            if (item.Value%2==0)
            {
                novo.Add(item.Key);
                while (item.Value>counter)
                {
                    novo.Add(item.Key);
                    counter++;
                }
                counter = 1;
            }
        }
        Console.WriteLine(string.Join(" ",novo));
    }
}
