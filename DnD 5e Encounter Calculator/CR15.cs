using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR15
    {
        internal class CR15Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR15Print()
        {
            List<CR15Monster> cr15 = new()
                {
                new CR15Monster() { Name = "Adult Bronze Dragon" },
                new CR15Monster() { Name = "Adult Green Dragon" },
                new CR15Monster() { Name = "Mummy Lord" },
                new CR15Monster() { Name = "Purple Worm" },
                };

            foreach (CR15Monster aMonster in cr15)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
