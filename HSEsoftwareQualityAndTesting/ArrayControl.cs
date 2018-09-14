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



/*
2. Найти корни квадратного уравнения, заданного своими коэффициентами. Предусмотреть все возможные случаи (два действительных корня, один корень, нет корней). На вход коэф. a,b,c (тип double).
3. Положения ферзей на шахматной доске заданы списком пар (горизонталь, вертикаль). Определить, имеется ли пара ферзей, бьющих друг друга.
Провести модульное тестирование реализованных функций по критериям черного ящика, по каждому критерию не менее 7 тестов.
Отправить необходимо код, который должен быть читабельным. Названия переменных, методов, проектов, комментариев в соответствии со стандартами.*/
