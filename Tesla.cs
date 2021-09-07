using System;

namespace Garage
{
    public class Tesla : Vehicle, IElectricVehicle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; } = 44;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }

        public override void Turn()
        {
            Console.WriteLine("It makes a neat right-hand turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {Make} {Name} silently glides to a stop.");
            Console.WriteLine("");
        }
    }
}

  


// namespace Garage
// {
//     public class Tesla  // Electric car
//     {
//         public double BatteryKWh { get; set; }
//         public string MainColor { get; set; }
//         public int MaximumOccupancy { get; set; }

//         public void ChargeBattery()
//         {
//             // method definition omitted
//         }
//     }
// } 