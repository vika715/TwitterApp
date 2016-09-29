using System;
using System.Globalization;
using Xamarin.Forms;

namespace App.Converters
{
    public class StringToUriConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value != null)
            {
                var uri = (string)value;
                return new Uri(uri);
            }
            else
                return value;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return ((Uri)value).ToString();
        }
    }
}
