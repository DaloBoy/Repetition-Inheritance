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
            List<DieselBil> BilListe = new List<DieselBil>();
            BilListe.Add(new DieselBil("Ford", 5000, 2004, 34, "852456"));
            BilListe.Add(new DieselBil("BMW", 3400, 2016, 34, "852789", false));
            BilListe.Add(new DieselBil("BMW", 4000, 2017, 34, "147369"));
            BilListe.Add(new DieselBil("BMW", 4500, 2009, 34, "321654"));
            BilListe.Add(new DieselBil("BMW", 3750, 2010, 34, "753421", false));

            foreach (DieselBil db in BilListe)
            {
                Console.WriteLine("RegistreringsNr: " + db.RegistreringsNr + "      Den halvårlige ejerafgift er: " + db.HalvÅrligEjerAfgift());
            }
            Console.ReadLine();
        }
    }
}
