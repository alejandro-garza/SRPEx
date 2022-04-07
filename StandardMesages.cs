using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Homework2
{
    public class StandardMessages
    {
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            Console.ReadLine();
        }

        public static void DisplayValidationError(string fieldName)
        {
            Console.WriteLine($"You did not give a valid { fieldName }!");
        }
    }
}