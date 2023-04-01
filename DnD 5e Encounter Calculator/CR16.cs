using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR16
    {
        internal class CR16Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR16Print()
        {
            List<CR16Monster> cr16 = new()
                {
                new CR16Monster() { Name = "Adult Blue Dragon" },
                new CR16Monster() { Name = "Adult Silver Dragon" },
                new CR16Monster() { Name = "Iron Golem" },
                new CR16Monster() { Name = "Marilith" },
                new CR16Monster() { Name = "Planetar" },
                };

            foreach (CR16Monster aMonster in cr16)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
