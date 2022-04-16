using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programming.Model.Classes
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} must be positive.");
            }
        }

        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value <= 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} must be positive.");
            }
        }

        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the {nameProperty} value must be between {min} and {max}");
            }
        }

        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the {nameProperty} value must be between {min} and {max}");
            }
        }
    }
}
