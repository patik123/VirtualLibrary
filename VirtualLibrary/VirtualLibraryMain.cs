using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace VirtualLibrary
{
    public partial class VirtualLibraryMain : Form
    {
        public VirtualLibraryMain()
        {
            InitializeComponent();
        }

        public int index_knjige = 0;
        private void VirtualLibraryMain_Load(object sender, EventArgs e)
        {


            Knjiga knjiga1 = new Knjiga("C# 5.0", "Ivan Petrov", "1234567890123", "Mladinska knjiga", 2015, 500);
            knjiga1.DodajKnjigo();

            Knjiga knjiga2 = new Knjiga("C# 6.0", "Ivan Petrov", "1234567890124", "Mladinska knjiga", 2016, 500);
            knjiga2.DodajKnjigo();

            Knjiga knjiga3 = new Knjiga("C Sharp for Dummies", "Dummies Books", "1234567890124", "Mladinska knjiga", 2016, 500);
            knjiga3.DodajKnjigo();


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

            addButton.Enabled = true;
            updateButton.Enabled = false;
        }

        private void AddBook_Click(object sender, EventArgs e)
        {

            // Clear the list view
            SeznamKnjig.Items.Clear();

            try
            {
                // Ustvari novo knjigo 
                Knjiga knjiga = new Knjiga(bookTitleInput.Text, bookAuthorInput.Text, bookISBNInput.Text, bookPublisherInput.Text, Convert.ToInt32(bookYearInput.Text), Convert.ToInt32(bookPagesInput.Text));
                // Dodaj knjigo v seznam vseh knjig
                knjiga.DodajKnjigo();
            }
            catch
            {
                MessageBox.Show("Napaka pri dodajanju knjige");
            }

            this.ClearInputs();
            // Pridobi seznam vseh knjig
            List<Knjiga> seznamVsehKnjig = Knjiga.VrniVseKnjige();

            // Dodajanje vrstic
            this.addRowsInListView(seznamVsehKnjig);
        }

        private void addRowsInListView(List<Knjiga> seznamVsehKnjig)
        {
            // Clear the list view
            SeznamKnjig.Items.Clear();

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
                index_knjige = index;
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
            try
            {
                // Update book data
                Knjiga knjiga = Knjiga.VrniKnjigo(index_knjige);
                knjiga.PosodobiKnjigo(index_knjige, bookTitleInput.Text, bookAuthorInput.Text, bookISBNInput.Text, bookPublisherInput.Text, Convert.ToInt32(bookYearInput.Text), Convert.ToInt32(bookPagesInput.Text));
            }
            catch
            {
                MessageBox.Show("Napaka pri posodobitvi knjige");
            }

            this.ClearInputs();

            addButton.Enabled = true;
            updateButton.Enabled = false;

            SeznamKnjig.Items.Clear();

            // Pridobi seznam vseh knjig
            List<Knjiga> seznamVsehKnjig = Knjiga.VrniVseKnjige();

            // Dodajanje vrstic
            this.addRowsInListView(seznamVsehKnjig);
        }

        protected void ClearInputs()
        {
            bookAuthorInput.Text = "";
            bookISBNInput.Text = "";
            bookPagesInput.Text = "";
            bookPublisherInput.Text = "";
            bookYearInput.Text = "";
            bookTitleInput.Text = "";
        }
    }
}
