using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Хранит данные об используемых цветах.
    /// </summary>
    public static class AppColors
    {
        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        public static System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static System.Drawing.Color CorrectColor = System.Drawing.Color.White;

        /// <summary>
        /// Цвет пересекающихся фигур.
        /// </summary>
        public static System.Drawing.Color CollisionColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        /// <summary>
        /// Цвет непересекающихся фигур.
        /// </summary>
        public static System.Drawing.Color NotCollisionColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
    }
}
