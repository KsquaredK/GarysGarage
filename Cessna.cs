using System;

namespace Garage
{
    public class Cessna : Vehicle  // Propellor light aircraft
    {
        public double FuelCapacity { get; set; }

        public override void Drive()
        {
            Console.WriteLine("Zoooooom!");
        }

        public void RefuelTank()
        {
            // method definition omitted
        }


    }
}
