﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    public class DieselBil : Bil
    {
        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr, int Tank, bool PartikelFilter) 
            : base(Mærke, PrisExAfgift, KøbsÅr, RegistreringsNr)
        {
            this.PartikelFilter = PartikelFilter;
            this.Tank = Tank;
            this.KmPrLiter = KmPrLiter;

        }
        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr, int Tank)
            : this(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr, Tank, PartikelFilter: true)
        {
            
        }

        public int Tank { get; set; }
        public bool PartikelFilter { get; set; }
        public int KmPrLiter { get; set; }

        public override int HalvÅrligEjerAfgift()
        {
            int ejerafgift = 0;
            if (KmPrLiter < 15)
            {
                ejerafgift = 2000;
            }
            if (KmPrLiter >= 15 || KmPrLiter <= 25)
            {
                ejerafgift = 1000;
            }
            if (KmPrLiter > 25)
            {
                ejerafgift = 350;
            }


            if (PartikelFilter == false)
            {
                ejerafgift += 500;
            }
            return ejerafgift;

        }

        public override int Rækkevidde()
        {
  
            int længde = Tank * KmPrLiter;
            return længde;
        }
    }
}
