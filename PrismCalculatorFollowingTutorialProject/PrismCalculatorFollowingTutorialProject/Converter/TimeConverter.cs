using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Globalization;

namespace PrismCalculatorFollowingTutorialProject
{
    class TimeConverter : BaseValueConverter<TimeConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (((DateTimeOffset)value).Minute < 10)
                return ((DateTimeOffset)value).Hour + ":0" + ((DateTimeOffset)value).Minute;
            return ((DateTimeOffset)value).Hour + ":" + ((DateTimeOffset)value).Minute;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}