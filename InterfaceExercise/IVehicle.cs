using System;
namespace InterfaceExercise
{
    

    public interface IVehicle : ICompany 
    {
        public int NumberOfOwners { get; set; }

        public int TopSpeed { get; set; }

        public int HowManyDoors { get; set; }

        public bool IsItNew { get; set; }

        

        
    }
}

