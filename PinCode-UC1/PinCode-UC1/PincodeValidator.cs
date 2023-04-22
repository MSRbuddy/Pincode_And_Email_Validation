using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PinCode_UC1
{
    public class PincodeValidator
    {
        public static string PIN_REGEXUC1 = "^[0-9]{6}$";

        public bool maximumDigitValidator(string pinCode)
        {
            return Regex.IsMatch(pinCode, PIN_REGEXUC1);
        }
    }
}
