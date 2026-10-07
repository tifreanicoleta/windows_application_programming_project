using System.Windows.Forms;

namespace AbonatiTelefonici
{
    public partial class AbonatiTelefonici : Form
    {
        public AbonatiTelefonici()
        {
            InitializeComponent();
        }

        public AbonatiTelefonici(AbonatTelefonic abonatDeEditat) : this()
        {
            this.AbonatCreat = abonatDeEditat;

            tbNumeAbonat.Text = abonatDeEditat.Client.Nume;
            tbPrenumeAbonat.Text = abonatDeEditat.Client.Prenume;
            tbTelefonAbonat.Text = abonatDeEditat.Client.Telefon;
            tbEmailAbonat.Text = abonatDeEditat.Client.Email;
            comboBoxJudet.Text = abonatDeEditat.Client.Judet;
            tbLocalitateAbonat.Text = abonatDeEditat.Client.Localitate;
            cbTipAbonament.Text = abonatDeEditat.AbonamentAles.Denumire;

            btnSalvareAbonat.Text = "Actualizeaza";
        }
        public AbonatTelefonic AbonatCreat { get; private set; }

        #region
        private void PrenumeAbonat_Click(object sender, EventArgs e) { }
        private void EmailAbonat_Click(object sender, EventArgs e){ }
        private void textBox2_TextChanged(object sender, EventArgs e){ }
        private void NumeAbonat_Click(object sender, EventArgs e){ }
        private void fisierToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void comboBoxJudet_SelectedIndexChanged(object sender, EventArgs e) { }
        private void actualizareToolStripMenuItem1_Click(object sender, EventArgs e){ }
        private void actualizareToolStripMenuItem_Click(object sender, EventArgs e) { }
        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e) { }
        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e) { }
        private void gboxExtraoptiuni_Enter(object sender, EventArgs e){ }
        private void JudetAbonat_Click(object sender, EventArgs e) { }
        #endregion


        private void tbNumeAbonat_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsNumeValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Numele este gol!");
            }
        }

        private void tbNumeAbonat_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void tbPrenumeAbonat_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsPrenumeValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Prenumele este gol!");
            }
        }

        private void tbPrenumeAbonat_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void tbEmailAbonat_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!IsEmailValid())
            {
                e.Cancel = true;
                errorProvider.SetError((Control)sender, "Adresa de e-mail este invalidă! Trebuie să conțină '@' și '.'");
            }
        }

        private void tbEmailAbonat_Validated(object sender, EventArgs e)
        {
            errorProvider.SetError((Control)sender, string.Empty);
        }

        private void btnSalvareAbonat_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbNumeAbonat.Text) || string.IsNullOrWhiteSpace(tbPrenumeAbonat.Text))
            {
                MessageBox.Show("Atat Numele cat si Prenumele sunt campuri obligatorii! Nu puteti salva un abonat fara aceste date.",
                                "Validare Date",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return; 
            }
            string email = tbEmailAbonat.Text.Trim();

            if (!string.IsNullOrWhiteSpace(email))
            {
                if (!email.Contains("@") || !email.Contains("."))
                {
                    MessageBox.Show("Adresa de e-mail introdusa este invalida! Asigurati-va ca contine caracterele '@' si '.' (ex: exemplu@domeniu.com).",
                                    "Format Email Invalid",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Warning);

                    tbEmailAbonat.Focus(); 
                    return; 
                }
            }
            int idClient = new Random().Next(1, 1000);
            Client clientNou = new Client(
                idClient,
                tbNumeAbonat.Text,
                tbPrenumeAbonat.Text,
                tbTelefonAbonat.Text,
                tbEmailAbonat.Text,
                comboBoxJudet.Text,
                tbLocalitateAbonat.Text
             );

            double pretAbonament = 0;
            string denumireAbonament = cbTipAbonament.Text;

            if (denumireAbonament == "Standard") pretAbonament = 30;
            if (denumireAbonament == "Premium") pretAbonament = 60;
            if (denumireAbonament == "Business ") pretAbonament = 100;

            TipAbonament abonamentAles = new TipAbonament(1, denumireAbonament, pretAbonament);

            List<ExtraOptiuni> listaOptiuni = new List<ExtraOptiuni>();

            foreach (var item in checkListExtraOptiuni.CheckedItems)
            {
                string denumireOptiune = item.ToString();
                double pretOptiune = 10;
                listaOptiuni.Add(new ExtraOptiuni(new Random().Next(1, 100), denumireOptiune, pretOptiune));
            }

            if (this.AbonatCreat != null)
            {
               
                this.AbonatCreat.Client.Nume = tbNumeAbonat.Text.Trim();
                this.AbonatCreat.Client.Prenume = tbPrenumeAbonat.Text.Trim();
                this.AbonatCreat.Client.Telefon = tbTelefonAbonat.Text.Trim();
                this.AbonatCreat.Client.Email = email;
                this.AbonatCreat.Client.Judet = comboBoxJudet.Text;
                this.AbonatCreat.Client.Localitate = tbLocalitateAbonat.Text.Trim();
                this.AbonatCreat.AbonamentAles = abonamentAles;
                this.AbonatCreat.OptiuniSalvate = listaOptiuni;
            }
            else
            {

                int idAbonament = new Random().Next(1000, 9999);
                AbonatCreat = new AbonatTelefonic(idAbonament, clientNou, abonamentAles, listaOptiuni);
            }


            this.DialogResult = DialogResult.OK;
            this.Close();

        }

        private void btnAnulareSalvareAbonat_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        

        private bool IsNumeValid()
        {
            return !string.IsNullOrWhiteSpace(tbNumeAbonat.Text.Trim());
        }

        private bool IsPrenumeValid()
        {
            return !string.IsNullOrWhiteSpace(tbPrenumeAbonat.Text.Trim());
        }

        private bool IsEmailValid()
        {
            string email = tbEmailAbonat.Text.Trim();
            if (!string.IsNullOrWhiteSpace(email))
            {
                return email.Contains("@") && email.Contains(".");
            }
            return true; 
        }

        
    }
}

       


    


