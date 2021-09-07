using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public override void Turn()
        {
            Console.WriteLine("It swings wide to take a left.");
        }
        
        public override void Stop()
        {
            Console.WriteLine($"The {Make} screeches to a halt six feet into the intersection.");
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
//     public class Ram  // Gas powered truck
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