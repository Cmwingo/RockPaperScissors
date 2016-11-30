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
      Assert.Equal("Player 2 wins with Rock!", testGame.DetermineWinner());
    }

    [Fact]
    public void GameTest2_PaperBeatsRock_True()
    {
      Game testGame = new Game("paper", "rock");
      Assert.Equal("Player 1 wins with Paper!", testGame.DetermineWinner());
    }

    [Fact]
    public void GameTest3_ScissorsBeatsPaper_True()
    {
      Game testGame = new Game("paper","scissors");
      Assert.Equal("Player 2 wins with Scissors!", testGame.DetermineWinner());
    }
  }
}
