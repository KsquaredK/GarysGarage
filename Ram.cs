using System;

namespace Garage
{
    public class Ram : Vehicle // Gas powered truck
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine("Ah-oooooGAH!");
        }

        public void RefuelTank()
        {
            // method definition omitted
        }
    }
}
