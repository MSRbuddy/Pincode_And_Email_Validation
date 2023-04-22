using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PinCode_UC4
{
    internal class PincodeValidator
    {
        public static string PIN_REGEXUC4 = "^[0-9]{3}[ ]?[0-9]{3}$";
        
        public bool maximumDigitValidator(string pinCode)
        {
            return Regex.IsMatch(pinCode, PIN_REGEXUC4);
        }
    }
}
