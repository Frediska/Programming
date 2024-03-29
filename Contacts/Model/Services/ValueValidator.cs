﻿using System.ComponentModel.DataAnnotations;
using System.Text.RegularExpressions;

namespace Model.Services
{
    /// <summary>
    /// Хранит реализацию методов, предназначенных для валидации.
    /// </summary>
    public static class ValueValidator
    {
        /// <summary>
        /// Валидация номера телефона.
        /// </summary>
        /// <param name="phone">Номер телефона.</param>
        /// <returns>Возвращает результат валидации <see cref="ValidationResult" />.</returns>
        public static ValidationResult ValidatePhone(string phone)
        {
            var pattern = @"^((8|\+7)[\- ]?)?(\(?\d{3}\)?[\- ]?)?[\d\- ]{7,10}$";
            if (Regex.IsMatch(phone, pattern))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult(
                "Phone Number can contains only digits and symbols '+()- '. Example: +7 (999) 111-22-33.");
        }

        /// <summary>
        /// Валидация адреса электронной почты.
        /// </summary>
        /// <param name="email">Электронная почта.</param>
        /// <returns>Возвращает результат валидации <see cref="ValidationResult" />.</returns>
        public static ValidationResult ValidateEmail(string email)
        {
            var pattern = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            if (Regex.IsMatch(email, pattern))
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("The email is not correctly. Example: abcdef@mail.ru");
        }

        /// <summary>
        /// Валидация имени.
        /// </summary>
        /// <param name="name">Имя.</param>
        /// <returns>Возвращает результат валидации <see cref="ValidationResult" />.</returns>
        public static ValidationResult ValidateName(string name)
        {
            if (name.Length > 0 && name.Length <= 100)
            {
                return ValidationResult.Success;
            }

            return new ValidationResult("The name is not correctly.");
        }
    }
}
