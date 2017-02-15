using Nancy;
using System.Collections.Generic;
using System;
using System.IO;
using RoshamboApp;

namespace RoshamboApp
{
    public class HomeModule : NancyModule
    {
        public HomeModule()
        {
            Get["/"] = _ =>
            {
                return View["player_one.cshtml"];
            };

            Get["/player_two"] = _ =>
            {
                return View["player_two.cshtml"];
            };

            Get["/result"] = _ =>
            {
                return View["result.cshtml"];
            };

            Post["/player_two"] = _ =>
            {
                string playerOneChoice = Request.Form["result"];
                return View["player_two.cshtml", playerOneChoice];
            };

            Post["/result"] = _ =>
            {
                string playerTwoChoice = Request.Form["result"];
                string playerOneChoice = Request.Form["playerOne"];
                Roshambo newGame = new Roshambo(playerOneChoice, playerTwoChoice);
                // string resultDictionary = newGame.WinChecker();
                return View["result.cshtml", newGame];
            };


        }
    }
}
