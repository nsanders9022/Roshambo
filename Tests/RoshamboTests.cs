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

        [Fact]
        public void WinChecker_ReturnPaperWin_InputTwoWin()
        {
            //Arrange
            string inputOne = "rock";
            string inputTwo = "paper";

            //Act
            Roshambo roshamboTest = new Roshambo(inputOne, inputTwo);
            string result = roshamboTest.WinChecker();

            //Assert
            Assert.Equal("input 2 wins with paper", result);
        }

        [Fact]
        public void WinChecker_ReturnRockWin_InputOnein()
        {
            //Arrange
            string inputOne = "rock";
            string inputTwo = "scissors";

            //Act
            Roshambo roshamboTest = new Roshambo(inputOne, inputTwo);
            string result = roshamboTest.WinChecker();

            //Assert
            Assert.Equal("input 1 wins with rock", result);
        }

        [Fact]
        public void WinChecker_ReturnPaperWin_InputOneWin()
        {
            //Arrange
            string inputOne = "paper";
            string inputTwo = "rock";

            //Act
            Roshambo roshamboTest = new Roshambo(inputOne, inputTwo);
            string result = roshamboTest.WinChecker();

            //Assert
            Assert.Equal("input 1 wins with paper", result);
        }

        [Fact]
        public void WinChecker_ReturnPaperTie_NoInputWin()
        {
            //Arrange
            string inputOne = "paper";
            string inputTwo = "paper";

            //Act
            Roshambo roshamboTest = new Roshambo(inputOne, inputTwo);
            string result = roshamboTest.WinChecker();

            //Assert
            Assert.Equal("no input wins", result);
        }

        [Fact]
        public void WinChecker_ReturnScissorsWin_InputTwoWin()
        {
            //Arrange
            string inputOne = "paper";
            string inputTwo = "scissors";

            //Act
            Roshambo roshamboTest = new Roshambo(inputOne, inputTwo);
            string result = roshamboTest.WinChecker();

            //Assert
            Assert.Equal("input 2 wins with scissors", result);
        }

        [Fact]
        public void WinChecker_ReturnRockWin_InputTwoWin()
        {
            //Arrange
            string inputOne = "scissors";
            string inputTwo = "rock";

            //Act
            Roshambo roshamboTest = new Roshambo(inputOne, inputTwo);
            string result = roshamboTest.WinChecker();

            //Assert
            Assert.Equal("input 2 wins with rock", result);
        }

        [Fact]
        public void WinChecker_ReturnPaperWin_InputTwiWin()
        {
            //Arrange
            string inputOne = "scissors";
            string inputTwo = "paper";

            //Act
            Roshambo roshamboTest = new Roshambo(inputOne, inputTwo);
            string result = roshamboTest.WinChecker();

            //Assert
            Assert.Equal("input 1 wins with scissors", result);
        }

        [Fact]
        public void WinChecker_ReturnScissorsTie_NoInputWin()
        {
            //Arrange
            string inputOne = "scissors";
            string inputTwo = "scissors";

            //Act
            Roshambo roshamboTest = new Roshambo(inputOne, inputTwo);
            string result = roshamboTest.WinChecker();

            //Assert
            Assert.Equal("no input wins", result);
        }


    }
}
