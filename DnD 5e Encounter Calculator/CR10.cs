using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR10
    {
        internal class CR10Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR10Print()
        {
            List<CR10Monster> cr10 = new()
                {
                new CR10Monster() { Name = "Aboleth" },
                new CR10Monster() { Name = "Deva" },
                new CR10Monster() { Name = "Guardian Naga" },
                new CR10Monster() { Name = "Stone Golem" },
                new CR10Monster() { Name = "Young Gold Dragon" },
                new CR10Monster() { Name = "Young Red Dragon" },
                };

            foreach (CR10Monster aMonster in cr10)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
