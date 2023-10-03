using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Common.CustomValidations
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
    public class DateRangeAttribute : ValidationAttribute
    {
        private readonly DateTime _minDate;
        private readonly DateTime _maxDate;

        public DateRangeAttribute(string minDate, string maxDate)
        {
            _minDate = DateTime.Parse(minDate);
            _maxDate = DateTime.Parse(maxDate);
        }
        public override bool IsValid(object value)
        {
            if (value is DateTime dateValue)
            {
                return dateValue >= _minDate && dateValue <= _maxDate;
            }

            return false;
        }

        public override string FormatErrorMessage(string name)
        {
            return $"{name} must be between {_minDate:yyyy-MM-dd} and {_maxDate:yyyy-MM-dd}.";
        }
    }
}
