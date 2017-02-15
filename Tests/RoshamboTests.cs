using Xunit;

namespace RoshamboApp
{
    public class RoshamboTests
    {
        [Fact]
        public void WinChecker_ReturnTieRock_NoWin()
        {
            //Arrange
            string inputOne = "rock";
            string inputTwo = "rock";

            //Act
            Roshambo roshamboTest = new Roshambo(inputOne, inputTwo);
            // roshamboTest.SetInput(inputOne, inputTwo);
            string result = roshamboTest.WinChecker();

            //Assert
            Assert.Equal("no input wins", result);
        }
        
    }
}
