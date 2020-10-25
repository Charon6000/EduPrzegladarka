using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Przeglądarka
{
    public partial class Przegladarka : Form
    {
        public Przegladarka()
        {
            InitializeComponent();
        }

        private void Przegladarka_Load(object sender, EventArgs e)
        {

        }

        private void btbWyszukaj_Click(object sender, EventArgs e)
        {
            Web.Navigate(txtLine.Text);
        }

        private void btbOdswierz_Click(object sender, EventArgs e)
        {
            Web.Refresh();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Web.GoForward();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Web.GoBack();
        }

        private void oProgramieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nasza aplikacja to przeglądarka umożliwia za pomocą zakładek otrzymywanie wiedzy na temat nowości. W zakładkach umieszczone są strony internetowe (każda o innym temacie). Na ten moment przeglądarka operuje nowościami na temat Gier, Samochodów, Technologii oraz Muzyki. Zakładki można samodzielnie dodawać jednak jeszcze nie zapisuja się w chmurze.");
        }

        private void autorzyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hubert Witkowski, Oliwier Kwiatkowski, Maciej Piekarczyk, Jakub Srokowski i Szymon Stefański z Zespołu Szkół Łączności im.Obrońców Poczty Polskiej");
        }

        private void wyjścieToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtLine_TextChanged(object sender, EventArgs e)
        {
            var text = txtLine.Text;
            var word = "http://";
            if(text.Contains(word))
            {
                
            }
            else
            {
                txtLine.Clear();
                txtLine.Text =word;
            }
            

        }

        private void cmbLista_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtLine.Text = cmbLista.Text;
        }

        private void btbZakladki_Click(object sender, EventArgs e)
        {

            string Line=txtLine.Text;
            if (cmbLista.Items.Contains(txtLine.Text))
            {
                MessageBox.Show(txtLine.Text + " już istnieje");
            }
            else
            {
                cmbLista.Items.Add(Line);
            }
        }

        private void Web_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void ądakaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Nasza aplikacja powstała za użyciem Visual Studio 2019 oraz Visual Studio Code. Z zastosowanych języków możemy wyróżnić C# użyty w aplikacji oraz HTML (CSS) zastosowany na stronach internetowych. Strony są hostowane przez CBA HOSTING. ");
        }
    }
}
