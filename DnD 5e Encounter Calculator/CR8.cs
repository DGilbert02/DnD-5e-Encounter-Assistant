using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR8
    {
        internal class CR8Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR8Print()
        {
            List<CR8Monster> cr8 = new()
                {
                new CR8Monster() { Name = "Assassin" },
                new CR8Monster() { Name = "Chain Devil" },
                new CR8Monster() { Name = "Cloaker" },
                new CR8Monster() { Name = "Frost Giant" },
                new CR8Monster() { Name = "Hezrou" },
                new CR8Monster() { Name = "Hydra" },
                new CR8Monster() { Name = "Spirit Naga" },
                new CR8Monster() { Name = "Tyannosaurus Rex" },
                new CR8Monster() { Name = "Young Bronze Dragon" },
                new CR8Monster() { Name = "Young Green Dragon" },
                };

            foreach (CR8Monster aMonster in cr8)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
