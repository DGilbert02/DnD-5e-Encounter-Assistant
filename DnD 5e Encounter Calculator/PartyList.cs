using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnD_5e_Encounter_Calculator
{
    public class PartyList
    {
        public var AdventurerList = new List<Party>();

        public class Party
        {
            public int AdventurerLvl;
        }
    }
}
