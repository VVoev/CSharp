using System;
using System.Collections.Generic;
using System.Linq;
class HandofCards
{
    static void Main()
    {
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        var input = Console.ReadLine();
        while (input != "JOKER")
        {
            var comand = input.Split(new char[] { ' ', ':', ',', }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string nameOfthePlayer = comand[0];

            for (int i = 1; i < comand.Length; i++)
            {
                if (!dictionary.ContainsKey(nameOfthePlayer))
                {
                    dictionary[nameOfthePlayer] = comand[i];
                }
                if (dictionary.ContainsKey(nameOfthePlayer))
                {
                    if (!dictionary[nameOfthePlayer].Contains(comand[i]))
                    {
                        dictionary[nameOfthePlayer] += comand[i];
                    }
                }
                else
                {

                }
            }
            input = Console.ReadLine();
        }
        List<string> points = new List<string>();
        List<string> Player = new List<string>();
        foreach (var item in dictionary)
        {
            string pointsPlayer= item.Value;
            for (int i = 0; i < pointsPlayer.Length; i++)
            {
                string card = "";
                card = pointsPlayer.Substring(0, 2);
            }

        }
    }
} 