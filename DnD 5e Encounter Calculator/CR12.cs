using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR12
    {
        internal class CR12Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR12Print()
        {
            List<CR12Monster> cr12 = new()
                {
                new CR12Monster() { Name = "Archmage" },
                new CR12Monster() { Name = "Erinyes" },
                };

            foreach (CR12Monster aMonster in cr12)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
