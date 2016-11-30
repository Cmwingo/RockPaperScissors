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
      Assert.Equal("Rock wins!", testGame.DetermineWinner());
    }

    [Fact]
    public void GameTest2_PaperBeatsRock_True()
    {
      Game testGame = new Game("paper", "rock");
      Assert.Equal("Paper wins!", testGame.DetermineWinner());
    }

    [Fact]
    public void GameTest3_ScissorsBeatsPaper_True()
    {
      Game testGame = new Game("paper","scissors");
      Assert.Equal("Scissors wins!", testGame.DetermineWinner());
    }
  }
}
