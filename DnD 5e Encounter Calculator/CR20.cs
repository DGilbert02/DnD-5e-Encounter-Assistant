using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR20
    {
         internal class CR20Monster
         {
             internal string Name { get; set; }
         }
         internal static void CR20Print()
         {
             List<CR20Monster> cr20 = new()
             {
                 new CR20Monster() { Name = "Ancient Brass Dragon" },
                 new CR20Monster() { Name = "Ancient White Dragon" },
                 new CR20Monster() { Name = "Pit Fiend" },
                };

                foreach (CR20Monster aMonster in cr20)
                {
                    Console.WriteLine(aMonster.Name);
                }
            }
    }
}
