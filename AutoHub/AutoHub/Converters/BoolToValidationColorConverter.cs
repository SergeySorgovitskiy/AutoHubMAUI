using System.Globalization;
using Microsoft.Maui.Controls;

namespace AutoHub.Converters
{
    public class BoolToValidationColorConverter : IValueConverter
    {
        public Color ValidColor { get; set; } = Colors.Green;
        public Color InvalidColor { get; set; } = Colors.Gray;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is bool isValid)
            {
                return isValid ? ValidColor : InvalidColor;
            }

            return InvalidColor;
        }
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}