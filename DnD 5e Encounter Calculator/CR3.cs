using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR3
    {
        internal class CR3Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR3Print()
        {
            List<CR3Monster> cr3 = new()
                {
                new CR3Monster() { Name = "Ankylosaurus" },
                new CR3Monster() { Name = "Basilisk" },
                new CR3Monster() { Name = "Bearded Devil" },
                new CR3Monster() { Name = "Blue Dragon Wyrmling" },
                new CR3Monster() { Name = "Doppelganger" },
                new CR3Monster() { Name = "Giant Scorpion" },
                new CR3Monster() { Name = "Gold Dragon Wyrmling" },
                new CR3Monster() { Name = "Green Hag" },
                new CR3Monster() { Name = "Hell Hound" },
                new CR3Monster() { Name = "Killer Whale" },
                new CR3Monster() { Name = "Knight" },
                new CR3Monster() { Name = "Manticore" },
                new CR3Monster() { Name = "Minotaur" },
                new CR3Monster() { Name = "Mummy" },
                new CR3Monster() { Name = "Nightmare" },
                new CR3Monster() { Name = "Owlbear" },
                new CR3Monster() { Name = "Phase Spider" },
                new CR3Monster() { Name = "Spectator" },
                new CR3Monster() { Name = "Veteran" },
                new CR3Monster() { Name = "Werewolf" },
                new CR3Monster() { Name = "Wight" },
                new CR3Monster() { Name = "Winter Wolf" },
                new CR3Monster() { Name = "Yeti" },
                };

            foreach (CR3Monster aMonster in cr3)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
