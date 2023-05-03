using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;

namespace View.Model.Services
{
    public class VisibleConverter : IValueConverter
    {
        /// <summary>
        /// Конвертирует булевое значение
        /// в соотвествующие значение из перечисления <see cref="Visibility"/>.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура</param>
        /// <returns>Значение из перечисления <see cref="Visibility"/>.</returns>
        public object Convert(object value,
                              Type targetType,
                              object parameter,
                              CultureInfo culture)
        {
            var returnVisibilityValue = Visibility.Hidden;

            switch (value)
            {
                case true:
                    {
                        returnVisibilityValue = Visibility.Visible;
                        break;
                    }
                case false:
                    {
                        returnVisibilityValue = Visibility.Hidden;
                        break;
                    }
            }

            return returnVisibilityValue;
        }

        /// <summary>
        /// Конвертирует значение из перечисления <see cref="Visibility"/>
        /// в соотвествующие булевое значение.
        /// </summary>
        /// <param name="value">Значение.</param>
        /// <param name="targetType">Целевой тип.</param>
        /// <param name="parameter">Параметр.</param>
        /// <param name="culture">Региональная культура</param>
        /// <returns>Булевое значение.</returns>
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var returnVisibilityValue = false;

            switch ((Visibility)value)
            {
                case Visibility.Visible:
                    {
                        returnVisibilityValue = true;
                        break;
                    }
                case Visibility.Collapsed:
                    {
                        returnVisibilityValue = false;
                        break;
                    }
                case Visibility.Hidden:
                    {
                        returnVisibilityValue = false;
                        break;
                    }
            }

            return returnVisibilityValue;
        }
    }
}
