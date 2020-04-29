using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyTypesDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            PersonModel person = new PersonModel("Smith");

            person.FirstName = "Bob";
            //person.LastName = "Smith";
            person.Age = 50;
            person.SSN = "123-45-6789";

            Console.WriteLine($"{ person.FullName } is { person.Age } years old.");
            Console.WriteLine($"Your SSN is { person.SSN }");

            Console.ReadLine();
        }
    }
}


//ProTip: In classes, use auto prop by default.  Move to full properties when needed.

//Homework: Create a class that has properties for street address, city state and zip code.  Then add a FullAddress property that is read-only.