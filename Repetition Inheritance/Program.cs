using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repetition_Inheritance
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<DieselBil> DieselListe = new List<DieselBil>();
            DieselListe.Add(new DieselBil("Ford", 5000, 2004, 23, "852456"));
            DieselListe.Add(new DieselBil("BMW", 3400, 2016, 20, "852789", false));
            DieselListe.Add(new DieselBil("BMW", 4000, 2017, 13, "147369"));
            DieselListe.Add(new DieselBil("BMW", 4500, 2009, 30, "321654"));
            DieselListe.Add(new DieselBil("BMW", 3750, 2010, 28, "753421", false));
            
            foreach (DieselBil db in DieselListe)
            {
                Console.WriteLine("RegistreringsNr: " + db.RegistreringsNr + "      Den halvårlige ejerafgift er: " + db.HalvÅrligEjerAfgift());
            }
            Console.WriteLine();
            Console.WriteLine();
            
            List<BenzinBil> BenzinListe = new List<BenzinBil>();
            BenzinListe.Add(new BenzinBil("Bugatti  ", 7000, 2010, 30, "951847"));
            BenzinListe.Add(new BenzinBil("DatCar   ", 5000, 2004, 19, "781354"));
            BenzinListe.Add(new BenzinBil("DankMemes", 7500, 2016, 35, "678345"));
            BenzinListe.Add(new BenzinBil("Ford     ", 7200, 2008, 36, "847263"));
            BenzinListe.Add(new BenzinBil("Bugatti  ", 8000, 2017, 28, "327854"));

            foreach (BenzinBil bb in BenzinListe)
            {
                Console.WriteLine("Mærke: " + bb.Mærke + "    Halvårlige ejerafgift: " + bb.HalvÅrligEjerAfgift() + "    Købs År " + bb.KøbsÅr + "    Km Pr. L: " + bb.KmPrLiter + "    Reg. Nr: " + bb.RegistreringsNr );
            }
            Console.ReadLine();
        }
    }
}
