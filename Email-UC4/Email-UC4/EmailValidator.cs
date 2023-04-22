using System.Text.RegularExpressions;

namespace Email_UC4
{
    internal class EmailValidator
    {
        public static string EMAIL_REGEX = "^[0-9A-Za-z]+([+-_.][a-zA-Z]+)*[@][0-9A-Za-z]+[.][0-9A-Za-z]{2,3}$";
       
        public bool emailIDValidator(string emailId)
        {
            return Regex.IsMatch(emailId, EMAIL_REGEX);
        }
    }
}
