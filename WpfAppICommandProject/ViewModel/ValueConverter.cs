using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;

namespace MVVMwithWPFProject.ViewModel {
    /// <summary>
    /// Converts the days, that are int, to string format
    /// </summary>
    public class ValueConverterIntDaysToString : IValueConverter {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture) {
            int inputAsInt = int.Parse(value.ToString());
            if (inputAsInt > 0) {
                return inputAsInt.ToString() + " days";
            } else {
                return inputAsInt.ToString() + " day";
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) {
            var input = value as string;
            int output;
            if (int.TryParse(input, out output))
                return output;
            else
                return DependencyProperty.UnsetValue;
        }
    }
}
