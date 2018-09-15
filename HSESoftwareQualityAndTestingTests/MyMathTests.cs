using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HSESoftwareQualityAndTesting
{
    [TestClass]
    public class MyMathTests
    {
        #region InputTests
        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SquareEquitationSolver_ZeroParametrs()
        {
            //Arrange.

            //Act.
            double[] actual = MyMath.SquareEquitationSolver();

            //Assert.
            double[] expected = { 0 };
            CollectionAssert.AreEqual(expected, actual);
        }

        #region OneInputParametr
        //Если остальные параметры не указаны, значит они равны нулю
        //Соответственно здесь же и тесты при паре параметров принимающих нулевое значение
        [TestMethod]
        public void SquareEquitationSolver_OneParametr_a_Positive()
        {
            //Arrange.
            double a = 1;
            double b;
            double c;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a);

            //Assert.
            double[] expected = { 0 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SquareEquitationSolver_OneParametr_a_Negative()
        {
            //Arrange
            double a = -1;
            double b;
            double c;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a);

            //Assert.
            double[] expected = { 0 };
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void SquareEquitationSolver_OneParametr_b_Positive()
        {
            //Arrange
            double a;
            double b = 1;
            double c;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(b: b);

            //Assert.
            double[] expected = { 0 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SquareEquitationSolver_OneParametr_b_Negative()
        {
            //Arrange
            double a;
            double b = -1;
            double c;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(b: b);

            //Assert.
            double[] expected = { 0 };
            CollectionAssert.AreEqual(expected, actual);
        }



        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SquareEquitationSolver_OneParametr_c_Positive()
        {
            //Arrange
            double a;
            double b;
            double c = 1;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(c: c);

            //Assert.
            double[] expected = { 0 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SquareEquitationSolver_OneParametr_c_Negative()
        {
            //Arrange
            double a;
            double b;
            double c = -1;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(c: c);

            //Assert.
            double[] expected = { 0 };
            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion

        #region TwoInputParametrs
        //Если остальные параметры не указаны, значит они равны нулю
        //Соответственно здесь же и тесты при каком-нибудь параметре принимающем нулевое значение
        [TestMethod]
        public void SquareEquitationSolver_TwoParametrs_a_Positive_b_Negative()
        {
            //Arrange.
            double a = 2;
            double b = -2;
            double c;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, b);

            //Assert.
            double[] expected = { 1, 0 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SquareEquitationSolver_TwoParametrs_a_Negative_c_Positive()
        {
            //Arrange.
            double a = -2;
            double b;
            double c = 2;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, c: c);

            //Assert.
            double[] expected = { -1, 1 };
            CollectionAssert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void SquareEquitationSolver_TwoParametrs_c_Negative_b_Positive()
        {
            //Arrange.
            double a;
            double b = 2;
            double c = -2;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(b: b, c: c);

            //Assert.
            double[] expected = { 1 };
            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion


        #endregion

        #region OutputTests
        [TestMethod]
        public void SquareEquitationSolver_ZeroRootsOut()
        {
            //Arrange.
            double a = 1234;
            double b = 2;
            double c = 132;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, b, c);

            //Assert.
            double[] expected = {};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareEquitationSolver_OneRootOut()
        {
            //Arrange.
            double a;
            double b = 2;
            double c;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(b: b);

            //Assert.
            double[] expected = { 0 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareEquitationSolver_TwoRootsOut()
        {
            //Arrange.
            double a = 1;
            double b = 2;
            double c = -3;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, b, c);

            //Assert.
            double[] expected = { 1, -3 };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void SquareEquitationSolver_ExceptionOut()
        {
            //Arrange.
            double a;
            double b;
            double c = -2;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(c: c);

            //Assert.
            double[] expected = { 1 };
            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion

        #region ValidInputTests
        [TestMethod]
        public void SquareEquitationSolver_AllMinimalDoubles()
        {
            //Arrange.
            double a = double.MinValue;
            double b = double.MinValue;
            double c = double.MinValue;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, b, c);

            //Assert.
            double[] expected = { };
            CollectionAssert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void SquareEquitationSolver_AllMaximalDoubles()
        {
            //Arrange.
            double a = double.MaxValue;
            double b = double.MaxValue;
            double c = double.MaxValue;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, b, c);

            //Assert.
            double[] expected = {  };
            CollectionAssert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void SquareEquitationSolver_a_Max()
        {
            //Arrange.
            double a = double.MaxValue;
            double b = double.MinValue;
            double c = double.MinValue;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, b, c);

            //Assert.
            double[] expected = { double.PositiveInfinity, double.NegativeInfinity };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareEquitationSolver_b_Max()
        {
            //Arrange.
            double a = double.MinValue;
            double b = double.MaxValue;
            double c = double.MinValue;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, b, c);

            //Assert.
            double[] expected = { };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareEquitationSolver_c_Max()
        {
            //Arrange.
            double a = double.MinValue;
            double b = double.MinValue;
            double c = double.MaxValue;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, b, c);

            //Assert.
            double[] expected = { double.NegativeInfinity, double.PositiveInfinity };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareEquitationSolver_a_Min()
        {
            //Arrange.
            double a = double.MinValue;
            double b = double.MaxValue;
            double c = double.MaxValue;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, b, c);

            //Assert.
            double[] expected = { double.NegativeInfinity, double.PositiveInfinity };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareEquitationSolver_b_Min()
        {
            //Arrange.
            double a = double.MaxValue;
            double b = double.MinValue;
            double c = double.MaxValue;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, b, c);

            //Assert.
            double[] expected = { };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void SquareEquitationSolver_c_Min()
        {
            //Arrange.
            double a = double.MaxValue;
            double b = double.MaxValue;
            double c = double.MinValue;

            //Act.
            double[] actual = MyMath.SquareEquitationSolver(a, b, c);

            //Assert.
            double[] expected = { double.PositiveInfinity, double.NegativeInfinity };
            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion
    }
}
