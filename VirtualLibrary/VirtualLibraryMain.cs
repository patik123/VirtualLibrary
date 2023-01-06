using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// Dodajanje razreda Knjiga
using VirtualLibrary;

namespace VirtualLibrary
{
    public partial class VirtualLibraryMain : Form
    {
        public VirtualLibraryMain()
        {
            InitializeComponent();
        }

        private void VirtualLibraryMain_Load(object sender, EventArgs e)
        {
            Knjiga knjiga1 = new Knjiga("C# 5.0", "Ivan Petrov", "1234567890123", "Mladinska knjiga", 2015, 500);
            knjiga1.DodajKnjigo();

            Knjiga knjiga2 = new Knjiga("C# 6.0", "Ivan Petrov", "1234567890124", "Mladinska knjiga", 2016, 500);
            knjiga2.DodajKnjigo();


            // Pridobi seznam vseh knjig
            List<Knjiga> seznamVsehKnjig = Knjiga.VrniVseKnjige();

            SeznamKnjig.View = View.Details;

            // Dodajanje stolpcev
            SeznamKnjig.Columns.Add("Naslov", 100);
            SeznamKnjig.Columns.Add("Avtor", 100);
            SeznamKnjig.Columns.Add("ISBN", 100);
            SeznamKnjig.Columns.Add("Založba", 100);
            SeznamKnjig.Columns.Add("Leto izdaje", 100);
            SeznamKnjig.Columns.Add("Število strani", 100);
            SeznamKnjig.Columns.Add("Izposojena", 100);

            
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            // Ustvari novo knjigo 
            Knjiga knjiga = new Knjiga(bookTitleLabel.Text, bookAuthorInput.Text );
        }
    }
}
