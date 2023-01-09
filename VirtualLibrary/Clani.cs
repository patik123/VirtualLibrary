using System.Collections.Generic;

namespace VirtualLibrary
{
    internal class Clani
    {
        // Podatki o clanu
        public string Ime { get; set; }
        public string Priimek { get; set; }
        public string Naslov { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string UporabniskoIme { get; set; }
        public string Geslo { get; set; }

        // Seznam vseh clanov
        public static List<Clani> SeznamVsehClanov = new List<Clani>();

        // Konstruktor
        public Clani(string ime, string priimek, string naslov, string email, string telefon, string uporabniskoIme, string geslo)
        {
            Ime = ime;
            Priimek = priimek;
            Naslov = naslov;
            Email = email;
            Telefon = telefon;
            UporabniskoIme = uporabniskoIme;
            Geslo = geslo;
        }

        // Metoda za dodajanje clana v seznam vseh clanov
        public void DodajClana()
        {
            SeznamVsehClanov.Add(this);
        }

        // Metoda za posodobitev podatkov o clnu
        public void PosodobiClana(int index, string ime, string priimek, string naslov, string email, string telefon, string uporabniskoIme, string geslo)
        {
            SeznamVsehClanov[index].Ime = ime;
            SeznamVsehClanov[index].Priimek = priimek;
            SeznamVsehClanov[index].Naslov = naslov;
            SeznamVsehClanov[index].Email = email;
            SeznamVsehClanov[index].Telefon = telefon;
            SeznamVsehClanov[index].UporabniskoIme = uporabniskoIme;
            SeznamVsehClanov[index].Geslo = geslo;
        }


    }
}
