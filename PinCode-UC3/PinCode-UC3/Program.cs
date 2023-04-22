namespace PinCode_UC3
{
    internal class Program
    {
        public static string pinCode;
        static void Main(string[] args)
        {
            Console.WriteLine("*****Welcome to the Pin Code and Email Validator*****");
            Console.WriteLine("--------------------------------------------------------\n");
            
            PincodeValidator pinCodeRegex = new PincodeValidator();
            bool validationKey;
            Console.WriteLine("\nEnter the pin code : ");
            pinCode = Console.ReadLine();
            validationKey = pinCodeRegex.maximumDigitValidator(pinCode);

            Console.WriteLine(validationKey ? "\nThe Pin Code {0} is Valid." : "\nThe Pin Code {0} is Not Valid.", pinCode);
        }
    }
}