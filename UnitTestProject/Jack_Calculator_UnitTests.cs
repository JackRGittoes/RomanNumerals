using Microsoft.VisualStudio.TestTools.UnitTesting;
using RomanNumerals;
using System;

namespace UnitTestProject
{
    [TestClass]
    public class Jack_UnitTests
    {
        private Jack_Calculator _calculator;

        [TestInitialize]
        public void TestInitialize()
        {
            _calculator = new Jack_Calculator();
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

        #region Invalid combinations tests

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_More_Than_3_Is()
        {
            //Arrange
            var numeral = "IIII";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_More_Than_One_V()
        {
            //Arrange
            var numeral = "VV";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_More_Than_One_L()
        {
            //Arrange
            var numeral = "LL";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_More_Than_One_D()
        {
            //Arrange
            var numeral = "DD";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_I_Before_L()
        {
            //Arrange
            var numeral = "IL";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_I_Before_C()
        {
            //Arrange
            var numeral = "IC";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_I_Before_D()
        {
            //Arrange
            var numeral = "ID";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_I_Before_M()
        {
            //Arrange
            var numeral = "IM";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_V_Before_X()
        {
            //Arrange
            var numeral = "VX";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_V_Before_L()
        {
            //Arrange
            var numeral = "VL";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_V_Before_C()
        {
            //Arrange
            var numeral = "VC";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_V_Before_D()
        {
            //Arrange
            var numeral = "VD";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_V_Before_M()
        {
            //Arrange
            var numeral = "VM";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_X_Before_D()
        {
            //Arrange
            var numeral = "XD";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_X_Before_M()
        {
            //Arrange
            var numeral = "XM";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_L_Before_C()
        {
            //Arrange
            var numeral = "LC";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_L_Before_D()
        {
            //Arrange
            var numeral = "LD";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_L_Before_M()
        {
            //Arrange
            var numeral = "LM";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void ConvertRomanNumerals_ThrowsException_When_D_Before_M()
        {
            //Arrange
            var numeral = "DM";

            //Act 
            var result = _calculator.ConvertRomanNumerals(numeral);
        }

        #endregion
    }
}
