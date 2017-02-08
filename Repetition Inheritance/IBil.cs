namespace Repetition_Inheritance
{
    public interface IBil
    {
        double BilPrisExAfgift { get; }
        int KøbsÅr { get; }
        string Mærke { get; set; }
        string RegistreringsNr { get; set; }
        double RegistreringsAfgift();
        double TotalPris();
        int HalvÅrligEjerAfgift();
        int Rækkevidde();
    }
}