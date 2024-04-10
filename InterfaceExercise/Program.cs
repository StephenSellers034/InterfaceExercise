using System;
using System.Collections.Generic;
namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany done

            //Create 3 classes called Car , Truck , & SUV done

            //In your IVehicle:

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: public int NumberOfWheels { get; set; } done
             */


            //In ICompany: 

            /* Create 2 members that are specific to each every company
             * regardless of vehicle type.
             * Example: public string Logo { get; set; } done
             */

            //In each of your Car, Truck, and SUV classes

            /* Create 2 members that are specific to each class done
             * Example for Car: public bool HasTrunk { get; set; }
             * Example for SUV: public int NumberOfSeats { get; set; }
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members. done
             */

            //Now, create objects of your 3 classes and give their members values.
            //Creatively display and organize their values

            Car lamborghini = new Car();
            lamborghini.TopSpeed = 300;
            lamborghini.NumberOfOwners = 0;
            lamborghini.HasSpolier = true;
            lamborghini.HowManyDoors = 2;
            lamborghini.IsItNew = true;
            lamborghini.CompanyName = "Lamborghini";
            lamborghini.Logo = "Bull";
            lamborghini.IsTwoDoor = true;

            Truck chevy = new Truck();
            chevy.TopSpeed = 130;
            chevy.NumberOfOwners = 5;
            chevy.IsTruckBedExtended = true;
            chevy.IsItNew = false;
            chevy.IsTruckBedOpen = "Yes";
            chevy.CompanyName = "Chevy";
            chevy.Logo = "+";
            chevy.HowManyDoors = 2;

            SUV infiniti = new SUV();
            infiniti.TopSpeed = 175;
            infiniti.NumberOfOwners = 1;
            infiniti.CanSeatEightPeople = true;
            infiniti.HasScreenInHeadRest = "No";
            infiniti.HowManyDoors = 4;
            infiniti.IsItNew = false;
            infiniti.Logo = "Flat pac man circle";
            infiniti.CompanyName = "Infiniti";




          

            List < IVehicle> list = new List<IVehicle>();

            list.Add(lamborghini);
            list.Add(chevy);
            list.Add(infiniti);
            
            foreach(IVehicle vehicle in list)
            {
                Console.WriteLine($"Top Speed: {vehicle.TopSpeed}");
                Console.WriteLine($"Number of Owbers: {vehicle.NumberOfOwners}");
                Console.WriteLine($"How Many Doors: {vehicle.HowManyDoors}");
                Console.WriteLine($"Is it New: {vehicle.IsItNew}");
                Console.WriteLine($"Company Name is: {vehicle.CompanyName}");
                Console.WriteLine($"Logo is: {vehicle.Logo}");
                Console.WriteLine();
                
            }

            


            //Option for displaying values: 
            //Create a stubbed out method called DisplayDetails in your IVehicle interface.
            //Implement the stubbed out method in the derived classes.
            //In the scope of them method, use string interpolation to display property values.
            //In order to also interpolate values from ICompany, research how to extend interfaces.

        }
    }
}
