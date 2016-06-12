using System;
using System.Collections.Generic;
using System.Linq;
    public class LogAgg
    {
    public static void Main()
    {

        int n = int.Parse(Console.ReadLine());
        string IP = string.Empty;
        string User = string.Empty;
        long duration = 0;
        SortedDictionary<string, Dictionary<string, long>> InfoLogs = new SortedDictionary<string, Dictionary<string, long>>();
        //Inserting data in dictionary
        for (int i = 0; i < n; i++)
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            IP = input[0];
            User = input[1];
            duration = long.Parse(input[2]);
            if (!InfoLogs.ContainsKey(User))
            {
                InfoLogs[User] = new Dictionary<string, long>();
                InfoLogs[User].Add(IP, duration);
            }
            else if (InfoLogs.ContainsKey(User))
            {
                if (InfoLogs[User].ContainsKey(IP))
                {
                    InfoLogs[User][IP] += duration;
                }
                else
                {
                    InfoLogs[User].Add(IP, duration);
                }
            }
        }
        // sorting data in dictionary
        foreach (var outerPair in InfoLogs)
        {
            long sum = 0;
            List<string> result = new List<string>();

            foreach (var innerPair in outerPair.Value)
            {   
                 sum+= innerPair.Value;
                result.Add(innerPair.Key);
            }
            result.Sort();
            Console.WriteLine("{0}: {1} [{2}]",outerPair.Key,sum,string.Join(", ",result));
            //Console.Write("{0}:", outerPair.Key);
            //Console.Write(string.Join(", ", IPOccur));
            //Console.WriteLine(".");
        }
    }
    }