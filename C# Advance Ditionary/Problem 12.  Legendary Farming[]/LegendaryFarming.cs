using System;
using System.Collections.Generic;
using System.Linq;
public class LegendaryFarming
{
    public static void Main()
    {
        int shards = 0;
        int fragments = 0;
        int motes = 0;
        string input = Console.ReadLine().ToLower();
        SortedDictionary<string, int> Legendary = new SortedDictionary<string, int>();
        SortedDictionary<string, int> Junk = new SortedDictionary<string, int>();
        Legendary["shards"] = 0;
        Legendary["fragments"] = 0;
        Legendary["motes"] = 0;
        bool foundWiiner = false;
        while (input != "")
        {
            var comand = input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToList();
            for (int i = 0; i < comand.Count; i++)
            {
                if (comand[i] == "shards" && !foundWiiner)
                {
                    int index = i - 1;
                    shards = int.Parse(comand[index]);
                    Legendary[comand[i]] += shards;
                    foundWiiner = CheckForWinner(shards, fragments, motes, Legendary);
                }
                else if (comand[i] == "fragments" && !foundWiiner)
                {
                    int index = i - 1;
                    fragments = int.Parse(comand[index]);
                    Legendary[comand[i]] += fragments;
                    foundWiiner = CheckForWinner(shards, fragments, motes, Legendary);

                }
                else if (comand[i] == "motes" && !foundWiiner)
                {
                    int index = i - 1;
                    motes = int.Parse(comand[index]);
                    Legendary[comand[i]] += motes;
                    foundWiiner = CheckForWinner(shards, fragments, motes, Legendary);
                }
                else if (comand[i].Contains("a") || comand[i].Contains("e") || comand[i].Contains("i") || comand[i].Contains("o") || comand[i].Contains("y"))
                {
                    if (!foundWiiner)
                    {
                        int index = i - 1;
                        int junkResource = int.Parse(comand[index]);

                        if (!Junk.ContainsKey(comand[i]))
                        {
                            Junk[comand[i]] = junkResource;
                        }
                        else
                        {
                            Junk[comand[i]] += junkResource;
                        }
                    }

                }
                if (foundWiiner)
                {
                    var sorted = Legendary.OrderBy(x => -x.Value);

                    foreach (var item in sorted)
                    {
                        Console.WriteLine("{0}: {1}", item.Key, item.Value);
                    }
                    foreach (var item in Junk)
                    {
                        Console.WriteLine("{0}: {1}", item.Key, item.Value);
                    }
                    return;
                }
            }
            if (!foundWiiner)
            {
                input = Console.ReadLine().ToLower();
            }
            else
            {
                return;
            }

        }
    }

    private static bool CheckForWinner(int shards, int fragments, int motes, SortedDictionary<string, int> Legendary)
    {
        if (Legendary["shards"] >= 250)
        {

            Console.WriteLine("Shadowmourne obtained!");
            Legendary["shards"] -= 250;
            return true;
        }
        if (Legendary["fragments"] >= 250)
        {
            Console.WriteLine("Valanyr obtained!");
            Legendary["fragments"] -= 250;
            return true;

        }
        if (Legendary["motes"] >= 250)
        {
            Console.WriteLine("Dragonwrath obtained!");
            Legendary["motes"] -= 250;
            return true;
        }
        return false;
    }
}