using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR0
    {
        internal class CR0Monster
        {
            internal string Name { get; set; }
        }

        List<CR0Monster> cr0 = new()
                {
                    new CR0Monster() { Name = "Awakened Shrub" },
                    new CR0Monster() { Name = "Baboon" },
                    new CR0Monster() { Name = "Badger" },
                    new CR0Monster() { Name = "Bat" },
                    new CR0Monster() { Name = "Cat" },
                    new CR0Monster() { Name = "Commoner" },
                    new CR0Monster() { Name = "Crab" },
                    new CR0Monster() { Name = "Deer" },
                    new CR0Monster() { Name = "Eagle" },
                    new CR0Monster() { Name = "Frog" },
                    new CR0Monster() { Name = "Giant Fire Beetle" },
                    new CR0Monster() { Name = "Goat" },
                    new CR0Monster() { Name = "Hawk" },
                    new CR0Monster() { Name = "Homunculus" },
                    new CR0Monster() { Name = "Hyena" },
                    new CR0Monster() { Name = "Jackal" },
                    new CR0Monster() { Name = "Lemure" },
                    new CR0Monster() { Name = "Lizard" },
                    new CR0Monster() { Name = "Octopus" },
                    new CR0Monster() { Name = "Owl" },
                    new CR0Monster() { Name = "Quipper" },
                    new CR0Monster() { Name = "Rat" },
                    new CR0Monster() { Name = "Raven" },
                    new CR0Monster() { Name = "Scorpion" },
                    new CR0Monster() { Name = "Sea-Horse" },
                    new CR0Monster() { Name = "Shrieker" },
                    new CR0Monster() { Name = "Spider" },
                    new CR0Monster() { Name = "Vulture" },
                    new CR0Monster() { Name = "Weasel" }
                };
        internal void CR0Print()
        {
            foreach (CR0Monster aMonster in cr0)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
