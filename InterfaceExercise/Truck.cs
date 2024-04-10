using System;
namespace InterfaceExercise
{
	public class Truck : IVehicle, ICompany
    {
		public string IsTruckBedOpen { get; set; } = "Yes";

		public bool IsTruckBedExtended { get; set; } = true;

        public int NumberOfOwners { get; set; } = 1;

        public int TopSpeed { get; set; } = 130;

        public int HowManyDoors { get; set; } = 2;

        public bool IsItNew { get; set; } = false;

        public string Logo { get; set; }  

        public string CompanyName { get; set; }
    }
}

