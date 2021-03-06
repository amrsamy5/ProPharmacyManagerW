﻿// <copyright>
//      This work is licensed under the
//      Creative Commons Attribution-NonCommercial-ShareAlike 4.0 International License.
//      To view a copy of this license, visit
//      http://creativecommons.org/licenses/by-nc-sa/4.0/.
// </copyright>
using System;
using System.Windows;
using System.Windows.Data;

namespace ProPharmacyManagerW.ViewModel
{
    /// <summary>
    /// Checkboxs status in all drugs page
    /// </summary>
    public class AllEX : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            try
            {
                var d1 = DateTime.Now.Date;
                var d2 = System.Convert.ToDateTime(value).Date;
                var dt = (d1 - d2).TotalDays;
                if (dt > -5)
                {
                    return "#BF263C";
                }
                else if (dt > -15 && dt < -6)
                {
                    return "#DA4453";
                }
                else if (dt > -30 && dt < -16)
                {
                    return "#F6BB42";
                }
                else if (dt > -50 && dt < -31)
                {
                    return "#E0C341";
                }
                else if (dt > -60 && dt < -51)
                {
                    return "#8CC152";
                }
                else
                {
                    return DependencyProperty.UnsetValue;
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