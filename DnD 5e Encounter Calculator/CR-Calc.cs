﻿using System;
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
    internal class CRCalculator : Program 
    {
        public double CRCalc()
        {
            int total = AdventurerList.Sum(x => Convert.ToInt32(x));
            double PartyCR = total / 4;
            return PartyCR;
        }
    }
}