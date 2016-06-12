using System;
using System.Collections.Generic;
using System.Linq;
class Championsleague
{
    static void Main()
    {
        string comand = Console.ReadLine(); 
        Dictionary<string, int> winStatistics = new Dictionary<string, int>();
        Dictionary<string, int> oponentStatistics = new Dictionary<string, int>();
        while (comand != "stop")
        {
            string result = string.Empty;
            string[] input = comand.Split('|').ToArray();
            string homeTeam = input[0];
            string awayTeam = input[1];
            string goals = input[2];
            string goals2ndmatch = input[3];
            int firstTeamHomeGoals = goals[1] - '0';
            int secondTeamAwayGoals = goals[3] - '0';
            int SecondTeamHomeGoals = goals2ndmatch[1] - '0';
            int FirstTeamAwayGoals = goals2ndmatch[3] - '0';
            int TotalGoalsFirstTeam = firstTeamHomeGoals + FirstTeamAwayGoals;
            int TotalGoalsSecondTeam = secondTeamAwayGoals + SecondTeamHomeGoals;
            if (TotalGoalsFirstTeam == TotalGoalsSecondTeam)
            {
                result = FirstTeamAwayGoals > secondTeamAwayGoals ? "firstteam" : "secondteam";
                if (!winStatistics.ContainsKey(homeTeam) && result=="firstteam")
                {
                    winStatistics[homeTeam] = 1;
                }
                if (!winStatistics.ContainsKey(awayTeam) && result == "secondteam")
                {
                    winStatistics[awayTeam] = 1;
                }
                if(result=="firsteam" && winStatistics.ContainsKey(homeTeam))
                {
                    winStatistics[homeTeam]++;
                }
                if (winStatistics.ContainsKey(awayTeam) && result == "secondteam")
                {
                    winStatistics[awayTeam]++; ;
                }
            }
            else
            {
                result = TotalGoalsFirstTeam > TotalGoalsSecondTeam ? "firstteam" : "secondteam";
            }











            comand = Console.ReadLine();
        }
    }
}
    

