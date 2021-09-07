using System;
using System.Collections.Generic;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public override void Turn()
        {
            Console.WriteLine("It makes a neat right-hand turn.");
        }

        public override void Stop()
        {
            Console.WriteLine($"The {Make} {Name} silently glides to a stop.");
            Console.WriteLine("");
        }

        public void ChargeBattery()
        {
            // method definition omitted
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