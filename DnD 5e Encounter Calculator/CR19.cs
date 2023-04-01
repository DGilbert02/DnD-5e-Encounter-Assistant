using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR19
    {
            internal class CR19Monster
            {
                internal string Name { get; set; }
            }
            internal static void CR19Print()
            {
                List<CR19Monster> cr19 = new()
                {
                new CR19Monster() { Name = "Balor" },
                };

                foreach (CR19Monster aMonster in cr19)
                {
                    Console.WriteLine(aMonster.Name);
                }
            }
    }
}
