using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR7
    {
        internal class CR7Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR7Print()
        {
            List<CR7Monster> cr7 = new()
                {
                new CR7Monster() { Name = "Giant Ape" },
                new CR7Monster() { Name = "Oni" },
                new CR7Monster() { Name = "Sheild Guardian" },
                new CR7Monster() { Name = "Stone Giant" },
                new CR7Monster() { Name = "Young Black Dragon" },
                };

            foreach (CR7Monster aMonster in cr7)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
