using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR21to30
    {

        internal class CR21to30Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR21to30Print()
        {
            List<CR21to30Monster> cr21to30 = new()
            {
                new CR21to30Monster() { Name = "Ancient Black Dragon" },
                new CR21to30Monster() { Name = "Ancient Copper Dragon" },
                new CR21to30Monster() { Name = "Lich" },
                new CR21to30Monster() { Name = "Solar" },
                new CR21to30Monster() { Name = "Ancient Bronze Dragon" },
                new CR21to30Monster() { Name = "Ancient Green Dragon" },
                new CR21to30Monster() { Name = " Blue Dragon" },
                new CR21to30Monster() { Name = "Ancient Silver Dragon" },
                new CR21to30Monster() { Name = "Kraken" },
                new CR21to30Monster() { Name = "Ancient Gold Dragon" },
                new CR21to30Monster() { Name = "Ancient Red Dragon" },
                new CR21to30Monster() { Name = "Tarrasque" },
            };

            foreach (CR21to30Monster aMonster in cr21to30)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
     }
}
