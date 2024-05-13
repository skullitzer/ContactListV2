using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ContactListV2.Business
{
    public static class Validator
    {
        public static bool ValidateInt(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, "^[0-9]+$");
        }

        public static bool ValidateFloat(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, "[+-]?([0-9]+([.][0-9]*)?|[.][0-9]+)");
        }

        public static bool ValidateEmail(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, @"^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");
        }

        public static bool ValidatePhoneNumber(string inputToCheck)
        {
            return Regex.IsMatch(inputToCheck, @"^\(?(\d{3})\)?[ -]?(\d{3})[ -]?(\d{4})$");
        }
    }
}
