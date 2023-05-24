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
            string FirstName = Console.ReadLine();
            if (rg.IsMatch(FirstName))
            {
                Console.WriteLine("First Name: " + FirstName);
            }
            else
            {
                Console.WriteLine("invalid First Name");
            }
        }
    }
}
