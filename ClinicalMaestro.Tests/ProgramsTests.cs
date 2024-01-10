namespace ClinicalMaestro.Tests;

[TestClass]
public class ProgramsTests
{


    [TestMethod]
    public void PrintMenu_InvalidChoice_FormatException()
    {
        // Arrange
        var inputProvider = new Func<string>(() => "invalid");

        // Act & Assert
        Assert.ThrowsException<FormatException>(() => Program.PrintMenu(inputProvider));
    }

    [TestMethod]
    public void PrintMenu_ZeroInput_ReturnsMinusOne()
    {
        // Arrange
        var inputProvider = new Func<string>(() => "0");

        // Act
        int result = Program.PrintMenu(inputProvider);

        // Assert
        Assert.AreEqual(-1, result);
    }
    
    [TestMethod]
    public void PrintMenu_OutOfRangeChoice_ReturnsMinusOne()
    {
        // Arrange
        var inputProvider = new Func<string>(() => "4");

        // Act
        int result = Program.PrintMenu(inputProvider);

        // Assert
        Assert.AreEqual(-1, result);
    }

    [TestMethod]
    public void PrintMenu_ValidChoice_ReturnsChoice()
    {
        // Arrange
        var inputProvider = new Func<string>(() => "1");

        // Act
        int result = Program.PrintMenu(inputProvider);

        // Assert
        Assert.AreEqual(1, result);
    }


    [TestMethod]
    public void PrintMenu_ExitChoice_ReturnsExitCode()
    {
        // Arrange
        var inputProvider = new Func<string>(() => "3");

        // Act
        int result = Program.PrintMenu(inputProvider);

        // Assert
        Assert.AreEqual(3, result);
    }




}