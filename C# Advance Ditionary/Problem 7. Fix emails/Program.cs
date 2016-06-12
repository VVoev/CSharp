using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
    class Program
    {
        static void Main(string[] args)
        {
        string comand = Console.ReadLine();
        Dictionary<string, string> dictionary = new Dictionary<string, string>();
        while (comand!="stop")
        {
            string email = Console.ReadLine();
            string sub = email.Substring(email.Length - 2);
            if(sub!="uk" && sub!="us")
            {
                dictionary[comand] = email;
            }
            else
            {

            }
            comand = Console.ReadLine();
        }

        foreach (var kvp in dictionary)
        {
            Console.WriteLine($"{kvp.Key} -> {kvp.Value}");
        }
        }
    }