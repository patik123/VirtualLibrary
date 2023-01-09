using System.Collections.Generic;

namespace VirtualLibrary
{
    internal class Knjiga
    {
        // Podatki o knjigi
        public string Naslov { get; set; }
        public string Avtor { get; set; }
        public string ISBN { get; set; }
        public string Zalozba { get; set; }

        // Pri pridobivanju parse v string
        public int LetoIzdaje { get; set; }
        public int Strani { get; set; }

        // Podatki o izposojenosti
        public bool Izposojena { get; set; }

        public const string Tip = "Knjiga";


        // Seznam vseh knjig
        public static List<Knjiga> SeznamVsehKnjig = new List<Knjiga>();

        // Konstruktor 
        public Knjiga(string naslov, string avtor, string isbn, string zalozba, int letoIzdaje, int strani)
        {
            Naslov = naslov;
            Avtor = avtor;
            ISBN = isbn;
            Zalozba = zalozba;
            LetoIzdaje = letoIzdaje;
            Strani = strani;
            Izposojena = false; // Knjiga je na zacetku na voljo
        }

        public Knjiga(string naslov, string avtor)
        {
            this.Naslov = naslov;
            this.Avtor = avtor;
            this.Strani = 0;
            this.Izposojena = false;
            this.LetoIzdaje = 0;
            this.Zalozba = "";
        }


        // Metoda za dodajanje knjige v seznam vseh knjig
        public void DodajKnjigo()
        {
            SeznamVsehKnjig.Add(this);
        }

        // Metoda za posodobitev podatkov o knjigi
        virtual public void PosodobiKnjigo(int index, string naslov, string avtor, string isbn, string zalozba, int letoIzdaje, int strani)
        {
            SeznamVsehKnjig[index].Naslov = naslov;
            SeznamVsehKnjig[index].Avtor = avtor;
            SeznamVsehKnjig[index].ISBN = isbn;
            SeznamVsehKnjig[index].Zalozba = zalozba;
            SeznamVsehKnjig[index].LetoIzdaje = letoIzdaje;
            SeznamVsehKnjig[index].Strani = strani;
        }

        // Vrni list vseh knjig
        public static List<Knjiga> VrniVseKnjige()
        {
            return SeznamVsehKnjig;
        }

        // Read only property
        public string IzposojenaString
        {
            get
            {
                if (Izposojena)
                {
                    return "Da";
                }
                else
                {
                    return "Ne";
                }
            }
        }

        // Metoda za izpis podatkov o knjigi
        public override string ToString()
        {
            return string.Format("Naslov: {0}, Avtor: {1}, ISBN: {2}, Založba: {3}, Leto izdaje: {4}, Število strani: {5}, Izposojena: {6}", Naslov, Avtor, ISBN, Zalozba, LetoIzdaje, Strani, IzposojenaString);
        }

        // Metoda za vrnjenje podatkov o knjigi na podlagi lokacije v seznamu
        public static Knjiga VrniKnjigo(int index)
        {
            return SeznamVsehKnjig[index];
        }

        // Metoda za izbris knjige iz seznama
        public static void IzbrisiKnjigo(int index)
        {
            SeznamVsehKnjig.RemoveAt(index);
        }
        ~Knjiga()
        {

        }
    }
}
