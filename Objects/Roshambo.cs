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
            {"rock,rock", "no input wins"},
            {"rock,paper", "input 2 wins with paper"},
            {"rock,scissors", "input 1 wins with rock"},
            {"paper,rock", "input 1 wins with paper"},
            {"paper,paper", "no input wins"},
            {"paper,scissors", "input 2 wins with scissors"},
            {"scissors,rock", "input 2 wins with rock"},
            {"scissors,paper", "input 1 wins with scissors"},
            {"scissors,scissors", "no input wins"},
        };

        public Roshambo(string userOneInput, string userTwoInput)
        {
            _userOneInput = userOneInput;
            _userTwoInput = userTwoInput;
        }

        public void SetInput(string userOneInput, string userTwoInput)
        {
            _userOneInput = userOneInput;
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
            string turn = GetUserOneInput() + "," + GetUserTwoInput();
            string result = "";

            foreach(KeyValuePair<string, string> outcome in outcomes)
            {
                if (turn == outcome.Key)
                {
                    result = outcome.Value;
                }
            }

            return result;
        }
    }
}
