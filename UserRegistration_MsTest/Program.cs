﻿using System;
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
            Console.Write("Enter Last Name: ");
            string LastName = Console.ReadLine();
            Console.WriteLine(p.LastNameVal(LastName));
            Console.Write("Enter E-mail : ");
            string Email = Console.ReadLine();
            Console.WriteLine(p.EmailValidation(Email));
        }
        public bool FirstNameVal(string first_name)
        {
            Regex rg = new Regex(REGEX_PATTERN);
            return rg.IsMatch(first_name); ;
        }
        public bool LastNameVal(string last_name)
        {
            Regex rg = new Regex(REGEX_PATTERN);
            bool validate = rg.IsMatch(last_name);
            return validate;
        }
        public bool EmailValidation(string email)
        {
            string EMAIL_PATTERN = "^[a-zA-Z0-9]+[.(a-zA-Z0-9)]*(\\@)[a-zA-Z0-9]+(\\.)[a-z]{2,3}[.(a-z)]*$";
            Regex rg = new Regex(EMAIL_PATTERN);
            bool validate = rg.IsMatch(email);
            return validate;
        }
    }
}
