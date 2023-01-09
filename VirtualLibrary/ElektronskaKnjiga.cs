namespace VirtualLibrary
{
    internal class ElektronskaKnjiga : Knjiga
    {
        public string URL { get; set; }
        const string Tip = "ElektronskaKnjiga";

        public ElektronskaKnjiga(string naslov, string avtor, string isbn, string zalozba, int letoIzdaje, int strani, string url) : base(naslov, avtor, isbn, zalozba, letoIzdaje, strani)
        {
            URL = url;
        }

        public ElektronskaKnjiga(string naslov, string avtor, string url) : base(naslov, avtor)
        {
            URL = url;
        }

        public override void PosodobiKnjigo(int index, string naslov, string avtor, string isbn, string zalozba, int letoIzdaje, int strani)
        {
            base.PosodobiKnjigo(index, naslov, avtor, isbn, zalozba, letoIzdaje, strani);
        }
    }
}
