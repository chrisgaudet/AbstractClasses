using System;
using System.Collections.Generic;

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

            // Create a list of Vehicle called vehicles

            var vehicles = new List<Vehicle>();

            /*
             * Create 4 instances: 1 Car, 1 Motorcycle, and then 2 instances of type Vehicle (use explicit typing) but use constuctors from derived classes
             * 
             * 
             * Set the properties values with object initializer syntax
             */
            Car focus = new Car() { HasTrunk = true, Make = "Ford", Model = "Focus", Year = 2013 };

            Motorcycle motorcycle = new Motorcycle() {  HasSideCar = true, Make = "Harley Davidson", Model = "Chopper", Year = 1978 };




            Vehicle sedan = new Car() { HasTrunk = true, Make = "Toyota", Model = "Sienna", Year = 2024 };
            Vehicle import = new Car() { HasTrunk = true, Make = "Nissan", Model = "Skyline", Year = 1999 };


            /*
             * Add the 4 vehicles to the list
             * Using a foreach loop iterate through the list and display each of the properties
             */

            vehicles.Add(focus);
            vehicles.Add(sedan);
            vehicles.Add(import);
            vehicles.Add(motorcycle);

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine($"Make {vehicle.Make} Model {vehicle.Model} Year {vehicle.Year}");
                vehicle.DriveAbstract();
                Console.WriteLine("");
            }

            // Call each of the drive methods for one car and one motorcycle

            #endregion
            Console.ReadLine();
        }
    }
}
