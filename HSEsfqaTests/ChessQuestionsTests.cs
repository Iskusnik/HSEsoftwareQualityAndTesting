using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace HSESoftwareQualityAndTesting
{
    [TestClass]
    public class ChessQuestionsTests
    {
        #region InputTests
        [TestMethod]
        public void AreAnyQueensHitEachOther_ZeroQueens()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void AreAnyQueensHitEachOther_OneQueen_CornerLeftDown()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(1, 1));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreAnyQueensHitEachOther_OneQueen_CornerRightUp()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(8, 8));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreAnyQueensHitEachOther_ManyQueens_Hits_Vertical()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(1, 1));
            queens.Add(new ChessUnitData(8, 1));
            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreAnyQueensHitEachOther_ManyQueens_Hits_Horizontal()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(1, 1));
            queens.Add(new ChessUnitData(1, 6));
            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreAnyQueensHitEachOther_ManyQueens_Hits_DiagonalUpLeftToRightDown()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(8, 1));
            queens.Add(new ChessUnitData(1, 8));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreAnyQueensHitEachOther_ManyQueens_Hits_DiagonalDownLeftToRightUp()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(1, 1));
            queens.Add(new ChessUnitData(8, 8));
            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreAnyQueensHitEachOther_ManyQueens_NoHits()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(8, 8));
            queens.Add(new ChessUnitData(3, 5));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreAnyQueensHitEachOther_ManyQueens_NoHits_MaxPossibleQueensNoHit()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(1, 7));
            queens.Add(new ChessUnitData(2, 4));
            queens.Add(new ChessUnitData(3, 2));
            queens.Add(new ChessUnitData(4, 8));
            queens.Add(new ChessUnitData(5, 6));
            queens.Add(new ChessUnitData(6, 1));
            queens.Add(new ChessUnitData(7, 3));
            queens.Add(new ChessUnitData(8, 5));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region ValidInputTests

        [TestMethod]
        public void AreAnyQueensHitEachOther_ValidInput()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(1, 3));
            queens.Add(new ChessUnitData(1, 2));
            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AreAnyQueensHitEachOther_QueenFallOffTheChessboard_ToRight()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(1, 9));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AreAnyQueensHitEachOther_QueenFallOffTheChessboard_ToLeft()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(1, 0));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AreAnyQueensHitEachOther_QueenFallOffTheChessboard_ToUp()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(9, 1));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }


        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AreAnyQueensHitEachOther_QueenFallOffTheChessboard_ToDown()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(0, 5));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(Exception))]
        public void AreAnyQueensHitEachOther_QueenOnQueen()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(5, 5));
            queens.Add(new ChessUnitData(4, 4));
            queens.Add(new ChessUnitData(0, 5));
            queens.Add(new ChessUnitData(0, 5));
            queens.Add(new ChessUnitData(0, 5));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }
        #endregion

        #region OutputTests
        [TestMethod]
        public void AreAnyQueensHitEachOther_ResultFalse()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(1, 7));
            queens.Add(new ChessUnitData(2, 4));
            queens.Add(new ChessUnitData(3, 2));
            queens.Add(new ChessUnitData(4, 8));
            queens.Add(new ChessUnitData(5, 6));
            queens.Add(new ChessUnitData(6, 1));
            queens.Add(new ChessUnitData(7, 3));
            queens.Add(new ChessUnitData(8, 5));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = false;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreAnyQueensHitEachOther_ResultTrue()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(1, 7));
            queens.Add(new ChessUnitData(2, 4));
            queens.Add(new ChessUnitData(3, 2));
            queens.Add(new ChessUnitData(4, 8));
            queens.Add(new ChessUnitData(5, 6));
            queens.Add(new ChessUnitData(6, 1));
            queens.Add(new ChessUnitData(7, 3));
            queens.Add(new ChessUnitData(8, 2));

            //Act.
            bool actual = ChessQuestions.AreAnyQueensHitEachOther(queens);

            //Assert.
            bool expected = true;
            Assert.AreEqual(expected, actual);
        }



        [TestMethod]
        public void AreAnyQueensHitEachOther_ResultExceptionOffTheTable()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            

            //Act.
            string actual = "";
            try
            {
                queens.Add(new ChessUnitData(1, 9));
                ChessQuestions.AreAnyQueensHitEachOther(queens);
            }
            catch(Exception exception)
            {
                actual = exception.Message;
            }
            //Assert.
            string expected = "Фигура за границами доски";
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void AreAnyQueensHitEachOther_ResultExceptionQueenOnQueen()
        {
            //Arrange.
            List<ChessUnitData> queens = new List<ChessUnitData>();
            queens.Add(new ChessUnitData(1, 3));
            queens.Add(new ChessUnitData(1, 3));

            //Act.
            string actual = "";
            try
            {
                ChessQuestions.AreAnyQueensHitEachOther(queens);
            }
            catch (Exception exception)
            {
                actual = exception.Message;
            }
            //Assert.
            string expected = "Клетка занята - ферзь не может стоять здесь";
            Assert.AreEqual(expected, actual);
        }
        #endregion
    }
}
