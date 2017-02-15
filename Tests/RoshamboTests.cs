using Xunit;

namespace RoshamboApp
{
    public class RoshamboTests
    {
        [Fact]
        //Arrange
        string inputOne = "rock";
        string inputTwo = "rock";
        Roshambo roshamboTest = new Roshambo();

        //Act
        roshamboTest.SetInput(inputOne, inputTwo);
        string result = roshamboTest.WinChecker();

        //Assert
        Assert.Equal("no input wins", result);
    }
}
