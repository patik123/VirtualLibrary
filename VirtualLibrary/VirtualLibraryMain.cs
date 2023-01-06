using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VirtualLibrary;
using Helpers;


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

            // Dodajanje vrstic
            this.addRowsInListView(seznamVsehKnjig);
        }

        private void AddBook_Click(object sender, EventArgs e)
        {
            // Clear the list view
            SeznamKnjig.Items.Clear();
            // Ustvari novo knjigo 

            Knjiga knjiga = new Knjiga(bookTitleInput.Text, bookAuthorInput.Text, bookISBNInput.Text, bookPublisherInput.Text, Convert.ToInt32(bookYearInput.Text), Convert.ToInt32(bookPagesInput.Text));

            // Dodaj knjigo v seznam vseh knjig
            knjiga.DodajKnjigo();

            // Pridobi seznam vseh knjig
            List<Knjiga> seznamVsehKnjig = Knjiga.VrniVseKnjige();

            // Dodajanje vrstic
            this.addRowsInListView(seznamVsehKnjig);

        }

        private void addRowsInListView(List<Knjiga> seznamVsehKnjig)
        {
            // Dodajanje vrstic
            foreach (Knjiga knjiga in seznamVsehKnjig)
            {
                ListViewItem vrstica = new ListViewItem(knjiga.Naslov);
                vrstica.SubItems.Add(knjiga.Avtor);
                vrstica.SubItems.Add(knjiga.ISBN);
                vrstica.SubItems.Add(knjiga.Zalozba);
                vrstica.SubItems.Add(knjiga.LetoIzdaje.ToString());
                vrstica.SubItems.Add(knjiga.Strani.ToString());
                vrstica.SubItems.Add(knjiga.IzposojenaString.ToString());

                SeznamKnjig.Items.Add(vrstica);
            }
        }

        private void SeznamKnjig_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (SeznamKnjig.SelectedItems.Count > 0)
            {
                int index = SeznamKnjig.SelectedItems[0].Index;
                // Pridobi podatke o knjigi

                Knjiga knjiga = Knjiga.VrniKnjigo(index);

                // Prikaz podatkov o knjigi
                bookTitleInput.Text = knjiga.Naslov;
                bookAuthorInput.Text = knjiga.Avtor;
                bookPublisherInput.Text = knjiga.Zalozba;
                bookYearInput.Text = knjiga.LetoIzdaje.ToString();
                bookPagesInput.Text = knjiga.Strani.ToString();
                bookISBNInput.Text = knjiga.ISBN.ToString();

                addButton.Enabled = false;

                updateButton.Enabled = true;
            }
            else
            {
                return;
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            // Update book data
        }

        private void createNewBookButton_Click(object sender, EventArgs e)
        {
            bookAuthorInput.Text = "";
            bookISBNInput.Text = "";
            bookPagesInput.Text = "";
            bookPublisherInput.Text = "";
            bookYearInput.Text = "";
            bookTitleInput.Text = "";

            addButton.Enabled = true;
            updateButton.Enabled = false;
        }
    }
}
