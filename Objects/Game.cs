using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    private string _player1Choice;
    private string _player2Choice;
    public static List<Game> gameInstances = new List<Game>{};

    public Game(string player1Choice, string player2Choice)
    {
      _player1Choice = player1Choice;
      _player2Choice = player2Choice;
      gameInstances.Add(this);
    }

    public string getChoice1()
    {
      return _player1Choice;
    }

    public void setChoice1(string choice)
    {
      _player1Choice = choice;
    }

    public string getChoice2()
    {
      return _player2Choice;
    }

    public void setChoice2(string choice)
    {
      _player2Choice = choice;
    }

    public string DetermineWinner()
    {
      if((_player1Choice == "rock" && _player2Choice == "scissors") || (_player2Choice == "rock" && _player1Choice == "scissors"))
      {
        return "Rock wins!";
      }
      else if ((_player1Choice == "paper" && _player2Choice == "rock") || (_player2Choice == "paper" && _player1Choice == "rock"))
      {
        return "Paper wins!";
      }
      else if ((_player1Choice == "scissors" && _player2Choice == "paper") || (_player2Choice == "scissors" && _player1Choice == "paper"))
      {
        return "Scissors wins!";
      }
      else
      {
        return "Draw";
      }
    }
  }
}
