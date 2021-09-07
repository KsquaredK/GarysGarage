using System;

namespace Garage
{
    class Program
    {
        static void Main(string[] args) 
        {
            Zero fxs = new Zero() {MainColor = "Midnight Blue", Name = "fxs", Make = "Zero", Verb = "zips", Sound = "f-f-f-f-f-f-f-f-f-f-f-sh!"};
            Ram excess = new Ram() {MainColor = "Silver", Name = "excess", Make = "Ram", Verb = "growls", Sound = "Bwahahahahaha!!"};
            Tesla modelS = new Tesla() {MainColor = "Burgundy", Name = "modelS", Make = "Tesla", Verb = "blazes", Sound =  "=>=>=>=>=>!"};  
            Zero modelT = new Zero() {MainColor = "Black", Name = "modelT", Make = "Zero", Verb = "zips", Sound = "f-f-f-f-f-f-f-f-f-f-f-sh!"}; 
            Cessna mx410 = new Cessna() {MainColor = "White", Name = "mx410", Make = "Cessna", Verb = "flashes", Sound = "nnnnNNNNNYYYYEEEEERRRRRRROOOOooowwwwww!"};
            

            fxs.Drive();
            fxs.Turn();
            fxs.Stop();
            modelS.Drive();
            modelS.Turn();
            modelS.Stop();
            modelT.Drive();
            modelT.Turn();
            modelT.Stop();
            mx410.Drive();
            mx410.Turn();
            mx410.Stop();
            excess.Drive();
            excess.Turn();
            excess.Stop();

        }
    }
}

// namespace Garage
// {
//     class Program
//     {
//         static void Main(string[] args) 
//         {
//             Zero fxs = new Zero();
//             Tesla modelS = new Tesla();
//             Cessna mx410 = new Cessna();

//             fxs.Drive();
//             modelS.Drive();
//             mx410.Drive();
//         }
//     }
// }
