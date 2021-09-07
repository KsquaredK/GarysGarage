using System;
using System.Collections.Generic;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 

        {
            Zero fxs = new Zero();
            // {MainColor = "Midnight Blue", Name = "FXs", Make = "Zero", Verb = "zips", Sound = "f-f-f-f-f-f-f-f-f-f-f-sh!"}
            Zero fx = new Zero() ;
            // {MainColor = "Black", Name = "FX", Make = "Zero", Verb = "zips", Sound = "f-f-f-f-f-f-f-f-f-f-f-sh!"};
            Tesla modelS = new Tesla(); 
            // {MainColor = "Burgundy", Name = "modelS", Make = "Tesla", Verb = "blazes", Sound =  "=>=>=>=>=>!"};

            List<IElectricVehicle> electricVehicles = new List<IElectricVehicle>() {fx, fxs, modelS};

            Console.WriteLine("Electric vehicles...best to check their charges.");

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}");
                Console.WriteLine("Let's charge it up!");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
            //     // This should charge the vehicle to 100%
                ev.ChargeBattery();
                Console.WriteLine("Charging......");
                Console.WriteLine("......");
                Console.WriteLine("....");
                Console.WriteLine("..");
                Console.WriteLine(".");
                Console.WriteLine("All done!");
            }

            foreach(IElectricVehicle ev in electricVehicles)
            {
                Console.WriteLine($"{ev.CurrentChargePercentage}%");
            }
        } 
    }
}


//         {
            
//             Ram excess = new Ram() {MainColor = "Silver", Name = "excess", Make = "Ram", Verb = "growls", Sound = "Bwahahahahaha!!"};
//             Cessna mx410 = new Cessna() {MainColor = "White", Name = "mx410", Make = "Cessna", Verb = "flashes", Sound = "nnnnNNNNNYYYYEEEEERRRRRRROOOOooowwwwww!"};
            
//             fxs.Drive();
//             fxs.Turn();
//             fxs.Stop();
//             modelS.Drive();
//             modelS.Turn();
//             modelS.Stop();
//             fx.Drive();
//             fx.Turn();
//             fx.Stop();
//             mx410.Drive();
//             mx410.Turn();
//             mx410.Stop();
//             excess.Drive();
//             excess.Turn();
//             excess.Stop();

//         }
//     }
// }}

