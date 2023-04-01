using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DnD_5e_Encounter_Calculator.CRHalf;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR1
    {
        internal class CR1Monster 
        {
            internal string Name { get; set; }
        }
        internal static void CR1Print() 
        {
        List<CR1Monster> cr1 = new()
                {
                new CR1Monster() { Name = "Animated Armor" },
                new CR1Monster() { Name = "Brass Dragon Wyrmling" },
                new CR1Monster() { Name = "Brown Bear" },
                new CR1Monster() { Name = "Bugbear" },
                new CR1Monster() { Name = "Copper Dragon Wyrmling" },
                new CR1Monster() { Name = "Death Dog" },
                new CR1Monster() { Name = "Dire Wolf" },
                new CR1Monster() { Name = "Dryad" },
                new CR1Monster() { Name = "Duergar" },
                new CR1Monster() { Name = "Ghoul" },
                new CR1Monster() { Name = "Giant Eagle" },
                new CR1Monster() { Name = "Giant Hyena" },
                new CR1Monster() { Name = "Giant Octopus" },
                new CR1Monster() { Name = "Giant Spider" },
                new CR1Monster() { Name = "Giant Toad" },
                new CR1Monster() { Name = "Giant Vulture" },
                new CR1Monster() { Name = "Harpy" },
                new CR1Monster() { Name = "Hippogriff" },
                new CR1Monster() { Name = "Imp" },
                new CR1Monster() { Name = "Lion" },
                new CR1Monster() { Name = "Quasit" },
                new CR1Monster() { Name = "Specter" },
                new CR1Monster() { Name = "Spy" },
                new CR1Monster() { Name = "Swarm Of Quippers" },
                new CR1Monster() { Name = "Tiger" },
                };
            foreach (CR1Monster aMonster in cr1)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
