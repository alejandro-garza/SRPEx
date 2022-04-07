using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Homework2
{
    public class AccountGenerator
    {
        public static void CreateAccount(PersonDataCapture user)
        {
            // Create a username for the person
            Console.WriteLine($"Your username is { user.Firstname.Substring(0, 1) } { user.LastName }");
        }

    }
}