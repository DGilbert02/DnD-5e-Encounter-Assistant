using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR11
    {
        internal class CR11Monster
        {
            internal string Name { get; set; }
        }
        internal static void CR11Print()
        {
            List<CR11Monster> cr11 = new()
                {
                new CR11Monster() { Name = "Behir" },
                new CR11Monster() { Name = "Djinni" },
                new CR11Monster() { Name = "Efreeti" },
                new CR11Monster() { Name = "Gynosphinx" },
                new CR11Monster() { Name = "Horned Devil" },
                new CR11Monster() { Name = "Remorhaz" },
                new CR11Monster() { Name = "Roc" },
                };

            foreach (CR11Monster aMonster in cr11)
            {
                Console.WriteLine(aMonster.Name);
            }
        }
    }
}
