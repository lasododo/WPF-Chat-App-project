using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Globalization;

namespace PrismCalculatorFollowingTutorialProject
{
    class SentByMeAlignmentConverter : BaseValueConverter<SentByMeAlignmentConverter>
    {
        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
           return (bool)value ? HorizontalAlignment.Right : HorizontalAlignment.Left;
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
