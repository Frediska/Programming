using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Хранит данные об указанных цветах.
    /// </summary>
    public static class AppColor
    {
        /// <summary>
        /// Цвет некорректного значения.
        /// </summary>
        public static readonly Color ErrorColor = Color.LightPink;

        /// <summary>
        /// Цвет корректного значения.
        /// </summary>
        public static readonly Color CorrectColor = Color.White;
    }
}
