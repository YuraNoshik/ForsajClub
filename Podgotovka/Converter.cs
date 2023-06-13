using System;
using System.Globalization;
using System.Windows.Data;

namespace WpfAppVetclinic.Converters
{

    public class RoundConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Округление до целого значения
            return Math.Round((double)value);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

