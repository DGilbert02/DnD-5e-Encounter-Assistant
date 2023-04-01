using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR4
    {
        internal class CR4Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR4Print()
        {
            List<CR4Monster> cr4 = new()
                {
                new CR4Monster() { Name = "Banshee" },
                new CR4Monster() { Name = "Black Pudding" },
                new CR4Monster() { Name = "Chuul" },
                new CR4Monster() { Name = "Couatl" },
                new CR4Monster() { Name = "Elephant" },
                new CR4Monster() { Name = "Ettin" },
                new CR4Monster() { Name = "Flameskull" },
                new CR4Monster() { Name = "Ghost" },
                new CR4Monster() { Name = "Incubus" },
                new CR4Monster() { Name = "Lamia" },
                new CR4Monster() { Name = "Red Dragon Wyrmling" },
                new CR4Monster() { Name = "Succubus" },
                new CR4Monster() { Name = "Wereboar" },
                new CR4Monster() { Name = "Weretiger" },
                };

            foreach (CR4Monster aMonster in cr4)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
