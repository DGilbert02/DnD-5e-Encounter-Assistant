using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DnD_5e_Encounter_Calculator.CR16;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR17
    {
            internal class CR17Monster
            {
                internal string Name { get; set; }
            }
            internal static void CR17Print()
            {
                List<CR17Monster> cr17 = new()
                {
                new CR17Monster() { Name = "Adult Gold Dragon" },
                new CR17Monster() { Name = "Adult Red Dragon" },
                new CR17Monster() { Name = "Androsphinx" },
                new CR17Monster() { Name = "Dragon Turtle" },
                };

                foreach (CR17Monster aMonster in cr17)
                {
                    Console.WriteLine(aMonster.Name);
                }
            }
    }
}
