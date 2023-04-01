using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR2
    {
        internal class CR2Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR2Print()
        {
            List<CR2Monster> cr2 = new()
                {
                new CR2Monster() { Name = "Allosaurus" },
                new CR2Monster() { Name = "Ankheg" },
                new CR2Monster() { Name = "Awakened Tree" },
                new CR2Monster() { Name = "Azer" },
                new CR2Monster() { Name = "Bandit Captain" },
                new CR2Monster() { Name = "Berserker" },
                new CR2Monster() { Name = "Black Dragon Wyrmling" },
                new CR2Monster() { Name = "Centaur" },
                new CR2Monster() { Name = "Cult Fanatic" },
                new CR2Monster() { Name = "Druid" },
                new CR2Monster() { Name = "Ettercap" },
                new CR2Monster() { Name = "Gargoyle" },
                new CR2Monster() { Name = "Gelatinous Cube" },
                new CR2Monster() { Name = "Ghast" },
                new CR2Monster() { Name = "Giant Boar" },
                new CR2Monster() { Name = "Giant Constrictor Snake" },
                new CR2Monster() { Name = "Giant Elk" },
                new CR2Monster() { Name = "Gibbering Mouther" },
                new CR2Monster() { Name = "Green Dragon Wyrmling" },
                new CR2Monster() { Name = "Grick" },
                new CR2Monster() { Name = "Griffon" },
                new CR2Monster() { Name = "Hunter Shark" },
                new CR2Monster() { Name = "Merrow" },
                new CR2Monster() { Name = "Mimic" },
                new CR2Monster() { Name = "Minotaur Skeleton" },
                new CR2Monster() { Name = "Nothic" },
                new CR2Monster() { Name = "Ochre Jelly" },
                new CR2Monster() { Name = "Ogre Zombie" },
                new CR2Monster() { Name = "Pegasus" },
                new CR2Monster() { Name = "Plesiosaurus" },
                new CR2Monster() { Name = "Polar Bear" },
                new CR2Monster() { Name = "Priest" },
                new CR2Monster() { Name = "Rhinoceros" },
                new CR2Monster() { Name = "Rug Of Smothering" },
                new CR2Monster() { Name = "Saber Toothed Tiger" },
                new CR2Monster() { Name = "Sea Hag" },
                new CR2Monster() { Name = "Silver Dragon Wyrmling" },
                new CR2Monster() { Name = "Swarm Of Poisonous Snakes" },
                new CR2Monster() { Name = "Wererat" },
                new CR2Monster() { Name = "White Dragon Wyrmling" },
                new CR2Monster() { Name = "Will O Wisp" },
                };

            foreach (CR2Monster aMonster in cr2)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
