using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR14
    {
        internal class CR14Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR14Print()
        {
            List<CR14Monster> cr14 = new()
                {
                new CR14Monster() { Name = "Adult Black Dragon" },
                new CR14Monster() { Name = "Adult Copper Dragon" },
                new CR14Monster() { Name = "Ice Devil" },

                };

            foreach (CR14Monster aMonster in cr14)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
