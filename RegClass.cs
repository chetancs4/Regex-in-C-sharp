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
            string phone = @"\d{2}\s\d{10}$";
            Regex rp = new Regex(phone);

            Console.Write("Enter First Name: ");
            string firstName = Console.ReadLine();
            Console.Write("Enter Last Name: ");
            string lastName = Console.ReadLine();
           

            while (true)
            {
                if (rg.IsMatch(firstName) && rg.IsMatch(lastName))
                {
                    Console.Write("Enter Email Address: ");
                    string emailid = Console.ReadLine();
                    if (re.IsMatch(emailid))
                    {
                        Console.Write("Enter Phone number: ");
                        string PhoneNumber = Console.ReadLine();
                        if (rp.IsMatch(PhoneNumber))
                        {
                            Console.WriteLine("User Details: ");
                            Console.WriteLine("First Name: " + firstName);
                            Console.WriteLine("Last Name: " + lastName);
                            Console.WriteLine("Email ID: " + emailid);
                            Console.WriteLine("Phone Number: " + PhoneNumber);
                        }
                        else
                        {
                            Console.WriteLine("Invalid Phone Number");
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("Invalid Email Id");
                        break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid Name");
                    break;
                }
            }
        }
    }
}
