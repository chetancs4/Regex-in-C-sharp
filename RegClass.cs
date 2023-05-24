using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegexProgram
{
    internal class RegClass
    {
        public void Reg() 
        {
            string name = @"^[A-Z]{1}[a-z]{2,}$";
            Regex rg = new Regex(name);

            Console.WriteLine("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name: ");
            string lastName = Console.ReadLine();

            if (rg.IsMatch(firstName) && rg.IsMatch(lastName))
            {
                Console.WriteLine("First Name: " + firstName);
                Console.WriteLine("Last Name: " + lastName);
            }
            else
            {
                Console.WriteLine("invalid Name");
            }

             
        }
    }
}
