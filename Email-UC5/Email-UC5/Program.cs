namespace Email_UC5
{
    internal class Program
    {
        public static string emailId;

        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to the Pin Code and Email Validator*****");
            Console.WriteLine("---------------------------------------------------------\n");

            EmailValidator EmailRegex = new EmailValidator();
            bool validationKey;
            Console.WriteLine("\nEnter the Email-ID : ");
            emailId = Console.ReadLine();
            validationKey = EmailRegex.emailIDValidator(emailId);

            Console.WriteLine(validationKey ? "\nThe Email Id {0} is Valid." : "\nThe Email Id {0} is Not Valid.", emailId);
        }
    }
}