using System;
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
        var calculator = new Calculator();

        int total = Party.Sum();
        Console.Write(var calculator.Divide(total, 4));
    }
}