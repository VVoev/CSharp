using System;
using System.Collections.Generic;
using System.Linq;
public class DragonPower
{
    public static void Main()
    {
        Dictionary<string, SortedDictionary<string, SortedDictionary<double, SortedDictionary<double, double>>>> dragons = new Dictionary<string, SortedDictionary<string, SortedDictionary<double, SortedDictionary<double, double>>>>();
        var colorDragon = "";
        var typeDragon = "";
        double damageDragon = 0;
        double healthDragon = 0;
        double armorDragon = 0;
        int n = int.Parse(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine();
            //input = input.Replace("null", "0");
            var comand = input.Split().ToArray();
            damageDragon = 45;
            healthDragon = 250;
            armorDragon = 10;
            colorDragon = comand[0];
            typeDragon = comand[1];
            if (comand[2] != "null")
            {
                damageDragon = double.Parse(comand[2]);
            }
            if (comand[3] != "null")
            {
                healthDragon = double.Parse(comand[3]);
            }
            if (comand[4] != "null")
            {
                armorDragon = double.Parse(comand[4]);
            }

            if (!dragons.ContainsKey(colorDragon))
            {
                dragons[colorDragon] = new SortedDictionary<string, SortedDictionary<double, SortedDictionary<double, double>>>();
            }
            if (!dragons[colorDragon].ContainsKey(typeDragon))
            {
                dragons[colorDragon][typeDragon] = new SortedDictionary<double, SortedDictionary<double, double>>();
            }
            if (!dragons[colorDragon][typeDragon].ContainsKey(damageDragon))
            {
                dragons[colorDragon][typeDragon][damageDragon] = new SortedDictionary<double, double>();
                dragons[colorDragon][typeDragon][damageDragon].Add(healthDragon, armorDragon);
            }
        }

        foreach (var drakon in dragons)
        {
            double dmg = 0;
            double health = 0;
            double armor = 0;
            var x = dragons[colorDragon][typeDragon][damageDragon].Keys;
            foreach (var color in dragons[drakon.Key])
            {
                foreach (var type in dragons[drakon.Key][color.Key])
                {
                    dmg += type.Key;
                    foreach (var damage in dragons[drakon.Key][color.Key][type.Key])
                    {
                        health += damage.Key;
                        armor += damage.Value;
                    }
                }
            }
            Console.WriteLine("{0}::({1:F2}/{2:F2}/{3:F2})", drakon.Key, dmg / drakon.Value.Count, health / drakon.Value.Count, armor / drakon.Value.Count);
            foreach (var color in dragons[drakon.Key])
            {
                Console.Write("-{0} -> ", color.Key);
                foreach (var type in dragons[drakon.Key][color.Key])
                {
                    Console.Write("damage: {0}, ", type.Key);
                    foreach (var damage in dragons[drakon.Key][color.Key][type.Key])
                    {
                        Console.Write("health: {0}, armor: {1}", damage.Key, damage.Value);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}