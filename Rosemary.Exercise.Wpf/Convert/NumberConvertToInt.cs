using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Data;
using Rosemary.Exercise.Wpf.Model;

namespace Rosemary.Exercise.Wpf.Convert
{
    [ValueConversion(typeof(Number),typeof(int))]
    public class NumberConvertToInt: IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = value.GetType();

            if (value is Number number)
            {
                return (int) number;
            }

            return DependencyProperty.UnsetValue;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var type = value.GetType();

            var tryParse = int.TryParse(value.ToString(),out var number);

            var regex = new Regex(@"[1-5]");
            var match = regex.Match(value.ToString());

            if (tryParse && match.Success)
            {
                return (Number) number;
            }

            return DependencyProperty.UnsetValue;
        }
    }
}
