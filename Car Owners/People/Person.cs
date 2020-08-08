using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Owners.People
{
    class Person
    {
        //Declare object properties
        public string firstName { get; set; }
        public string lastName { get; set; }
        public int age { get; set; }
        public bool hasCar { get; set; } = false;

        public Car ownedCar;

        //Object constructor method, with arguments
        public Person(string personFirstName, string personLastName, int personAge)
        {
            //Set arguments to object properties
            firstName = personFirstName;
            lastName = personLastName;
            age = personAge;
        }

        public void declarePerson()
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Person Age: " + age.ToString());
            Console.WriteLine("Car Owner: " + hasCar.ToString());
        }

        public void assignCar()
        {
            hasCar = true;
        }
    }
}
