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
            //List<DieselBil> DieselListe = new List<DieselBil>();
            //DieselListe.Add(new DieselBil("Ford", 5000, 2004, 23, "852456", 20));
            //DieselListe.Add(new DieselBil("BMW", 3400, 2016, 20, "852789", 20, false));
            //DieselListe.Add(new DieselBil("BMW", 4000, 2017, 13, "147369",40));
            //DieselListe.Add(new DieselBil("BMW", 4500, 2009, 30, "321654", 35));
            //DieselListe.Add(new DieselBil("BMW", 3750, 2010, 28, "753421", 25, false));
            
            //foreach (DieselBil db in DieselListe)
            //{
            //    Console.WriteLine("RegistreringsNr: " + db.RegistreringsNr + "      Den halvårlige ejerafgift er: " + db.HalvÅrligEjerAfgift() + "    Bilen har en rækkevidde på: " + db.Rækkevidde());
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            
            //List<BenzinBil> BenzinListe = new List<BenzinBil>();
            //BenzinListe.Add(new BenzinBil("Bugatti  ", 7000, 2010, 30, "951847", 35));
            //BenzinListe.Add(new BenzinBil("DatCar   ", 5000, 2004, 19, "781354", 25));
            //BenzinListe.Add(new BenzinBil("DankMemes", 7500, 2016, 35, "678345", 30));
            //BenzinListe.Add(new BenzinBil("Ford     ", 7200, 2008, 36, "847263", 45));
            //BenzinListe.Add(new BenzinBil("Bugatti  ", 8000, 2017, 28, "327854", 60));

            //foreach (BenzinBil bb in BenzinListe)
            //{
            //    Console.WriteLine("Mærke: " + bb.Mærke + "    Halvårlige ejerafgift: " + bb.HalvÅrligEjerAfgift() + "    Købs År " + bb.KøbsÅr + "    Km/l: " + bb.KmPrLiter + "    Reg. Nr: " + bb.RegistreringsNr + "    Bilen har en rækkevidde på: " + bb.Rækkevidde());
            //}
            //Console.WriteLine();
            //Console.WriteLine();

            //List<ElBil> ElListe = new List<ElBil>();
            //ElListe.Add(new ElBil("DisCar", 8250, 2015, "875421", 40, 30));
            //ElListe.Add(new ElBil("Charger", 7900, 2016, "875421", 35, 25));
            //ElListe.Add(new ElBil("DisCar", 10000, 2014, "875421", 50, 35));
            //ElListe.Add(new ElBil("DisCar", 8500, 2016, "875421", 40, 33));
            //ElListe.Add(new ElBil("DisCar", 9000, 2017, "875421", 50, 30));

            //foreach (ElBil eb in ElListe)
            //{
            //    Console.WriteLine("Mærke: " + eb.Mærke + "    Halvårlige ejerafgift: " + eb.HalvÅrligEjerAfgift() + "    Købs År " + eb.KøbsÅr + "    Km/l: " + eb.KmPrKW + "   Batteri-Kapaciteten: " + eb.BatteriKapacitet + "    Reg. Nr: " + eb.RegistreringsNr + "    Bilen har en rækkevidde på: " + eb.Rækkevidde());
            //}

            List<Bil> BilListe = new List<Bil>();
            BilListe.Add(new DieselBil("Ford", 5000, 2004, 23, "852456", 20));
            BilListe.Add(new DieselBil("BMW", 3400, 2016, 20, "852789", 20, false));
            BilListe.Add(new DieselBil("BMW", 4000, 2017, 13, "147369", 40));
            BilListe.Add(new DieselBil("BMW", 4500, 2009, 30, "321654", 35));
            BilListe.Add(new DieselBil("BMW", 3750, 2010, 28, "753421", 25, false));


            BilListe.Add(new BenzinBil("Bugatti  ", 7000, 2010, 30, "951847", 35));
            BilListe.Add(new BenzinBil("DatCar   ", 5000, 2004, 19, "781354", 25));
            BilListe.Add(new BenzinBil("DankMemes", 7500, 2016, 35, "678345", 30));
            BilListe.Add(new BenzinBil("Ford     ", 7200, 2008, 36, "847263", 45));
            BilListe.Add(new BenzinBil("Bugatti  ", 8000, 2017, 28, "327854", 60));


            BilListe.Add(new ElBil("DisCar", 8250, 2015, "875421", 40, 30));
            BilListe.Add(new ElBil("Charger", 7900, 2016, "875421", 35, 25));
            BilListe.Add(new ElBil("DisCar", 10000, 2014, "875421", 50, 35));
            BilListe.Add(new ElBil("DisCar", 8500, 2016, "875421", 40, 33));
            BilListe.Add(new ElBil("DisCar", 9000, 2017, "875421", 50, 30));

            foreach (Bil bil in BilListe)
            {
                if (bil is ElBil)
                {

                    ElBil ebil = bil as ElBil; ;
                    Console.WriteLine("El bil Reg. nr. " + ebil.RegistreringsNr + ": ER mærke: " + ebil.Mærke + " Og koster: " + ebil.BilPrisExAfgift + " og er fra " + ebil.KøbsÅr + " og kører " + ebil.KmPrKW + " km/KW og koster i afgift " + ebil.HalvÅrligEjerAfgift() + " Bilen har " + ebil.BatteriKapacitet + "KW og kan køre " + ebil.Rækkevidde() + " pr Batteri");
                    

                }
                if (bil is DieselBil)
                {
                    DieselBil dbil = bil as DieselBil;
                    Console.WriteLine("Diesel bil Reg. nr. " + dbil.RegistreringsNr + ": ER mærke: " + dbil.Mærke + " Og koster: " + dbil.BilPrisExAfgift + " og er fra " + dbil.KøbsÅr + " og kører " + dbil.KmPrLiter + " km/l og koster i afgift " + dbil.HalvÅrligEjerAfgift() + " Bilen har " + dbil.Tank + "liter og kan køre " + dbil.Rækkevidde() + " pr Optankning");
                }
                if (bil is BenzinBil)
                {
                    BenzinBil bbil = bil as BenzinBil;
                    Console.WriteLine("Benzin bil Reg. nr. " + bbil.RegistreringsNr + ": ER mærke: " + bbil.Mærke + " Og koster: " + bbil.BilPrisExAfgift + " og er fra " + bbil.KøbsÅr + " og kører " + bbil.KmPrLiter + " km/Llog koster i afgift " + bbil.HalvÅrligEjerAfgift() + " Bilen har " + bbil.Tank + "liter og kan køre " + bbil.Rækkevidde() + " pr Optankting");
                }
            }


            Console.ReadLine();
        }
    }
}
