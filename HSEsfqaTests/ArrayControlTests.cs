using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HSESoftwareQualityAndTesting
{
    [TestClass]
    public class ArrayControlTests
    {

        #region InputTests
        /* Проверка входных данных
         * Здесь же и проверка: 
         * -длины набора,
         * -упорядоченности набора данных.
         * 
         * 
         * 
         * Название тестов в InputTests:
         * *Функция*_*Число элементов в массиве*_*Число символов в элементе*_*Число таких элементов*_*Расположение этих элементов*
         */
        #region OneElementArrayTests
        [TestMethod]
        public void DeleteEachEvenElement_OneElementArray_ZeroCharacters_One()
        {
            //Arrange
            string array = "";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "" };
            CollectionAssert.AreEqual(expected, actual);
        }
        
        [TestMethod]
        public void DeleteEachEvenElement_OneElementArray_OneCharacter_One()
        {
            //Arrange
            string array = "1";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "1" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_OneElementArray_ManyCharacters_One()
        {
            //Arrange
            string array = "many characters";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many characters" };
            CollectionAssert.AreEqual(expected, actual);
        }


        #endregion
        
        #region ManyElementsArrayTests
        #region ZeroCharactersTests
        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ZeroCharacters_One_First()
        {
            //Arrange
            string array = ",many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "", "many", " elements", " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ZeroCharacters_One_Middle()
        {
            //Arrange
            string array = "many,, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "",  " elements", " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ZeroCharacters_One_Last()
        {
            //Arrange
            string array = "many, elements, 123,";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", " elements", " 123", "" };
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ZeroCharacters_Many_First()
        {
            //Arrange
            string array = ",,many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "", "", "many", "elements", "123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ZeroCharacters_Many_Middle()
        {
            //Arrange
            string array = "many,,, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "", "", "elements", "123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ZeroCharacters_Many_Last()
        {
            //Arrange
            string array = "many, elements, 123,,";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "elements", "123", "", "" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ZeroCharacters_Many_Mixed()
        {
            //Arrange
            string array = "many,, elements, 123,";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "", "elements", "123", "" };
            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion

        #region OneCharacter
        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_OneCharacter_One_First()
        {
            //Arrange
            string array = "1,many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "1", "many", "elements", "123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_OneCharacter_One_Middle()
        {
            //Arrange
            string array = "many,1, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "1", "elements", "123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_OneCharacter_One_Last()
        {
            //Arrange
            string array = "many, elements, 123,1";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = {  "many", "elements", "123", "1" };
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_OneCharacter_Many_First()
        {
            //Arrange
            string array = "1,t,many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "1", "t", "many", "elements", "123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_OneCharacter_Many_Middle()
        {
            //Arrange
            string array = "many, elements,1,t, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = {  "many", "elements", "1", "t", "123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_OneCharacter_Many_Last()
        {
            //Arrange
            string array = "many, elements, 123,1,t";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "elements", "123", "1", "t" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_OneCharacter_Many_Mixed()
        {
            //Arrange
            string array = "t,many, elements, 123,1";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = {"t","many", "elements", "123", "1" };
            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion

        #region ManyCharactersTests
        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_One_First()
        {
            //Arrange
            string array = "manyCharactersTest,many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "manyCharactersTest", "many", " elements", " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_One_Middle()
        {
            //Arrange
            string array = "many,manyCharactersTest, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "manyCharactersTest", " elements", " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_One_Last()
        {
            //Arrange
            string array = "many, elements, 123,1";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "elements", "123", "1" };
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_Many_First()
        {
            //Arrange
            string array = "1,t,many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "1", "t", "many", "elements", "123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_Many_Middle()
        {
            //Arrange
            string array = "many, elements,1,t, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "elements", "1", "t", "123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_Many_Last()
        {
            //Arrange
            string array = "many, elements, 123,1,t";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "elements", "123", "1", "t" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_Many_Mixed()
        {
            //Arrange
            string array = "t,many, elements, 123,1";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "t", "many", "elements", "123", "1" };
            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion

        #region ManyCharactersTests
        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharactersOne_Last()
        {
        }
        #endregion


        #endregion



        #endregion

        #region OutputTests

        #endregion

        #region ValidInputTests
        /*
         * Тестирование допустимых значений и границ класса
         */
        [TestMethod]
        public void DeleteEachEvenElement_UnexpectedFormat_WrongSplit_Space()
        {
            //Arrange.
            string array = "123 asdf TEXT 42";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "123", "TEXT"};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_UnexpectedFormat_WrongSplit_Dot()
        {
            //Arrange.
            string array = "123. asdf. TEXT. 42";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "123", "TEXT" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(TypeLoadException))]
        public void DeleteEachEvenElement_UnexpectedFormat_WrongType()
        {
            //Arrange.
            object array = 1.001;

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement((string)array);

            //Assert.
            string[] expected = { "" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_TextAndNumbers()
        {
            //Arrange.
            string array = "123, asdf, TEXT, 42";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "123", "TEXT",};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ThousandElements()
        {
            //Arrange.
            string array = "0";
            for (int i = 1; i < 1000; i++)
                array += "," + i.ToString();

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = new string[500];

            for (int i = 0; i < 1000; i += 2)
                expected[i] = i.ToString();

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_TenThousandElements()
        {
            //Arrange.
            string array = "0";
            for (int i = 1; i < 10000; i++)
                array += "," + i.ToString();

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = new string[5000];

            for (int i = 0; i < 10000; i += 2)
                expected[i] = i.ToString();
             
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ZeroElementsArray()
        {
            //Arrange.
            string array = "";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = {""};
            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion
    }
}
