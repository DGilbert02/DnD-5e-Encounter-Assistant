using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR13
    {
        internal class CR13Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR13Print()
        {
            List<CR13Monster> cr13 = new()
                {
                new CR13Monster() { Name = "Adult Brass Dragon" },
                new CR13Monster() { Name = "Adult White Dragon" },
                new CR13Monster() { Name = "Nalfeshnee" },
                new CR13Monster() { Name = "Rakshasa" },
                new CR13Monster() { Name = "Storm Giant" },
                new CR13Monster() { Name = "Vampire" },
                };

            foreach (CR13Monster aMonster in cr13)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
