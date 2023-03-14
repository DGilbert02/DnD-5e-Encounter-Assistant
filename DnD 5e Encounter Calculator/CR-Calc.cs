using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Xceed.Wpf.Toolkit;

namespace DnD_5e_Encounter_Calculator
{
    public class CRCalculator:PartyList
    {
        public CRCalculator()
        {
            int total = AdventurerList.Sum(x => Convert.ToInt32(x));
            //int sum = AdventurerList.Sum();
            //Console.Write(Calculator.Divide(sum , 4));
            double PartyCR = total / 4;
            Console.WriteLine("The Challenge Rating of the party is" + PartyCR);
        }
    }
}