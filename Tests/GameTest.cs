using Xunit;
using RockPaperScissors.Objects;

namespace RockPaperScissors
{
  public class GameTest
  {
    [Fact]
    public void GameTest1_RockBeatsScissors_True()
    {
      Game testGame = new Game("scissors", "rock");
      Assert.Equal("Rock crushes scissors. Player 2 Wins!", testGame.DetermineWinner());
    }

    [Fact]
    public void GameTest2_PaperBeatsRock_True()
    {
      Game testGame = new Game("paper", "rock");
      Assert.Equal("Paper covers rock. Player 1 Wins!", testGame.DetermineWinner());
    }

    [Fact]
    public void GameTest3_ScissorsBeatsPaper_True()
    {
      Game testGame = new Game("paper","scissors");
      Assert.Equal("Scissors cut paper. Player 2 Wins!", testGame.DetermineWinner());
    }

    [Fact]
    public void GameTest4_RockBeatsLizard_True()
    {
      Game testGame = new Game("rock","lizard");
      Assert.Equal("Rock crushes lizard. Player 1 Wins!", testGame.DetermineWinner());
    }

    [Fact]
    public void GameTest5_PaperBeatsSpock_True()
    {
      Game testGame = new Game("Spock","paper");
      Assert.Equal("Paper disproves Spock. Player 2 Wins!", testGame.DetermineWinner());
    }

    [Fact]
    public void GameTest6_ScissorsBeatsLizard_True()
    {
      Game testGame = new Game("lizard","scissors");
      Assert.Equal("Scissors decapitates lizard. Player 2 Wins!", testGame.DetermineWinner());
    }

    [Fact]
    public void GameTest7_LizardBeatsPaper_True()
    {
      Game testGame = new Game("lizard","paper");
      Assert.Equal("Lizard eats paper. Player 1 Wins!", testGame.DetermineWinner());
    }

    [Fact]
    public void GameTest8_LizardBeatsSpock_True()
    {
      Game testGame = new Game("Spock","lizard");
      Assert.Equal("Lizard poisions Spock. Player 2 Wins!", testGame.DetermineWinner());
    }
  }
}
