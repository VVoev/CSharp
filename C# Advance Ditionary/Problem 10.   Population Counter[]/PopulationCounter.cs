using System;
using System.Collections.Generic;
using System.Linq;
public class PopulationCounter
{
    public static void Main()
    {
        string input = Console.ReadLine();
        Dictionary<string, Dictionary<string, long>> Population = new Dictionary<string, Dictionary<string, long>>();

        while (input!="report")
        {
            var information = input.Split('|').ToArray();
            var city = information[0];
            var country = information[1];
            long people = long.Parse(information[2]);

            if(!Population.ContainsKey(country))
            {
                Population[country] = new Dictionary<string, long>();
                Population[country].Add(city, people);
            }
            else if(Population.ContainsKey(country))
            {
                if(!Population[country].ContainsKey(city))
                {
                    Population[country].Add(city, people);
                }
            }
            input = Console.ReadLine();
        }

        var SortData = Population.OrderByDescending(x => x.Value.Sum(y => y.Value));
        foreach (var data in SortData)
        {
            long totalPopulation = data.Value.Sum(x => x.Value);
            Console.WriteLine(
                "{0} (total population: {1})",
                data.Key,
                totalPopulation);

            var orderedCityData = data.Value
                .OrderByDescending(x => x.Value);

            foreach (var cityInfo in orderedCityData)
            {
                Console.WriteLine("=>{0}: {1}", cityInfo.Key, cityInfo.Value);
            }
        }
    }
}
