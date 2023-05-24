using System.Text.RegularExpressions;

namespace RegexProgram
{
    internal class RegClass
    {
        public void Reg()
        {
            string name = @"^[A-Z]{1}[a-z]{2,}$";
            Regex rg = new Regex(name);
            string email = @"^\w[a-z]{2,}\.\w[a-z]{2,}@[a-z]{1,}\.[a-z]{2}\.[a-z]{2}$";
            Regex re = new Regex(email);

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
            Console.Write("Enter Email Address: ");
            string emailid = Console.ReadLine();

            if (rg.IsMatch(firstName) && rg.IsMatch(lastName))
            {
                if (re.IsMatch(emailid))
                {
                    Console.WriteLine("First Name: " + firstName);
                    Console.WriteLine("Last Name: " + lastName);
                    Console.WriteLine("Email ID: " + emailid);
                }
                else
                {
                    Console.WriteLine("Invalid Email Id");
                }
            }
            else
            {
                Console.WriteLine("Invalid Name");
            }
        }
    }
}
