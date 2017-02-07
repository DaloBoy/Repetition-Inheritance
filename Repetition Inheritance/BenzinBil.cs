using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    sealed class BenzinBil : Bil
    {
        public BenzinBil(string Mærke, double PrisExAfgift, int KøbsÅr, int KmPrLiter, string RegistreringsNr) : base(Mærke, PrisExAfgift, KøbsÅr, KmPrLiter, RegistreringsNr)
        {
        }

        public override int HalvÅrligEjerAfgift()
        {
            int ejerafgift = 0;
            if (KmPrLiter < 20)
            {
                ejerafgift = 1200;
            }
            else if (KmPrLiter >= 20 || KmPrLiter <= 28)
            {
                ejerafgift = 600;
            }
            if (KmPrLiter > 28)
            {
                ejerafgift = 320;
            }

            return ejerafgift;
        }



    }
}
