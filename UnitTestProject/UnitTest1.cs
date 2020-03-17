using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class UnitTest1
    {
        private Calculator _calculator;

        [TestInitialize]
            public void TestInitialize()
        {
            _calculator = new Calculator();
        }

        [TestMethod]
        public void ConvertRomanNumerals_When_X_Returns_10()
        {
            //Arrange
            var numeral = "X";
            //Act
            var result = _calculator.ConvertRomanNumerals(numeral);
            //Assert
            Assert.AreEqual(10, result);
        }

        [TestMethod]
        public void ConvertRomanNumerals_When_I_Returns_1()
        {
            //Arrange
            var numeral = "I";
            //Act
            var result = _calculator.ConvertRomanNumerals(numeral);
            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        public void ConvertRomanNumerals_When_V_Returns_5()
        {
            //Arrange
            var numeral = "V";
            //Act
            var result = _calculator.ConvertRomanNumerals(numeral);
            //Assert
            Assert.AreEqual(5, result);
        }

        [TestMethod]
        public void ConvertRomanNumerals_When_L_Returns_50()
        {
            //Arrange
            var numeral = "L";
            //Act
            var result = _calculator.ConvertRomanNumerals(numeral);
            //Assert
            Assert.AreEqual(50, result);
        }

        [TestMethod]
        public void ConvertRomanNumerals_When_C_Returns_100()
        {
            //Arrange
            var numeral = "C";
            //Act
            var result = _calculator.ConvertRomanNumerals(numeral);
            //Assert
            Assert.AreEqual(100, result);
        }

        [TestMethod]
        public void ConvertRomanNumerals_When_D_Returns_500()
        {
            //Arrange
            var numeral = "D";
            //Act
            var result = _calculator.ConvertRomanNumerals(numeral);
            //Assert
            Assert.AreEqual(500, result);
        }

        [TestMethod]
        public void ConvertRomanNumerals_When_M_Returns_1000()
        {
            //Arrange
            var numeral = "M";
            //Act
            var result = _calculator.ConvertRomanNumerals(numeral);
            //Assert
            Assert.AreEqual(1000, result);
        }

        [TestMethod]
        public void ConvertRomanNumerals_When_IV_Returns_4()
        {
            //Arrange
            var numeral = "IV";
            //Act
            var result = _calculator.ConvertRomanNumerals(numeral);
            //Assert
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void ConvertRomanNumerals_When_VI_Returns_6()
        {
            //Arrange
            var numeral = "VI";
            //Act
            var result = _calculator.ConvertRomanNumerals(numeral);
            //Assert
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void ConvertRomanNumerals_When_Lowercase_i_Returns_1()
        {
            //Arrange
            var numeral = "i";
            //Act
            var result = _calculator.ConvertRomanNumerals(numeral);
            //Assert
            Assert.AreEqual(1, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_ZZZ_Is_numeral()
        {
            //Arrange
            var numeral = "ZZZ";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);

            
        }

        [TestMethod]
        public void ConvertRomanNumerals_When_XLIX_returns_49()
        {
            //Arrange
            var numeral = "XLIX";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);

            //Assert
            Assert.AreEqual(49, result);

        }

        [TestMethod]
        public void ConvertRomanNumerals_When_MMMCMXCIX_returns_3999()
        {
            //Arrange
            var numeral = "MMMCMXCIX";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);

            //Assert
            Assert.AreEqual(3999, result);

        }

        [TestMethod]
        public void ConvertRomanNumerals_When_MMMDCCCLXXXVIII_returns_3888()
        {
            //Arrange
            var numeral = "MMMDCCCLXXXVIII";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);

            //Assert
            Assert.AreEqual(3888, result);

        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_1234_Is_Parameter()
        {
            //Arrange
            var numeral = "1234";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_Symbol_Is_Parameter()
        {
            //Arrange
            var numeral = "@";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

    }
}
