using System;
using System.Collections.Generic;

namespace Garage
{
    public class Vehicle
    {
        public string Name { get; set; }
        public string Make { get; set; }
        public string MainColor { get; set; }
        public string Verb { get; set; }
        public string Sound { get; set; }
        public int MaximumOccupancy { get; set; }

        public string TurnAction { get; set; }

        public virtual void Drive()
        {
            Console.WriteLine($"The {MainColor} {Make} {Name} {Verb} by you: {Sound}" );
        }
        public virtual void Turn()
        {
            Console.WriteLine($"The vehicle makes a turn." );
        }
        public virtual void Stop()
        {
            Console.WriteLine($"The vehicle rolls to a stop." );
            Console.WriteLine("");
        }
    }
}

// namespace Garage
// {
//     public class Vehicle
//     {
//         public string MainColor { get; set; }
//         public int MaximumOccupancy { get; set; }

//         public void Drive()
//         {
//             Console.WriteLine("Vrooom!");
//         }
//     }
// }

// namespace heist
    // {

    //     public class Team
    //     {
    //        public List<Member> TeamMembers { get; set;}

    //        public Team()
    //        {
    //             TeamMembers = new List<Member>();
    //        }

    //         public void AddMember(Member member)
    //         {
    //             TeamMembers.Add(member);
    //         }

    //     }
    // }


