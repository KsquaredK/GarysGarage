using System;

namespace Garage
{
    public class Zero : Vehicle  // Electric motorcycle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine("--f--f--f--f--f--f--f--f--f--f--f--f--f--f--f--f!");
        }

        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}
