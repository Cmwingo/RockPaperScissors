using System.Collections.Generic;

namespace RockPaperScissors.Objects
{
  public class Game
  {
    private string _player1Choice;
    private string _player2Choice;

    public Game(string player1Choice, string player2Choice)
    {
      _player1Choice = player1Choice;
      _player2Choice = player2Choice;
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
