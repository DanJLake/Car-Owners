using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Owners.People
{
    class Person
    {
        //Declare object properties
        private string firstName;
        private string lastName;
        private int age;
        private bool hasCar = false;
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

        public string getFirstName()
        {
            return firstName;
        }

        public string getLastName()
        {
            return lastName;
        }

        public bool getHasCar()
        {
            return hasCar;
        }

        public void assignCar()
        {
            hasCar = true;
        }
    }
}
