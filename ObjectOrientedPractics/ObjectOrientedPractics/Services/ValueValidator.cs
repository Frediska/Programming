using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ObjectOrientedPractics.Services
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Проверяет, что число находится в определённом промежутке.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница промежутка.</param>
        /// <param name="max">Правая граница промежутка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится вне промежутка.</exception>
        public static void AssertValueInRange(string nameProperty, double value, double min, double max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the {nameProperty} value must be between {min} and {max}.");
            }
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв русского м английского алфавита.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если строка состоит не только из
        /// букв русского и английского алфавита.</exception>
        public static void AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            if (!Regex.IsMatch(value, @"^[а-яА-Яa-zA-z ]+$"))
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} field should consist only of Russian and English letters");
            }
        }

        /// <summary>
        /// Проверка на то, что строка по длине не больше, чем максимальная возможная длина.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="maxLength">Максимальная длина.</param>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда строка превышает максимально
        /// возможную длину.</exception>
        public static void AssertStringOnLength(string value, int maxLength, string nameProperty)
        {
            if (value.Length > maxLength)
            {
                throw new ArgumentException($"the value of the {nameProperty} more than {maxLength}");
            }
        }

        /// <summary>
        /// Проверяет, является ли число положительным.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(string nameProperty, double value)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} must be positive.");
            }
        }

        /// <summary>
        /// Проверяет, что количество цифр в числе равно заданному.
        /// </summary>
        /// <param name="propertyName">Имя свойства, откуда был вызван метод.</param>
        /// <param name="length">Заданная длина.</param>
        /// <param name="value">Число.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда количество цифр числа не равно заданному.</exception>
        public static void AssertValueLength(string propertyName, int value, int length)
        {
            if (value.ToString().Length != length)
                throw new ArgumentException(
                    $"the number of characters in {propertyName} must be equal to {length}.");
        }

        /// <summary>
        /// Проверяет является ли переданная строка пустой.
        /// </summary>
        /// <param name="value">Строка.</param>
        /// <param name="propertyName">Имя свойства.</param>
        /// <exception cref="ArgumentException">Если строка оказалась пустой.</exception>
        public static void AssertEmptyValue(string value, string propertyName)
        {
            if (value == "")
            {
                throw new ArgumentException($"Строка не может быть пустой в поле {propertyName}");
            }
        }
    }
}
