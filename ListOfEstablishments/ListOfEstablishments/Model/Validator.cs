using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ListOfEstablishments.Model
{
    public static class Validator
    {
        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} must be positive.");
            }
        }

        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the {nameProperty} value must be between {min} and {max}.");
            }
        }

        public static void AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            if (!Regex.IsMatch(value, @"^[а-яА-Яa-zA-z ]+$"))
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should consist only of Russian and English letters");
            }
        }

        public static void NoMoreThan(string value, int maxLength, string nameProperty)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"the value of the {nameProperty} more than {maxLength}");
            }
        }
    }
}
