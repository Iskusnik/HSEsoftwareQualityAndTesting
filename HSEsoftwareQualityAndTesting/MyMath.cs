using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSESoftwareQualityAndTesting
{
    /// <summary>
    /// Дополнительные математические инструменты
    /// </summary>
    public class MyMath
    {

        /*
        2. Найти корни квадратного уравнения, заданного своими коэффициентами.
        Предусмотреть все возможные случаи (два действительных корня, один корень, нет корней). 
        На вход коэф. a,b,c (тип double).
        */
        /// <summary>
        /// Решает квадратные уравнения вида: 
        /// aX^2 + bX + c
        /// </summary>
        /// <param name="a">Коэффициент при X^2</param>
        /// <param name="b">Коэффициент при X</param>
        /// <param name="c">Свободный коэффициент</param>
        /// <returns>Массив из возможных корней в действительных числах</returns>
        static public double[] SquareEquitationSolver(double a = 0, double b = 0, double c = 0)
        {
            double[] result = new double[0];

            if (a == 0 &&
                b == 0)
                throw new Exception("При таких коэффициентах уравнение не имеет смысла");
            else
                if (a == 0 &&
                    b != 0)
                result = new double[] { -c / b };
            else
            {
                double discriminant = b * b - 4 * a * c;

                if (discriminant > 0)//Два корня
                {
                    result = new double[2];
                    result[0] = (-b + Math.Sqrt(discriminant)) / (2 * a);
                    result[1] = (-b - Math.Sqrt(discriminant)) / (2 * a);
                }
                else if (discriminant == 0)//Корень один
                {
                    result = new double[1];
                    result[0] = -b / (2 * a);
                }
                else if (discriminant < 0) ;//Корней нет
            }            

            return result;
        }
        
    }
}
/*3. Положения ферзей на шахматной доске заданы списком пар (горизонталь, вертикаль). Определить, имеется ли пара ферзей, бьющих друг друга.
        Провести модульное тестирование реализованных функций по критериям черного ящика, по каждому критерию не менее 7 тестов.
        Отправить необходимо код, который должен быть читабельным. Названия переменных, методов, проектов, комментариев в соответствии со стандартами.*/
