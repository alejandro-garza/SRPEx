using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using System.Threading.Tasks;

namespace Homework2
{
    public class PersonValidator
    {
        public static bool Validate(Person person)
        {
            // Check to be sure the first and last names are valid
            if (string.IsNullOrWhiteSpace(person.FirstName))
            {
                StandardMessages.DisplayValidationError("first name");             
                return false;
            }
            
            if (string.IsNullOrWhiteSpace(person.LastName))
            {
                StandardMessages.DisplayValidationError("last name");
                return false;
            }

            return true;
        }
    }
} 