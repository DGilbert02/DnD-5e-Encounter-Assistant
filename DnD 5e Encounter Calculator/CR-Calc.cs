using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;
using static DnD_5e_Encounter_Calculator.PartyList;

namespace DnD_5e_Encounter_Calculator
{
    public class CRCalculator
    {
        public double CRCalc(List<Party>AdventurerList)
        {
            int total = AdventurerList.Sum(x => x.AdventurerLvl);
            double PartyCR = total / 4;
            return PartyCR;
        }
    }
}