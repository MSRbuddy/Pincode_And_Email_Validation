using System.Text.RegularExpressions;

namespace Email_UC1
{
    internal class EmailValidator
    {
        public static string EMAIL_REGEX = "^[0-9A-Za-z]$";
        public bool emailIDValidator(string emailId)
        {
            return Regex.IsMatch(emailId, EMAIL_REGEX);
        }
    }
}
