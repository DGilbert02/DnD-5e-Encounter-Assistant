using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DnD_5e_Encounter_Calculator.CR0;

namespace DnD_5e_Encounter_Calculator
{
    internal class CROne8th
    {
        internal class CROne8thMonster
        {
            internal string Name { get; set; }
        }
        internal static void CROne8thPrint()
        {
            List<CROne8thMonster> crOne8th = new()
                {
                new CROne8thMonster() { Name = "Bandit" },
                new CROne8thMonster() { Name = "Blood Hawk" },
                new CROne8thMonster() { Name = "Camel" },
                new CROne8thMonster() { Name = "Cultist" },
                new CROne8thMonster() { Name = "Diseased Giant Rat" },
                new CROne8thMonster() { Name = "Flying Snake" },
                new CROne8thMonster() { Name = "Giant Crab" },
                new CROne8thMonster() { Name = "Giant Rat" },
                new CROne8thMonster() { Name = "Giant Weasel" },
                new CROne8thMonster() { Name = "Guard" },
                new CROne8thMonster() { Name = "Kobold" },
                new CROne8thMonster() { Name = "Mastiff" },
                new CROne8thMonster() { Name = "Merfolk" },
                new CROne8thMonster() { Name = "Mule" },
                new CROne8thMonster() { Name = "Noble" },
                new CROne8thMonster() { Name = "Poisonous Snake" },
                new CROne8thMonster() { Name = "Pony" },
                new CROne8thMonster() { Name = "Stirge" },
                new CROne8thMonster() { Name = "Tribal Warrior" },
                new CROne8thMonster() { Name = "Twig Blight" },
                };

            foreach (CROne8thMonster aMonster in crOne8th)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
