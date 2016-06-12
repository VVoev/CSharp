using System;
using System.Collections.Generic;
using System.Linq;
    class Program
    {
        static void Main()
        {
        string comand = Console.ReadLine();
        Dictionary<string, string> phoneBook = new Dictionary<string, string>();
        while(comand!="search")
        {
            var input = comand.Split('-');



            if(!phoneBook.ContainsKey(input[0]))
            {
                phoneBook.Add(input[0], input[1]);
            }
            if(phoneBook.ContainsKey(input[0]))
            {
                phoneBook[input[0]] = input[1];
            }


            comand = Console.ReadLine();

        }
        comand = Console.ReadLine();
        while (comand!="stop")
        {
            if(phoneBook.ContainsKey(comand))
            {
                Console.WriteLine("{0} -> {1}", comand, phoneBook[comand]);
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", comand);
            }
            comand = Console.ReadLine();
        }
    }
    }