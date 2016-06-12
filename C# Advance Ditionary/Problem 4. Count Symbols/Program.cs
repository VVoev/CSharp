using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem_4.Count_Symbols
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            SortedDictionary<char, int> dictionary = new SortedDictionary<char, int>();
            for (int i = 0; i < input.Length; i++)
            {
                if (!dictionary.ContainsKey(input[i]))
                {
                    dictionary[input[i]] = 1;
                }
                else
                {
                    dictionary[input[i]]++;
                }
            }
            foreach (var kvp in dictionary)
            {
                Console.WriteLine("{0}: {1} time/s", kvp.Key, kvp.Value);
            }
        }
    }
}
