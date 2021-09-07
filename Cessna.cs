using System;

namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public override void Turn()
        {
            Console.WriteLine("It banks southward as it enters the clouds.");
        }
        public override void Stop()
        {
            Console.WriteLine($"The {Make} bounces twice making contact and rolls to a stop a mile down the runway.");
            Console.WriteLine("");
        }

        public void RefuelTank()
        {
            // method definition omitted
        }


    }
}

// namespace Garage
// {
//     public class Cessna  // Propellor light aircraft
//     {
//         public double FuelCapacity { get; set; }
//         public string MainColor { get; set; }
//         public int MaximumOccupancy { get; set; }

//         public void RefuelTank()
//         {
//             // method definition omitted
//         }
//     }
// }