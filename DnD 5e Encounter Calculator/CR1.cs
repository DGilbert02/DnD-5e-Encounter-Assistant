using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    internal class CR1
    {
        internal class CR1Monster 
        {
            internal string Name { get; set; }
        }

        List<CR1Monster> cr1 = new()
                {
                new CR1Monster() { Name = "Bandit" },
                

                };
    }
}
