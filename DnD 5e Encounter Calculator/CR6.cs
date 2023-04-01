using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR6
    {
        internal class CR6Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR6Print()
        {
            List<CR6Monster> cr6 = new()
                {
                new CR6Monster() { Name = "Chimera" },
                new CR6Monster() { Name = "Cyclops" },
                new CR6Monster() { Name = "Drider" },
                new CR6Monster() { Name = "Invisible Stalker" },
                new CR6Monster() { Name = "Mage" },
                new CR6Monster() { Name = "Mammoth" },
                new CR6Monster() { Name = "Medusa" },
                new CR6Monster() { Name = "Vrock" },
                new CR6Monster() { Name = "Wyvern" },
                new CR6Monster() { Name = "Young Brass Dragon" },
                new CR6Monster() { Name = "Young White Dragon" },
                };

            foreach (CR6Monster aMonster in cr6)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
