using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static DnD_5e_Encounter_Calculator.PartyList;
using static DnD_5e_Encounter_Calculator.CRCalculator;
using System.Net;
using Xceed.Wpf.Toolkit;
using Xceed.Wpf.AvalonDock.Layout;
using Newtonsoft.Json.Serialization;
using System.Text.Json.Serialization;
using Xceed.Wpf.Toolkit.Media.Animation;
using System.Net.Cache;
using System.Data;
using Newtonsoft.Json.Linq;
using System.Threading;
using static System.Formats.Asn1.AsnWriter;
using System.Timers;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;
using System.Xml.Linq;
using static DnD_5e_Encounter_Calculator.CR0;

namespace DnD_5e_Encounter_Calculator
{
    internal class ApiSorter
    {
        internal static void MonsterSorter(double PartyCR)
        {
            // Max number in all if statements is the Challenge Rating of the monster.
            if (PartyCR == 0) 
            {
                CR0.CR0Print();
            }
            else if (PartyCR >= 0.1 && PartyCR <= 0.125)
            {
                CROne8th.CROne8thPrint();
            }
            else if (PartyCR >= 0.126 && PartyCR <= 0.25) 
            {
                CROne4th.CROne4thPrint();
            }
            else if (PartyCR >= .26 && PartyCR <= .50)
            {
                CRHalf.CRHalfPrint();
            }
            else if (PartyCR >= .51 && PartyCR <= 1)
            {
                CR1.CR1Print();
            }
            else if (PartyCR >= 1.1 && PartyCR <= 2) 
            {
                CR2.CR2Print();
            }
            else if (PartyCR >= 2.1 && PartyCR <= 3) 
            {
                CR3.CR3Print();
            }
            else if (PartyCR >= 3.1 && PartyCR <= 4) 
            {
                CR4.CR4Print();
            }
            else if (PartyCR >= 4.1 && PartyCR <= 5)
            {
                CR5.CR5Print();
            }
            else if (PartyCR >= 5.1 && PartyCR <= 6) 
            {
                CR6.CR6Print();
            }
            else if (PartyCR >= 6.1 && PartyCR <= 7) 
            { 
                CR7.CR7Print();
            }
            else if (PartyCR >= 7.1 && PartyCR <= 8) 
            {
                CR8.CR8Print();
            }
            else if (PartyCR >= 8.1 && PartyCR <= 9) 
            { 
                CR9.CR9Print();
            }
            else if (PartyCR >= 9.1 && PartyCR <= 10)
            {
                CR10.CR10Print();
            }
            else if (PartyCR >= 10.1 && PartyCR <= 11) 
            {
                CR11.CR11Print();
            }
            else if (PartyCR >= 11.1 && PartyCR <= 12) 
            {
                CR12.CR12Print(); 
            }
            else if (PartyCR >= 12.1 && PartyCR <= 13)
            {
                CR13.CR13Print();
            }
            else if (PartyCR >= 13.1 && PartyCR <= 14)
            {
                CR14.CR14Print();
            }
            else if (PartyCR >= 14.1 && PartyCR <= 15)
            {
                CR15.CR15Print();
            }
            else if (PartyCR >= 15.1 && PartyCR <= 16)
            {
                CR16.CR16Print();
            }
            else if (PartyCR >= 16.1 && PartyCR <= 17.5)
            {
                CR17.CR17Print();
            }
            // There is no CR 18 in the base game
            else if (PartyCR >= 17.6 && PartyCR <= 19) 
            { 
                CR19.CR19Print();
            }
            else if (PartyCR >= 19.1 && PartyCR <= 20)
            {
                CR20.CR20Print();
            }
            else if (PartyCR >= 20.1 && PartyCR <= 30)
            {
                CR21to30.CR21to30Print();
            }
            else
            {
                Console.WriteLine("There are no creatures capable of standing up to your party!");
            }

        }

    }
}
