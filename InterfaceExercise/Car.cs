using System;
namespace InterfaceExercise
{
	public class Car : IVehicle, ICompany
    {

		public bool HasSpolier { get; set; } = false;

		public bool IsTwoDoor { get; set; } = true;

        public int NumberOfOwners { get; set; } = 0;

        public int TopSpeed { get; set; } = 250;

        public int HowManyDoors { get; set; } = 2;

        public bool IsItNew { get; set; } = true;

        public string CompanyName { get; set; }

        public string Logo { get; set; }
    }
}

