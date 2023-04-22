using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PinCode_UC3
{
    internal class PincodeValidator
    {
        public static string PIN_REGEXUC3 = "^((?![a-zA-Z#$%&'*+/=?^_`{|}~-])[0-9](?![a-zA-Z#$%&'*+/=?^_`{|}~-])){6}$";    

        public bool maximumDigitValidator(string pinCode)
        {
            return Regex.IsMatch(pinCode, PIN_REGEXUC3);
        }
    }
}
