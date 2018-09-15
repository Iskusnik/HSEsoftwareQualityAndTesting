using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSESoftwareQualityAndTesting
{
    /// <summary>
    /// Решение различных задач с шахматами
    /// </summary>
    public class ChessQuestions
    {
        /// <summary>
        /// Определяет, имеется ли пара ферзей, бьющих друг друга.
        /// </summary>
        /// <param name="queens">Положения ферзей на шахматной доске заданые списком пар (горизонталь, вертикаль).</param>
        /// <returns> True - имеется. False - не имеется. </returns>
        public static bool AreAnyQueensHitEachOther(List<ChessUnitData> queens)
        {
            bool result = false;

            //0 - клетка пуста
            //1 - клетка под ударом ферзя
            //2 - клетка занята ферзём

            //Отсчёт клеток от 1 до 8
            int[,] chessBoard = new int[9, 9];



            foreach (var queen in queens)
            {
                int cellInfo = chessBoard[queen.X, queen.Y];

                if (cellInfo == 2)
                    throw new Exception("Клетка занята - ферзь не может стоять здесь");
                else if (cellInfo == 1)
                    result = true;          //Если пара найдена, то надо дорасставить ферзей, чтобы исключить нахождение двух ферзей в одной клетке
                else if (cellInfo == 0)
                {

                    //Заполняем битые поля единицами

                    //Вертикаль
                    for (int y = 1; y < 9; y++)
                        chessBoard[queen.X, y] = 1;

                    //Горизонталь
                    for (int x = 1; x < 9; x++)
                        chessBoard[x, queen.Y] = 1;

                    //Диагонали

                    //Влево-вниз
                    for (int x = queen.X, y = queen.Y; x > 0 && y > 0; x--, y--)
                        chessBoard[x, y] = 1;

                    //Влево-вверх
                    for (int x = queen.X, y = queen.Y; x < 9 && y > 0; x++, y--)
                        chessBoard[x, y] = 1;

                    //Вправо-вниз
                    for (int x = queen.X, y = queen.Y; x > 0 && y < 9; x--, y++)
                        chessBoard[x, y] = 1;

                    //Вправо-вверх
                    for (int x = queen.X, y = queen.Y; x < 9 && y < 9; x++, y++)
                        chessBoard[x, y] = 1;

                    //Отмечаем положение ферзя
                    chessBoard[queen.X, queen.Y] = 2;
                }
            }
            return result;
        }

    }
}
