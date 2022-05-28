using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class AppColors
    {
        public static System.Drawing.Color ErrorColor = System.Drawing.Color.LightPink;

        public static System.Drawing.Color CorrectColor = System.Drawing.Color.White;

        public static System.Drawing.Color CollisionColor = System.Drawing.Color.FromArgb(127, 255, 127, 127);

        public static System.Drawing.Color NotCollisionColor = System.Drawing.Color.FromArgb(127, 127, 255, 127);
    }
}
