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

// ***************  INTERFACES AT GARY'S GARAGE
// 1. Scooter
// 2. Car
// 3. Jetski
// 4. RV
// 5. Motorcycle
// 6. Boat
// 7. Truck
// 8. Light aircraft
// Now, all of these types of things have some attributes and behaviors in common.

// - They all have an engine
// - They all carry one, or more, passenger
// - They all move
// - They all accelerate in any direction
// There are other attributes and behaviors that some specific kinds of these vehicles share, but others don't.

// - Some use gas
// - Some are electric
// - Some use a propeller to move
// - Some have wheels
// - Some have doors
// - Some use a jet to move

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


