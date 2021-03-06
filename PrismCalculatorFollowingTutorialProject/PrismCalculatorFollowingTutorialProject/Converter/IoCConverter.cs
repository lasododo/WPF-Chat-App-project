﻿using Ninject;
using System;
using System.Diagnostics;
using System.Globalization;

namespace PrismCalculatorFollowingTutorialProject
{
    public class IoCConverter : BaseValueConverter<IoCConverter>
    {

        public override object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Find the appropriate page
            switch ((string)parameter)
            {
                case nameof(ApplicationViewModel):
                    return IoCContainer.Get<ApplicationViewModel>();

                default:
                    Debugger.Break();
                    return null;
            }
        }

        public override object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}