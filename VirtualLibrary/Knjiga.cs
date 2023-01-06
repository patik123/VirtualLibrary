using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLibrary
{
    internal class Knjiga
    {
        // Podatki o knjigi
        public string Naslov { get; set; }
        public string Avtor { get; set; }
        public string ISBN { get; set; }
        public string Zalozba { get; set; }
        public int LetoIzdaje { get; set; }
        public int Strani { get; set; }

        // Podatki o izposojenosti
        public bool Izposojena { get; set; }


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


        // Metoda za dodajanje knjige v seznam vseh knjig
        public void DodajKnjigo()
        {
            SeznamVsehKnjig.Add(this);
        }

        // Metoda za posodobitev podatkov o knjigi
        public void PosodobiKnjigo(string naslov, string avtor, string isbn, string zalozba, int letoIzdaje, int strani)
        {
            Naslov = naslov;
            Avtor = avtor;
            ISBN = isbn;
            Zalozba = zalozba;
            LetoIzdaje = letoIzdaje;
            Strani = strani;
        }

        // Vrni list vseh knjig
        public static List<Knjiga> VrniVseKnjige()
        {
            return SeznamVsehKnjig;
        }
    }
}
