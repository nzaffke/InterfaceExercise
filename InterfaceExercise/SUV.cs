using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class SUV : IVehicle, ICompany
    {
        public string CompanyName { get; set; }
        public string Motto { get; set; }
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Modle { get; set; }
        public int SeatCount { get; set; }
        public bool HasChangedGears { get; set; }
        public bool HasCargoHold { get; set; } = true;

        public void Drive()
        {
            Console.WriteLine($"{GetType().Name} now driving forward. . .");
        }
        public void Reverse()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now reversing. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't reverse untill we change gears");
            }
        }
        public void Park()
        {
            if (HasChangedGears == true)
            {
                Console.WriteLine($"{GetType().Name} now in park. . .");
                HasChangedGears = false;
            }
            else
            {
                Console.WriteLine("Can't park untill we change gears");
            }
        }
        public void ChangeGears(bool isChanged)
        {
            HasChangedGears = isChanged;
        }
        public SUV()
        {
            var HasCargoHold = false;
            Console.WriteLine($"The suv has a cargo hold { HasCargoHold}");
        }
    }
}
