﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Data;
using System.Windows.Media;

namespace ProPharmacyManagerW.ViewModel
{
    class AllTextColor : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                if (System.Convert.ToByte(value) >= 0 && System.Convert.ToByte(value) <= 5)
                {
                    return Brushes.White;
                }
                else
                {
                    return Brushes.Blue;
                }
            }
            catch (Exception e)
            {
                Kernel.Core.SaveException(e);
                return DependencyProperty.UnsetValue;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotSupportedException();
        }

    }
}