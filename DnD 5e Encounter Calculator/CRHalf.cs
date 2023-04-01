using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DnD_5e_Encounter_Calculator.CROne4th;

namespace DnD_5e_Encounter_Calculator
{
    internal class CRHalf
    {
        internal class CRHalfMonster
        {
            internal string Name { get; set; }
        }
        internal static void CRHalfPrint() 
        {
        List<CRHalfMonster> crHalf = new()
                {
                new CRHalfMonster() { Name = "Crocodile" },
                new CRHalfMonster() { Name = "Darkmantle" },
                new CRHalfMonster() { Name = "Deep Gnome" },
                new CRHalfMonster() { Name = "Dust Mephit" },
                new CRHalfMonster() { Name = "Giant Goat" },
                new CRHalfMonster() { Name = "Giant Sea Horse" },
                new CRHalfMonster() { Name = "Giant Wasp" },
                new CRHalfMonster() { Name = "Gnoll" },
                new CRHalfMonster() { Name = "Gray Ooze" },
                new CRHalfMonster() { Name = "Hobgoblin" },
                new CRHalfMonster() { Name = "Ice Mephit" },
                new CRHalfMonster() { Name = "Lizardfolk" },
                new CRHalfMonster() { Name = "Magma Mephit" },
                new CRHalfMonster() { Name = "Magmin" },
                new CRHalfMonster() { Name = "Orc" },
                new CRHalfMonster() { Name = "Reef Shark" },
                new CRHalfMonster() { Name = "Rust Monster" },
                new CRHalfMonster() { Name = "Sahuagin" },
                new CRHalfMonster() { Name = "Satyr" },
                new CRHalfMonster() { Name = "Scout" },
                new CRHalfMonster() { Name = "Shadow" },
                new CRHalfMonster() { Name = "Swarm Of Insects" },
                new CRHalfMonster() { Name = "Swarm Of Beetles" },
                new CRHalfMonster() { Name = "Swarm Of Centipedes" },
                new CRHalfMonster() { Name = "Swarm Of Spiders" },
                new CRHalfMonster() { Name = "Swarm Of Wasps" },
                new CRHalfMonster() { Name = "Thug" },
                new CRHalfMonster() { Name = "Warhorse Skeleton" },
                new CRHalfMonster() { Name = "Worg" },
                };
            foreach (CRHalfMonster aMonster in crHalf)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
