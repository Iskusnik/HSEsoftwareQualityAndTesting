using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace HSESoftwareQualityAndTesting
{

    /// <summary>
    /// Работа с массивами
    /// </summary>
    public class ArrayControl
    {

        /// <summary>
        /// Функция удаляет из списка каждый второй элемент
        /// </summary>
        /// <param name="array">  Элементы массива перечисленные через запятую в строке, к примеру, "1.2, 2, 3.5".</param>
        static public string[] DeleteEachEvenElement(string array)
        {
            //Получаем список объектов из строки
            string[] arrayElements = array.Split(',');

            //Инициализируем выходной параметр
            int resultLength = (int)Math.Round((double)(arrayElements.Length + 0.1) / 2.0);
            string[] result = new string[resultLength];

            //Оставляем каждый первый элемент (таким образом удаляем каждый второй)
            for (int i = 0; i < resultLength; i++)
                result[i] = arrayElements[i * 2];

            return result;
        }

    }
}


