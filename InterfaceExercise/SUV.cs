using System;
namespace InterfaceExercise
{
	public class SUV : IVehicle, ICompany
	{
		public bool CanSeatEightPeople { get; set; } = true;

		public string HasScreenInHeadRest { get; set; } = "No";

        public int NumberOfOwners { get; set; } = 2;

        public int TopSpeed { get; set; } = 150;

        public int HowManyDoors { get; set; } = 4;

        public bool IsItNew { get; set; } = false;

        public string Logo { get; set; } 

        public string CompanyName { get; set; } 
    }
}

