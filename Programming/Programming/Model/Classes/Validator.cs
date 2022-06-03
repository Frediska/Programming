using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Programming.Model.Classes
{
    /// <summary>
    /// Предоставляет методы для проверки входных данных.
    /// </summary>
    public static class Validator
    {
        /// <summary>
        /// Проверяет, является ли число положительным.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <exception cref="ArgumentException">Выбрасывается, когда число меньше или равно нулю.</exception>
        public static void AssertOnPositiveValue(string nameProperty, int value)
        {
            if (value < 0)
            {
                throw new ArgumentException(
                    $"the value of the {nameProperty} must be positive.");
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
        /// Проверяет, что число находится в определённом промежутке.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Число.</param>
        /// <param name="min">Левая граница промежутка.</param>
        /// <param name="max">Правая граница промежутка.</param>
        /// <exception cref="ArgumentException">Выбрасывается, если число находится вне промежутка.</exception>
        public static void AssertValueInRange(string nameProperty, int value, int min, int max)
        {
            if (value < min || value > max)
            {
                throw new ArgumentException(
                    $"the {nameProperty} value must be between {min} and {max}");
            }
        }

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
                    $"the {nameProperty} value must be between {min} and {max}");
            }
        }

        /// <summary>
        /// Проверяет, что строка состоит только из букв английского алфавита.
        /// </summary>
        /// <param name="nameProperty">Имя свойства, откуда был вызван метод.</param>
        /// <param name="value">Строка.</param>
        /// <exception cref="System.ArgumentException">Выбрасывается, если строка состоит не только из
        /// букв английского алфавита.</exception>
        public static void AssertStringContainsOnlyLetters(string nameProperty, string value)
        {
            if (!Regex.IsMatch(value, @"^[a-zA-Z]+$"))
            {
                throw new System.ArgumentException(
                    $"the value of the {nameProperty} field should consist only of English letters.");
            }
        }
    }
}
