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
            string[] expected = { "", " elements"};
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
            string[] expected = { "many",  " elements" };
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
            string[] expected = { "many"," 123" };
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
            string[] expected = { "",  "many",  " 123" };
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
            string[] expected = { "many",  "",  " 123" };
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
            string[] expected = { "many", " 123",  "" };
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
            string[] expected = { "many", " elements", "" };
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
            string[] expected = { "1"," elements" };
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
            string[] expected = { "many", " elements",  };
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
            string[] expected = {  "many",  " 123" };
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
            string[] expected = { "1", "many",  " 123" };
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
            string[] expected = {  "many",  "1",  " 123" };
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
            string[] expected = { "many",  " 123",  "t" };
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
            string[] expected = {"t", " elements",  "1" };
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
            string[] expected = { "manyCharactersTest",  " elements" };
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
            string[] expected = { "many",  " elements" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_One_Last()
        {
            //Arrange
            string array = "many, elements, 123,manyCharactersTest";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many",  " 123"};
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_Many_First()
        {
            //Arrange
            string array = "manyCharactersTest1,manyCharactersTest2,many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "manyCharactersTest1",  "many",  " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_Many_Middle()
        {
            //Arrange
            string array = "many, elements,manyCharactersTest1,manyCharactersTest2, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many",  "manyCharactersTest1", " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_Many_Last()
        {
            //Arrange
            string array = "many, elements, 123,manyCharactersTest1,manyCharactersTest2";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many",  " 123",  "manyCharactersTest2" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_ManyElementsArray_ManyCharacter_Many_Mixed()
        {
            //Arrange
            string array = "manyCharactersTest2,many, elements, 123,manyCharactersTest1";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "manyCharactersTest2"," elements",  "manyCharactersTest1" };
            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion

        #endregion

        #endregion

        #region OutputTests
        #region OneElementArrayTests
        [TestMethod]
        public void DeleteEachEvenElement_Out_OneElementArray_ZeroCharacters_One()
        {
            //Arrange
            string array = ",";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_OneElementArray_OneCharacter_One()
        {
            //Arrange
            string array = "1,324567";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "1" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_OneElementArray_ManyCharacters_One()
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
        public void DeleteEachEvenElement_Out_ManyElementsArray_ZeroCharacters_One_First()
        {
            //Arrange
            string array = ",many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "", " elements" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ZeroCharacters_One_Middle()
        {
            //Arrange
            string array = "many, elements,, 123,1";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "" ,"1"};
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ZeroCharacters_One_Last()
        {
            //Arrange
            string array = "many, elements,,234";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "" };
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ZeroCharacters_Many_First()
        {
            //Arrange
            string array = ",,,,many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "","", "many", " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ZeroCharacters_Many_Middle()
        {
            //Arrange
            string array = "many,,,,, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "", "", " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ZeroCharacters_Many_Last()
        {
            //Arrange
            string array = "many, elements, 123,,,,";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", " 123", "", "" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ZeroCharacters_Many_Mixed()
        {
            //Arrange
            string array = "many,,,, elements, 123,";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", ""," elements", "" };
            CollectionAssert.AreEqual(expected, actual);
        }

        #endregion

        #region OneCharacter
        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_OneCharacter_One_First()
        {
            //Arrange
            string array = "1,many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "1", " elements" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_OneCharacter_One_Middle()
        {
            //Arrange
            string array = "many,1, , 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", " ", };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_OneCharacter_One_Last()
        {
            //Arrange
            string array = "many, elements, ,1";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", " " };
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_OneCharacter_Many_First()
        {
            //Arrange
            string array = "1,t,m, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "1", "m", " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_OneCharacter_Many_Middle()
        {
            //Arrange
            string array = "many, elements,t,1,t, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "t", "t" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_OneCharacter_Many_Last()
        {
            //Arrange
            string array = "many, elements, 123,1,t,1,1";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", " 123", "t", "1" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_OneCharacter_Many_Mixed()
        {
            //Arrange
            string array = "t,many, elements, 123,1";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "t", " elements", "1" };
            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion

        #region ManyCharactersTests
        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ManyCharacter_One_First()
        {
            //Arrange
            string array = "manyCharactersTest,many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "manyCharactersTest", " elements" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ManyCharacter_One_Middle()
        {
            //Arrange
            string array = "many,manyCharactersTest, elements, 123,234,234";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", " elements","234" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ManyCharacter_One_Last()
        {
            //Arrange
            string array = "many, elements, 123,manyCharactersTest";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }


        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ManyCharacter_Many_First()
        {
            //Arrange
            string array = "manyCharactersTest1,manyCharactersTest2,many, elements, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "manyCharactersTest1", "many", " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ManyCharacter_Many_Middle()
        {
            //Arrange
            string array = "many, elements,manyCharactersTest1,manyCharactersTest2, 123";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", "manyCharactersTest1", " 123" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ManyCharacter_Many_Last()
        {
            //Arrange
            string array = "many, elements, 123,manyCharactersTest1,manyCharactersTest2";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "many", " 123", "manyCharactersTest2" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void DeleteEachEvenElement_Out_ManyElementsArray_ManyCharacter_Many_Mixed()
        {
            //Arrange
            string array = "manyCharactersTest2,many, elements, 123,manyCharactersTest1";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "manyCharactersTest2", " elements", "manyCharactersTest1" };
            CollectionAssert.AreEqual(expected, actual);
        }
        #endregion

        #endregion


        #endregion

        #region ValidInputTests
        /*
         * Тестирование допустимых значений и границ класса
         */

        //Тест должен иметь неправильный ответ
        [TestMethod]
        public void DeleteEachEvenElement_UnexpectedFormat_WrongSplit_Space()
        {
            //Arrange.
            string array = "123 asdf TEXT 42";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "123", " TEXT"};
            CollectionAssert.AreEqual(expected, actual);
        }

        //Тест должен иметь неправильный ответ
        [TestMethod]
        public void DeleteEachEvenElement_UnexpectedFormat_WrongSplit_Dot()
        {
            //Arrange.
            string array = "123. asdf. TEXT. 42";

            //Act.
            string[] actual = ArrayControl.DeleteEachEvenElement(array);

            //Assert.
            string[] expected = { "123", " TEXT" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
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
            string[] expected = { "123", " TEXT",};
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
                expected[(int)Math.Ceiling((double)i/ (double)2)] = i.ToString();

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
                expected[(int)Math.Ceiling((double)i / (double)2)] = i.ToString();
             
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
