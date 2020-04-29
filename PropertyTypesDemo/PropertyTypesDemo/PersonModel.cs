using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypesDemo
{
    public class PersonModel
    {
        public string FirstName { private get; set; } //anyone can set this prop but can only be read within this class
        public string LastName { get; private set; } //anyone can get this property but it can only be set within this class (Ex: readOnly)

        private string _password;

        public string Password //You can leave the set to allow the property to be assigned but also remove the get to prevent it from being read (again, readOnly)
        {
            set { _password = value; }
        }

        public string FullName //This example provides a get, concatenated from two other properties.  
                               //Note that even though the FirstName property has a private get, the FullName property can read it.
                               //Doesn't NEED a backing field
                               //Apparently, this one is very useful
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }

        public PersonModel() //Example of overloading.  Using this in conjunction with the one below allows us to call it with or without the lastName
        {

        }

        public PersonModel(string lastName) //Constructor - In this case, I am passing in the last name of the user when the class in instantiated.  Note that the set is commented out in Main.
        {
            LastName = lastName;
        }

        //public int Age { get; set; }
        private int _age;
        public int Age
        {
            get 
            { 
                return _age;
            }
            
            set 
            {
                if (value >= 0 && value < 126)
                {
                    _age = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("value", "Age is not valid.");
                }
            }
        }

        //public string SSN { get; set; } //SSN: 123-45-6789
        private string _ssn;
        public string SSN
        {
            get 
            {
                string output = "***-**-" + _ssn.Substring(_ssn.Length - 4);
                return output;
            }
            set 
            {
                _ssn = value;
            }
        }


    }
}
