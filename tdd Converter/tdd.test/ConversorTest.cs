using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd.test
{
    [TestClass]
    public class ConversorTest
    {
        [TestMethod]
        public void ConvertDecimalToBinaryTest()
        {
            //Arrange
            var bInit = "10";
            var bConvert = "2";
            var value = "8";
            var convert = new tdd.Conversor();
            var expectedResult = "1000";

            //Act
            var result = convert.Conver(bInit, bConvert, value);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void ConvertHexToBinaryTest()
        {
            //Arrange
            var bInit = "16";
            var bConvert = "2";
            var value = "0xa";
            var convert = new tdd.Conversor();
            var expectedResult = "1010";

            //Act
            var result = convert.Conver(bInit, bConvert, value);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void ConvertBinaryToDecimalTest()
        {
            //Arrange
            var bInit = "2";
            var bConvert = "10";
            var value = "1010";
            var convert = new tdd.Conversor();
            var expectedResult = "10";

            //Act
            var result = convert.Conver(bInit, bConvert, value);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void ConvertHexToDecimalTest()
        {
            //Arrange
            var bInit = "16";
            var bConvert = "10";
            var value = "0xa";
            var convert = new tdd.Conversor();
            var expectedResult = "10";

            //Act
            var result = convert.Conver(bInit, bConvert, value);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void ConvertDecimalToHexTest()
        {
            //Arrange
            var bInit = "10";
            var bConvert = "16";
            var value = "10";
            var convert = new tdd.Conversor();
            var expectedResult = "a";

            //Act
            var result = convert.Conver(bInit, bConvert, value);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }

        [TestMethod]
        public void ConvertBinaryToHexTest()
        {
            //Arrange
            var bInit = "2";
            var bConvert = "16";
            var value = "1010";
            var convert = new tdd.Conversor();
            var expectedResult = "a";

            //Act
            var result = convert.Conver(bInit, bConvert, value);

            //Assert
            Assert.AreEqual(result, expectedResult);
        }
    }
}
