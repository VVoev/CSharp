using System;
using System.Collections.Generic;
using System.Linq;

    class USerLogs
    {
        static void Main()
        {
        SortedDictionary<string, Dictionary<string, int>> UserLogs = new SortedDictionary<string, Dictionary<string, int>>();
            string input = Console.ReadLine();

        while (input!="end")
        {
            var comand = input.Split(new char[] { ' ', '=' }, StringSplitOptions.RemoveEmptyEntries);
            var user = comand[comand.Length - 1];
            var IP = comand[1];
            if(!UserLogs.ContainsKey(user))
            {
                UserLogs[user] = new Dictionary<string, int>();
                UserLogs[user].Add(IP, 0);
            }
            if(!UserLogs[user].ContainsKey(IP))
            {
                UserLogs[user].Add(IP, 0);
            }
            if(UserLogs[user].ContainsKey(IP))
            {
                UserLogs[user][IP]++;
            }

            input = Console.ReadLine();
        }
        foreach (var outerPair in UserLogs)
        {
            List<string> IPOccur = new List<string>();
            Console.WriteLine("{0}:", outerPair.Key);
            foreach (var innerPair in outerPair.Value)
            {
                string result = string.Format("{0} => {1}", innerPair.Key, innerPair.Value);
                IPOccur.Add(result);
            }
            Console.Write(string.Join(", ", IPOccur));
            Console.WriteLine(".");
        }

    }
    }