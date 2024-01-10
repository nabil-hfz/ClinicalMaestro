using System;
// using Xunit;

namespace ClinicalMaestro.Tests
{
    [TestClass]
    public class Problem1Tests
    {
        [TestMethod]
        public void GetHighestPossibleNumber_Input12345_Returns54321()
        {
            // Arrange
            Problem1 problem = new Problem1();

            // Act
            long result = problem.GetHighestPossibleNumber(12345);

            // Assert
            Assert.AreEqual(54321, result);
        }

        [TestMethod]
        public void GetHighestPossibleNumber_Input9876543210_Returns9876543210()
        {
            // Arrange
            Problem1 problem = new Problem1();

            // Act
            long result = problem.GetHighestPossibleNumber(9876543210);

            // Assert
            Assert.AreEqual(9876543210, result);
        }

        [TestMethod]
        public void GetHighestPossibleNumber_Input0_Returns0()
        {
            // Arrange
            Problem1 problem = new Problem1();

            // Act
            long result = problem.GetHighestPossibleNumber(0);

            // Assert
            Assert.AreEqual(0, result);
        }

        [TestMethod]
        public void GetInt_InvalidInput_ReturnsValidInput()
        {
            // Arrange
            Problem1 problem = new Problem1();
            string invalidInput = "invalid123";
            string validInput = "456";

            // Use a StringWriter to simulate user input
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                Console.SetIn(new System.IO.StringReader(invalidInput + Environment.NewLine + validInput));

                // Act
                long result = problem.GetInt();

                // Assert
                Assert.AreEqual(456, result);
            }
        }


        [TestMethod]
        public void Start_InvalidInputThenValidInput_ReturnsExpectedResult()
        {
            // Arrange
            Problem1 problem = new Problem1();
            string invalidInput = "invalid123";
            string validInput = "789";

            // Use a StringWriter to simulate user input
            using (var sw = new System.IO.StringWriter())
            {
                Console.SetOut(sw);
                Console.SetIn(new System.IO.StringReader(invalidInput + Environment.NewLine + validInput));

                // Act
                problem.Start();

                // Assert
                string expectedOutput = "Please, enter non-negative number:" + Environment.NewLine +
                                       "The input is not a valid integer." + Environment.NewLine +
                                       "Please, enter non-negative number:" + Environment.NewLine +
                                       "Highest Possible Number is 987" + Environment.NewLine;
                Assert.AreEqual(expectedOutput, sw.ToString());
            }
        }
    }
}
