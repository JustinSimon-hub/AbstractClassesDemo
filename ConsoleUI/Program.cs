using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * Todo: Follow all comments!! 
             * Double click on the region (gray box) to view all comments
             */

            #region Vehicles

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties: Year, Make, and Model
             * Set the defaults of the properties to something generic in the Vehicle class
             * Vehicle class shall have an abstract method called DriveAbstract with no implementation.
             * Vehicle class shall have a virtual method called DriveVirtual with a base implementation.
             */

            /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distinct property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
            */
            List<Vehicle> vehicles = new List<Vehicle>();

            // Create a list of Vehicle called vehicles
            Vehicle car1 = new Car()
            { Year = 2020, Make = "Toyota", Model = "Camry", hasTrunk = true, numberOfDoors = 4

            };

            Vehicle car2 = new Car()
            { Year = 2018, Make = "Honda", Model = "Civic", hasTrunk = true, numberOfDoors = 2

            };

            Vehicle motorcycle1 = new Motorcycle()
            { Year = 2021, Make = "Harley-Davidson", Model = "Street 750", hasTwoWheels = true, motorcycleBrand = "Harley-Davidson"
            };
            Vehicle motorcycle2 = new Motorcycle()
            { Year = 2019, Make = "Yamaha", Model = "MT-07", hasTwoWheels = true, motorcycleBrand = "Yamaha"
            };


            vehicles.Add(car1);
            vehicles.Add(car2);
            vehicles.Add(motorcycle1);
            vehicles.Add(motorcycle2);
            foreach(var vehicle in vehicles)
            {
                Console.WriteLine($"Year: {vehicle.Year}, Make: {vehicle.Make}, Model: {vehicle.Model}");
                if(vehicle is Car car)
                {
                    Console.WriteLine($"Has Trunk: {car.hasTrunk}, Number of Doors: {car.numberOfDoors}");
                    car.DriveAbstract();
                }
                else if(vehicle is Motorcycle motorcycle)
                {
                    Console.WriteLine($"Has Two Wheels: {motorcycle.hasTwoWheels}, Motorcycle Brand: {motorcycle.motorcycleBrand}");
                    motorcycle.DriveAbstract();
                    motorcycle.DriveVirtual();
                }
            }
            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * Set the properties values with object initializer syntax
             */

            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            // Call each of the drive methods for one car and one motorcycle

            #endregion            
            Console.ReadLine();
        }
    }
}