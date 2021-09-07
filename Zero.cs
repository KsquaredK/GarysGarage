using System;

namespace Garage
{
    public class Zero : Vehicle, IElectricVehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public int CurrentChargePercentage { get; set; } = 93;

        public void ChargeBattery()
        {
            CurrentChargePercentage = 100;
        }
        public override void Turn()
        {
            Console.WriteLine("It nearly hits the pavement while banking a hard right.");
        }
    }
}


// namespace Garage
// {
//     public class Zero  // Electric motorcycle
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