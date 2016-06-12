using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Сръбско_Unleashed
    {
      public  static void Main()
        {
        Dictionary<string, Dictionary<string, long>> serbianPopStars = new Dictionary<string, Dictionary<string, long>>();
        int index = 0;
        int endIndex = 0;
        string input = Console.ReadLine();

        while (input!="End")
        {
            var comand = input.Split(new char[] { '@' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            long startIndex = comand.IndexOf("@");
            var comand1 = comand[1].Split().ToArray();
            for (int i = 0; i < input.Length; i++)
            {
                if(input[i]=='@')
                {
                    index = i+1;
                }
                if(char.IsDigit(input[i]))
                {
                    endIndex = i;
                    break;
                }
            }
            if (comand1.Length> 2)
            {
                long sum1 = long.Parse(comand1[comand1.Length - 1]);
                long sum2 = long.Parse(comand1[comand1.Length - 2]);

                var singer = comand[0].TrimEnd();
                var town = input.Substring(index, Math.Abs(index - endIndex));
                var totalSum = sum1 * sum2;

                if (!serbianPopStars.ContainsKey(town))
                {
                    serbianPopStars[town] = new Dictionary<string, long>();
                }
                if (!serbianPopStars[town].ContainsKey(singer))
                {
                    serbianPopStars[town][singer] = 0;
                }
                if (serbianPopStars[town].ContainsKey(singer))
                {
                    serbianPopStars[town][singer] += totalSum;
                }
            }


            input = Console.ReadLine();
        }
        foreach (var star in serbianPopStars)
        {
            Console.WriteLine("{0}",star.Key);
            foreach (var item in serbianPopStars[star.Key].OrderByDescending(x => x.Value)) 
            {
                Console.WriteLine("#  {0} -> {1}", item.Key, item.Value);
            }
        }
        }
    }