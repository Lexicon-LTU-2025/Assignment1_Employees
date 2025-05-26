using Employees.Abstractions;
using Employees.Helpers;
using Moq;
using Ovning1.UI;

namespace EmployeesTests;

public class UtilTests
{
    [Fact]
    public void AskForString_ShouldReturnExpectedString()
    {
        //Arrange
        const string expected = "some value";
        var mockUI = new MockUI();
        mockUI.SetInput = expected;

        //Act
        var actual = Util.AskForString("", mockUI);

        //Assert
        Assert.Equal(expected, actual);
    }
    
    [Fact]
    public void AskForString_ShouldReturnExpectedString_WithMoq()
    {
        //Arrange
        const string expected = "some value";
        var mockUI = new Mock<IUI>();
        mockUI.Setup(u => u.GetInput()).Returns(expected);

        //Act
        var actual = Util.AskForString("", mockUI.Object);

        //Assert
        Assert.Equal(expected, actual);
    }
}
