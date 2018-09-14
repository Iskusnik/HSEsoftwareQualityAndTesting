using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;


namespace HSESoftwareQualityAndTesting.Tests
{
    [TestClass]
    public class MyMathsTests
    {
        [TestMethod]

        public void Sum_TwoNumbers()
        {
            //Arrange.
            string info = "1 2";

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = 3;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]

        public void Sum_ThreeNumbers()
        {
            //Arrange.
            string info = "1 2 10";

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = 13;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]

        public void Sum_NegativeNumbers()
        {
            //Arrange.
            string info = "-1 -2 -10";

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = -13;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]

        public void Sum_ThreeNumbersNegativeResult()
        {
            //Arrange.
            string info = "-5 20 -19";

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = -4;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Sum_ZeroNumbers()
        {
            //Arrange.

            string info = "";

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Sum_NotANumber()
        {
            //Arrange.

            string info = "Aasd Cafsfa Dacscas";

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]

        public void Sum_OtherSplit()
        {
            //Arrange.

            string info = "1,2,3";

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = 6;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Sum_TooMuchForInteger()
        {
            //Arrange.
            string info = "1,20000000000000,3,10000000000";

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void Sum_NumbersAndWords()
        {
            //Arrange.
            string info = "1,5,3,4,asdadsasd afsffsa  ";

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = 0;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        //[ExpectedException(typeof(FormatException))]
        public void Sum_MultipleSpaces()
        {
            //Arrange.
            string info = "1 4  3 4";

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = 12;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(OverflowException))]
        public void Sum_Overflow()
        {
            //Arrange.
            string info = "2 " + int.MaxValue.ToString();

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = 12;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void Sum_things()
        {
            //Arrange.
            string info = "2 " + int.MaxValue.ToString();

            //Act.
            int actual = MyMaths.Sum(info);

            //Assert.
            int expected = 12;
            Assert.AreEqual(expected, actual);
            CollectionAssert
        }
    }
}
