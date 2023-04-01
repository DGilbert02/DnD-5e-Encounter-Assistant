using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR9
    {
        internal class CR9Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR9Print()
        {
            List<CR9Monster> cr9 = new()
                {
                new CR9Monster() { Name = "Bone Devil" },
                new CR9Monster() { Name = "Clay Golem" },
                new CR9Monster() { Name = "Cloud Giant" },
                new CR9Monster() { Name = "Fire Giant" },
                new CR9Monster() { Name = "Glabrezu" },
                new CR9Monster() { Name = "Treant" },
                new CR9Monster() { Name = "Young Blue Dragon" },
                new CR9Monster() { Name = "Young Sliver Dragon" },
                };

            foreach (CR9Monster aMonster in cr9)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
