using System.Collections.Generic;
using System;

namespace RoshamboApp
{
    public class Roshambo
    {
        private string _userOneInput;
        private string _userTwoInput;
        public static Dictionary<string, string> outcomes = new Dictionary<string, string>()
        {
            {"rock,rock", "tie with rock"},
            {"rock,paper", "input 2 wins with paper"},
            {"rock,scissors", "input 1 wins with rock"},
            {"paper,rock", "input 1 wins with paper"},
            {"paper,paper", "tie with paper"},
            {"paper,scissors", "input 2 wins with scissors"},
            {"scissors,rock", "input 2 wins with rock"},
            {"scissors,paper", "input 1 wins with scissors"},
            {"scissors,scissors", "tie with scissors"},
        };

        public Roshambo(string userOneInput, string userTwoInput)
        {
            _userOneInput = userOneInput;
            _userTwoInput = userTwoInput;
        }

        public void SetInput2(string userTwoInput)
        {
            _userTwoInput = userTwoInput;
        }

        public string GetUserOneInput()
        {
            return _userOneInput;
        }

        public string GetUserTwoInput()
        {
            return _userTwoInput;
        }

        public string WinChecker()
        {
            string turn;
            string result ="";

            if (GetUserTwoInput() == "cpu")
            {
                string cpuInput;

                Random cpuPlay = new Random();
                int cpuPlayTurn = cpuPlay.Next(1,4);

                if (cpuPlayTurn == 1)
                {
                    cpuInput = "rock";
                }
                else if (cpuPlayTurn == 2)
                {
                    cpuInput = "paper";
                }
                else
                {
                    cpuInput = "scissors";
                }

                turn = GetUserOneInput() + "," + cpuInput;
            }
            else
            {
                turn = GetUserOneInput() + "," + GetUserTwoInput();
            }

            foreach(KeyValuePair<string, string> outcome in outcomes)
            {
                if (turn == outcome.Key)
                {
                    Console.WriteLine("in the if statement");
                    result = outcome.Value;
                }
            }
            Console.WriteLine(result);
            return result;
        }
    }
}
