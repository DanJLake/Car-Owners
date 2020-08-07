using System;
using System.Collections.Generic;
using System.Linq;
//Add namespace created for the 'People' folder
using Car_Owners.People;

namespace Car_Owners
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare variables
            bool exit = false;
            int choice = 0;

            //Create list of people
            List<Person> peopleList = new List<Person>();

            while (exit == false)
            {
                Console.WriteLine("Select an option by entering the corresponding number:");
                Console.WriteLine("1. Add a new person");
                Console.WriteLine("2. Give person a car");
                Console.WriteLine("3. Check person's car");
                Console.WriteLine("4. Exit");

                //Keep asking for user input while the user's choice is not between 1 and 4
                while (choice > 4 || choice < 1)
                {
                    //Error catching - make sure the value entered can be converted to an integer
                    try
                    {
                        choice = Convert.ToInt32(Console.ReadLine());
                    }
                    catch
                    {
                        Console.WriteLine("Choice must be a (whole) number.");
                    }
                    //If the value is an integer, make sure it is less than or equal to 4 OR greater than or equal to 1
                    if(choice >= 4 || choice <= 1)
                    {
                        Console.WriteLine("Enter a number between 1 and 4.");
                    }

                //Exiting the while loop should mean the choice is now an integer between 1 and 4
                }

                //Switch/select case statement to determine what to do based on user input
                switch(choice){
                    case 1:
                        Console.WriteLine("\nAdd a new person selected");

                        //Get person details from user
                        Console.WriteLine("\nEnter the person's first name:");
                        string personFirstName = Console.ReadLine();

                        Console.WriteLine("\nEnter the person's last name:");
                        string personLastName = Console.ReadLine();

                        Console.WriteLine("\nEnter the person's age:");
                        int personAge = 0;
                        //Loop continues until break
                        while (true)
                        {
                            //Int conversion error catching
                            try
                            {
                                personAge = Convert.ToInt32(Console.ReadLine());
                                break;
                            }
                            catch
                            {
                                Console.WriteLine("Age must be a (whole) number, enter a whole number:");
                            }
                        }

                        //Add new person
                        Person newPerson = new Person(personFirstName, personLastName, personAge);

                        //Add person to peopleList
                        peopleList.Add(newPerson);

                        Console.WriteLine("\nPerson added with the following details:");
                        //Confirmation of details
                        newPerson.declarePerson();

                        break;

                    case 2:
                        Console.WriteLine("\nGive a person a car selected");

                        //Check if peopleList is empty
                        if (!peopleList.Any())
                        {
                            Console.WriteLine("\nAdd someone before assigning any cars!");
                        }
                        //If list contains people
                        else
                        {
                            Console.WriteLine("\nEnter the person who you want to assign a car's first name:");
                            string carAssignFirstName = Console.ReadLine();
                            Console.WriteLine("\nEnter the person who you want to assign a car's last name:");
                            string carAssignLastName = Console.ReadLine();

                            //Check each person in the list
                            foreach(Person carOwner in peopleList)
                            {
                                //Convert names to lower case and check if they match any existing person and check the person doesn't have a car
                                if (carAssignFirstName.ToLower() == carOwner.getFirstName().ToLower() && carAssignLastName.ToLower() == carOwner.getLastName().ToLower() && carOwner.getHasCar() == false)
                                {
                                    //Get car details
                                    string carMake;
                                    string carModel;
                                    int carYearRegistered;
                                    string carLicenseNumber;

                                    Console.WriteLine("\nEnter the car make:");
                                    carMake = Console.ReadLine();

                                    Console.WriteLine("\nEnter the car model:");
                                    carModel = Console.ReadLine();

                                    Console.WriteLine("\nWhat year was the car registered?:");
                                    while (true)
                                    {
                                        try
                                        {
                                            carYearRegistered = Convert.ToInt32(Console.ReadLine());
                                            break;
                                        }
                                        catch
                                        {
                                            Console.WriteLine("Please enter the year as a whole number:");
                                        }
                                    }

                                    Console.WriteLine("Enter the car's license number:");
                                    carLicenseNumber = Console.ReadLine();

                                    Car newCar = new Car(carMake, carModel, carYearRegistered, carLicenseNumber, carOwner);
                                    carOwner.assignCar();
                                    carOwner.ownedCar = newCar;
                                }
                                //If the person is already assigned a car
                                else if(carOwner.getHasCar() == true)
                                {
                                    Console.WriteLine("\nPerson already has a car!");
                                }
                                //If the person isnt found on the list
                                else
                                {
                                    Console.WriteLine("\nPerson not found! Make sure you have added the person to the list and try again.");
                                    break;
                                }
                            }
                        }

                        break;

                    case 3:
                        Console.WriteLine("\nCheck a person's car selected");

                        //Check if peopleList is empty
                        if (!peopleList.Any())
                        {
                            Console.WriteLine("\nAdd someone before assigning any cars!");
                        }
                        //If list contains people
                        else
                        {
                            Console.WriteLine("\nEnter the person who you want to check's first name:");
                            string carCheckFirstName = Console.ReadLine();
                            Console.WriteLine("\nEnter the person who you want to check's last name:");
                            string carCheckLastName = Console.ReadLine();

                            //Check each person in the list
                            foreach (Person carOwner in peopleList)
                            {
                                //Convert names to lower case and check if they match any existing person and check if the person has a car
                                if (carCheckFirstName.ToLower() == carOwner.getFirstName().ToLower() && carCheckLastName.ToLower() == carOwner.getLastName().ToLower() && carOwner.getHasCar() == true)
                                {
                                    Console.WriteLine("\n" + carCheckFirstName + " " + carCheckLastName + "'s car:");
                                    carOwner.ownedCar.declareCar();
                                }
                                //If the person doesn't have a car
                                else if (carOwner.getHasCar() == false)
                                {
                                    Console.WriteLine("\nPerson doesn't have a car!");
                                }
                                //If the person isn't on the list
                                else
                                {
                                    Console.WriteLine("\nPerson not found! Make sure you have added the person to the list and try again.");
                                }
                            }
                        }

                        break;

                    case 4:
                        Console.WriteLine("\nExiting...");
                        exit = true;
                        break;
                }

                Console.WriteLine("");
                //Reset choice to avoid infinite loop
                choice = 0;
            }
        }
    }
}
