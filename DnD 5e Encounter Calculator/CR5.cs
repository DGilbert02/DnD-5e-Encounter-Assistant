using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR5
    {
        internal class CR5Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR5Print()
        {
            List<CR5Monster> cr5 = new()
                {
                new CR5Monster() { Name = "Air Elemental" },
                new CR5Monster() { Name = "Barbed Devil" },
                new CR5Monster() { Name = "Bulette" },
                new CR5Monster() { Name = "Dust Devil" },
                new CR5Monster() { Name = "Earth Elemental" },
                new CR5Monster() { Name = "Fire Elemental" },
                new CR5Monster() { Name = "Flesh Golem" },
                new CR5Monster() { Name = "Giant Crocodile" },
                new CR5Monster() { Name = "Giant Shark" },
                new CR5Monster() { Name = "Gladiator" },
                new CR5Monster() { Name = "Gorgon" },
                new CR5Monster() { Name = "Half - Red Dragon Veteran" },
                new CR5Monster() { Name = "Hill Giant" },
                new CR5Monster() { Name = "Night Hag" },
                new CR5Monster() { Name = "Otyugh" },
                new CR5Monster() { Name = "Roper" },
                new CR5Monster() { Name = "Salamander" },
                new CR5Monster() { Name = "Shambling Mound" },
                new CR5Monster() { Name = "Triceratops" },
                new CR5Monster() { Name = "Troll" },
                new CR5Monster() { Name = "Unicorn" },
                new CR5Monster() { Name = "Vampire Spawn" },
                new CR5Monster() { Name = "Water Elemental" },
                new CR5Monster() { Name = "Werebear" },
                new CR5Monster() { Name = "Wraith" },
                new CR5Monster() { Name = "Xorn" },
                };

            foreach (CR5Monster aMonster in cr5)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
