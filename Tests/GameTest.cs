using Xunit;
using RockPaperScissors.Objects;

namespace RockPaperScissors
{
  public class GameTest
  {
    [Fact]
    public void GameTest_RockBeatsScissors_True()
    {
      Game testGame = new Game("rock","scissors");
      Assert.Equal("Rock wins!", testGame.DetermineWinner());
    }
  }
}
