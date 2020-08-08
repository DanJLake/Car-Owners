using System;
using System.Collections.Generic;
using System.Text;

namespace Car_Owners.People
{
    class Car
    {
        //Declare object properties
        public string make { get; set; }
        public string model { get; set; }
        public int yearRegistered { get; set; }
        public string licenseNumber { get; set; }
        private Person owner;

        //Object constructor method, with arguments
        public Car(string carMake, string carModel, int carYearRegistered, string carLicenseNumber, Person carOwner)
        {
            //Set arguments to object properties
            make = carMake;
            model = carModel;
            yearRegistered = carYearRegistered;
            licenseNumber = carLicenseNumber;
            owner = carOwner;
        }

        public void declareCar()
        {
            Console.WriteLine("Make: " + make);
            Console.WriteLine("Model: " + model);
            Console.WriteLine("Year Registered: " + yearRegistered);
            Console.WriteLine("License Number: " + licenseNumber);
        }

    }
}
