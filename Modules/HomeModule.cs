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
        Game.gameInstances.Clear();
        Game newGame = new Game("", "");
        return View["index.cshtml"];
      };
      Post["/choice1"] = _ =>
      {
        Game currentGame = Game.gameInstances[0];
        currentGame.setChoice1(Request.Form["player1"]);
        System.Console.WriteLine("Player 1 choice: " + currentGame.getChoice1());
        return View["index.cshtml"];
      };
      Post["/choice2"] = _ =>
      {
        Game currentGame = Game.gameInstances[0];
        currentGame.setChoice2(Request.Form["player2"]);
        System.Console.WriteLine("Player 2 choice: " + currentGame.getChoice2());
        return View["index.cshtml"];
      };
      Get["/outcome"] = _ =>
      {
        Game currentGame = Game.gameInstances[0];
        string result = currentGame.DetermineWinner();
        return View["index.cshtml", result];
      };
      Post["/reset"] = _ =>
      {
        Game.gameInstances.Clear();
        Game newGame = new Game("", "");
        return View["index.cshtml"];
      };
    }
  }
}
