using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HSESoftwareQualityAndTesting
{
    /// <summary>
    /// Информация о фигурах на доске 
    /// </summary>
    /// <remarks>
    /// (1,1) соответствует a1
    /// (1,2) соответствует b1
    /// </remarks>
    public class ChessUnitData
    {
        private int x;
        public int X
        {
            get { return x; }
            set
            {
                if (value > 8 || value < 1)
                    throw new Exception("Фигура за границами доски");
                else
                    x = value;
            }
        }

        private int y;
        public int Y
        {
            get { return y; }
            set
            {
                if (value > 8 || value < 1)
                    throw new Exception("Фигура за границами доски");
                else
                    y = value;
            }
        }
        public ChessUnitData(int x, int y)
        {
            X = x;
            Y = y;
        }
        /*
         * Перевод к представлению координат в шахматах
        public override string ToString()
        {
            return (char.ConvertFromUtf32(char.ConvertToUtf32('a','0') + y - 1).ToString() + x.ToString());
        }
        */
    }
}
