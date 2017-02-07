using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    public class DieselBil : Bil
    {
        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr, bool PartikelFilter) 
            : base(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr)
        {

        }
        public DieselBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr)
            : this(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr, PartikelFilter: true)
        {
            PartikelFilter = true;
        }

        public bool PartikelFilter { get; set; }

        public override int HalvÅrligEjerAfgift()
        {
            int ejerafgift = 1000;
            if (PartikelFilter == false)
            {
                ejerafgift += 500;
            }
            return ejerafgift;

        }
    }
}
