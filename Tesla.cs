using System;

namespace Garage
{
    public class Tesla : Vehicle
    {
        public double BatteryKWh { get; set; }

        public override void Drive()
        {
            Console.WriteLine("ssssshhh!");
        }

        public void ChargeBattery()
        {
            // method definition omitted
        }
    }
}

