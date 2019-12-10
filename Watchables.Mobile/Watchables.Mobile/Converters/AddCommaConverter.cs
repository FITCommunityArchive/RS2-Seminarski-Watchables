using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using Xamarin.Forms;

namespace Watchables.Mobile.Converters
{
    public class AddCommaConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            var text = value as string;
            return text + ",";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            var text = value as string;
            return text + ",";
        }
    }
}
