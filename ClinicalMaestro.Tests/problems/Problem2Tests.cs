using ClinicalMaestro;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace ClinicalMaestro.Tests
{
    [TestClass]
    public class Problem2Tests
    {
        private Problem2 problem2;

        [TestInitialize]
        public void SetUp()
        {
            problem2 = new Problem2();
        }

        [TestMethod]
        public void TestWithRegularSentence()
        {
            string input = "The sunset sets at twelve o' clock.";
            string expected = "20 8 5 19 21 14 19 5 20 19 5 20 19 1 20 20 23 5 12 22 5 15 3 12 15 3 11";
            Assert.AreEqual(expected, problem2.ConvertToAlphabetPosition(input));
        }

        [TestMethod]
        public void TestWithAllUppercaseLetters()
        {
            string input = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string expected = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26";
            Assert.AreEqual(expected, problem2.ConvertToAlphabetPosition(input));
        }

        [TestMethod]
        public void TestWithAllLowercaseLetters()
        {
            string input = "abcdefghijklmnopqrstuvwxyz";
            string expected = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26";
            Assert.AreEqual(expected, problem2.ConvertToAlphabetPosition(input));
        }

        [TestMethod]
        public void TestWithNumbersAndSymbols()
        {
            string input = "123!@#abcXYZ";
            string expected = "1 2 3 24 25 26";
            Assert.AreEqual(expected, problem2.ConvertToAlphabetPosition(input));
        }

        [TestMethod]
        public void TestWithEmptyString()
        {
            string input = "";
            string expected = "";
            Assert.AreEqual(expected, problem2.ConvertToAlphabetPosition(input));
        }

        [TestMethod]
        public void TestWithAlphabetString()
        {
            string input = "abcdefghijklmnopqrstuvwxyz";
            string expected = "1 2 3 4 5 6 7 8 9 10 11 12 13 14 15 16 17 18 19 20 21 22 23 24 25 26";
            Assert.AreEqual(expected, problem2.ConvertToAlphabetPosition(input));
        }
    }
}