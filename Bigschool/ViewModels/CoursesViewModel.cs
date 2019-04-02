using Bigschool.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Globalization;
using System.Linq;
using System.Web;

namespace Bigschool.ViewModels
{
    public class CoursesViewModel
    {
        public string Place { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0},{1}", Date, Time));

        }
    }
    public class ValidTime : ValidationAttribute
    {
        public override bool IsValid(object value)
        {
            DateTime dateTime;
            var isValid =DateTime.TryParseExact(Convert.ToString(value),"HH:mm",CultureInfo.CurrentCulture,DateTimeStyles.None,out dateTime);
            return isValid;
        }
    }
}