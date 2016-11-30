using Nancy;
using System.Collections.Generic;
using RockPaperScissors.Objects;
using System;

namespace CoinProgram
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>
      {
        Game newGame = new Game("", "");
        return View["index.cshtml"];
      };
      Post["/choice1"] = _ =>
      {
        Game currentGame = Game.gameInstances[0];
        string playerChoice = Request.Form["player1"];
        System.Console.WriteLine(playerChoice);
        return View["index.cshtml"];
      };
    }
  }
}
