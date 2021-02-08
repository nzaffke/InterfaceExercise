using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public class Truck : IVehicle, ICompany
    {


        public string CompanyName { get; set; }
        public string Motto { get; set; }
        public double EngineSize { get; set; }
        public string Make { get; set; }
        public string Modle { get; set; }
        public int SeatCount { get; set; }
        public bool HasChangedGears { get; set; }
        public bool HasFourWheelDrive { get; set; } = true;
        public void Drive()
        {
            if(HasFourWheelDrive == true)
            {
            Console.WriteLine($"4 wheel drive {GetType().Name} now driving forward. . .");
            }
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
    }
}
