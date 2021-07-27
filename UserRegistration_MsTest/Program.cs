using System;
using System.Text.RegularExpressions;

namespace UserRegistration_MsTest
{
    public class Program
    {
        public static string REGEX_PATTERN = "^[A-Z]{1}[a-zA-Z]{2,}$";
        public static Program p = new Program();
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome_To_UserRegistration_RegeEx");
            Console.Write("Enter First Name: ");
            string FirstName = Console.ReadLine();
            Console.WriteLine(p.FirstNameVal(FirstName));
        }
        public bool FirstNameVal(string fname)
        {
            Regex rg = new Regex(REGEX_PATTERN);
            return rg.IsMatch(fname); ;
        }
    }
}
