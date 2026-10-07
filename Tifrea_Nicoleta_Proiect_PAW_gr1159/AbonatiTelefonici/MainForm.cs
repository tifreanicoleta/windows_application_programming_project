using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.DataFormats;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.IO;

namespace AbonatiTelefonici
{
    public partial class MainForm : Form
    {
        private List<AbonatTelefonic> _listaAbonati = new List<AbonatTelefonic>();
        private DatabaseAbonati _db = new DatabaseAbonati();
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            try
            {
                _listaAbonati = _db.Abonati.Include("Client").ToList();

                dataGridView1.Rows.Clear();
                foreach (var abonat in _listaAbonati)
                {
                    int indexRand = dataGridView1.Rows.Add(new object[] {
                        abonat.IdAbonament,
                        abonat.Client.Nume,
                        abonat.Client.Prenume,
                        abonat.Client.Telefon,
                        abonat.AbonamentAles.Denumire
                    });

                    dataGridView1.Rows[indexRand].Tag = abonat;
                }
            }
            catch (Exception ex)
            {
                string mesajEroare = ex.Message;
                if (ex.InnerException != null)
                {
                    mesajEroare += "\nDetalii: " + ex.InnerException.Message;
                    if (ex.InnerException.InnerException != null)
                    {
                        mesajEroare += "\nCauza exacta: " + ex.InnerException.InnerException.Message;
                    }
                }
                MessageBox.Show("Eroare la incarcarea bazei de date: " + mesajEroare, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void incarcaredateToolStripMenuItem_Click(object sender, EventArgs e)
        {

            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Fisiere Text (*.txt)|*.txt|Toate fisierele (*.*)|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamReader streamReader = new System.IO.StreamReader(openFileDialog.FileName))
                    {
                        string linie;

                        _listaAbonati.Clear();
                        dataGridView1.Rows.Clear();

                        streamReader.ReadLine();
                        streamReader.ReadLine();

                        while ((linie = streamReader.ReadLine()) != null)
                        {
                            if (string.IsNullOrWhiteSpace(linie)) continue;

                            string[] valori = linie.Split('|');

                            if (valori.Length >= 5)
                            {
                                int id = int.Parse(valori[0].Trim());

                                Client client = new Client(id, valori[1].Trim(), valori[2].Trim(), valori[3].Trim(), "", "", "");
                                TipAbonament abonament = new TipAbonament(1, valori[4].Trim(), 0);

                                AbonatTelefonic abonat = new AbonatTelefonic(id, client, abonament, new List<ExtraOptiuni>());

                                _listaAbonati.Add(abonat);

                                int indexRand = dataGridView1.Rows.Add(new object[] {
                            abonat.IdAbonament,
                            abonat.Client.Nume,
                            abonat.Client.Prenume,
                            abonat.Client.Telefon,
                            abonat.AbonamentAles.Denumire
                        });

                                dataGridView1.Rows[indexRand].Tag = abonat;
                            }
                        }
                    }
                    MessageBox.Show("Datele au fost incărcate si restaurate cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la citirea datelor din fisier: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void adaugaAbonatiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolAdaugaAbonat_Click(sender, e);
        }

        private void toolAdaugaAbonat_Click(object sender, EventArgs e)
        {
            AbonatiTelefonici frm = new AbonatiTelefonici();

            if (frm.ShowDialog() == DialogResult.OK)
            {
                AbonatTelefonic abonatNou = frm.AbonatCreat;

                if (abonatNou != null)
                {
                    _db.Abonati.Add(abonatNou);
                    _db.SaveChanges();


                    _listaAbonati.Add(abonatNou);


                    dataGridView1.Rows.Add(new object[] {
                    abonatNou.IdAbonament,
                    abonatNou.Client.Nume,
                    abonatNou.Client.Prenume,
                    abonatNou.Client.Telefon,
                    abonatNou.AbonamentAles.Denumire
                    });

                    dataGridView1.Rows[dataGridView1.Rows.Count - 1].Tag = abonatNou;
                }
            }


        }

        private void toolEditeazaAbonat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Va rugam sa selectati mai intai un abonat din tabel pentru a-l edita!",
                    "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow randSelectat = dataGridView1.SelectedRows[0];
            AbonatTelefonic abonatDeEditat = (AbonatTelefonic)randSelectat.Tag;

            AbonatiTelefonici frm = new AbonatiTelefonici(abonatDeEditat);

            if (frm.ShowDialog() == DialogResult.OK)
            {

                AbonatTelefonic abonatModificat = frm.AbonatCreat;

                if (abonatModificat != null)
                {

                    randSelectat.Cells[0].Value = abonatModificat.IdAbonament;
                    randSelectat.Cells[1].Value = abonatModificat.Client.Nume;
                    randSelectat.Cells[2].Value = abonatModificat.Client.Prenume;
                    randSelectat.Cells[3].Value = abonatModificat.Client.Telefon;
                    randSelectat.Cells[4].Value = abonatModificat.AbonamentAles.Denumire;

                    randSelectat.Tag = abonatModificat;

                    int index = _listaAbonati.FindIndex(a => a.IdAbonament == abonatDeEditat.IdAbonament);
                    if (index != -1)
                    {
                        _listaAbonati[index] = abonatModificat;
                    }
                    _db.SaveChanges();

                    MessageBox.Show("Datele abonatului au fost actualizate cu succes!", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
        }

        private void toolStergeAbonat_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Va rugam sa selectati mai intai un abonat din tabel pentru a-l sterge!",
                    "Atentie", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DataGridViewRow randSelectat = dataGridView1.SelectedRows[0];
            AbonatTelefonic abonatInterfata = (AbonatTelefonic)randSelectat.Tag;

            DialogResult rezultat = MessageBox.Show($"Sunteti sigur ca doriti sa stergeti abonatul {abonatInterfata.Client.Nume} {abonatInterfata.Client.Prenume}?",
                "Confirmare stergere", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (rezultat == DialogResult.Yes)
            {
                try
                {
                    var abonatDb = _db.Abonati.Find(abonatInterfata.IdAbonament);

                    if (abonatDb != null)
                    {
                        _db.Database.ExecuteSqlCommand($"DELETE FROM ExtraOptiunis WHERE AbonatTelefonic_IdAbonament = {abonatDb.IdAbonament}");

                        if (abonatDb.Client != null)
                        {
                            _db.Entry(abonatDb.Client).State = System.Data.Entity.EntityState.Deleted;
                        }

                        _db.Abonati.Remove(abonatDb);
                        _db.SaveChanges();
                    }

                    _listaAbonati.Remove(abonatInterfata);
                    dataGridView1.Rows.Remove(randSelectat);

                    MessageBox.Show("Abonatul și datele clientului au fost eliminate definitiv din Baza de Date!", "Succes",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    string inner = ex.InnerException != null ? "\nDetalii: " + ex.InnerException.Message : "";
                    if (ex.InnerException?.InnerException != null)
                    {
                        inner += "\nCauza profunda: " + ex.InnerException.InnerException.Message;
                    }

                    MessageBox.Show("Eroare la stergere: " + ex.Message + inner, "Eroare",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void salvareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Fișiere Text (*.txt)|*.txt|Toate fișierele (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    using (System.IO.StreamWriter streamWriter = new System.IO.StreamWriter(saveFileDialog.FileName))
                    {
                        foreach (AbonatTelefonic abonat in _listaAbonati)
                        {
                            streamWriter.WriteLine($"{abonat.IdAbonament},{abonat.Client.Nume},{abonat.Client.Prenume},{abonat.Client.Telefon},{abonat.AbonamentAles.Denumire}");
                        }
                    }
                    MessageBox.Show("Datele au fost salvate cu succes in fisier!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la salvarea datelor: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void actualizareAbonatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolEditeazaAbonat_Click(sender, e);
        }

        private void stergeAbonatToolStrip_Click(object sender, EventArgs e)
        {
            toolStergeAbonat_Click(sender, e);
        }




        private void dataGridView1_DragDrop(object sender, DragEventArgs e)
        {
            string[] fisiere = (string[])e.Data.GetData(DataFormats.FileDrop);

            if (fisiere.Length > 0)
            {
                string caleFisier = fisiere[0];
                try
                {
                    using (System.IO.StreamReader streamReader = new System.IO.StreamReader(caleFisier))
                    {
                        string linie;

                        _listaAbonati.Clear();
                        dataGridView1.Rows.Clear();

                        streamReader.ReadLine();
                        streamReader.ReadLine();

                        while ((linie = streamReader.ReadLine()) != null)
                        {
                            if (string.IsNullOrWhiteSpace(linie)) continue;

                            string[] valori = linie.Split('|');

                            if (valori.Length >= 5)
                            {
                                int id = int.Parse(valori[0].Trim());

                                Client client = new Client(id, valori[1].Trim(), valori[2].Trim(), valori[3].Trim(), "", "", "");
                                TipAbonament abonament = new TipAbonament(1, valori[4].Trim(), 0);

                                AbonatTelefonic abonat = new AbonatTelefonic(id, client, abonament, new List<ExtraOptiuni>());

                                _listaAbonati.Add(abonat);

                                int indexRand = dataGridView1.Rows.Add(new object[] {
                                abonat.IdAbonament,
                                abonat.Client.Nume,
                                abonat.Client.Prenume,
                                abonat.Client.Telefon,
                                abonat.AbonamentAles.Denumire
                                });

                                dataGridView1.Rows[indexRand].Tag = abonat;
                            }
                        }
                    }
                    toolStripStatusLabel1.Text = $"Fisier procesat cu succes. Număr abonati: {dataGridView1.Rows.Count}";
                    MessageBox.Show("Fisierul text a fost incarcat cu succes!", "Succes", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Eroare la procesarea fisierului: " + ex.Message, "Eroare", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void dataGridView1_DragEnter(object sender, DragEventArgs e)
        {

            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Graphics g = e.Graphics;
            Font fontTitlu = new Font("Arial", 16, FontStyle.Bold);
            Font fontContinut = new Font("Arial", 11, FontStyle.Regular);
            Font fontBold = new Font("Arial", 11, FontStyle.Bold);

            g.DrawString("FACTURA SERVICII TELEFONICE", fontTitlu, Brushes.Navy, 100, 100);
            g.DrawLine(Pens.Black, 100, 135, 700, 135);

            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow rand = dataGridView1.SelectedRows[0];

     
                AbonatTelefonic abonat = rand.Tag as AbonatTelefonic;

                if (abonat != null)
                {
                    
                    double pretBaza = 0;
                    string denumire = abonat.AbonamentAles?.Denumire ?? "";

                    if (denumire == "Standard") pretBaza = 30;
                    else if (denumire == "Premium") pretBaza = 60;
                    else if (denumire == "Business") pretBaza = 100;

                    double pretExtra = 0;
                    if (abonat.OptiuniSalvate != null)
                    {
                        pretExtra = abonat.OptiuniSalvate.Count * 10;
                    }

                    double totalDePlata = pretBaza + pretExtra;


                    g.DrawString($"ID Abonament: {abonat.IdAbonament}", fontBold, Brushes.Black, 100, 170);
                    g.DrawString($"Client: {abonat.Client.Nume} {abonat.Client.Prenume}", fontContinut, Brushes.Black, 100, 200);
                    g.DrawString($"Telefon: {abonat.Client.Telefon}", fontContinut, Brushes.Black, 100, 230);
                    g.DrawString($"Abonament: {denumire} ({pretBaza} RON)", fontContinut, Brushes.Black, 100, 260);
                    g.DrawString($"Extraopțiuni active: {abonat.OptiuniSalvate?.Count ?? 0} (+{pretExtra} RON)", fontContinut, Brushes.Black, 100, 290);

                    g.DrawLine(Pens.Black, 100, 330, 700, 330);
                    g.DrawString($"Total de plată: {totalDePlata} RON", fontBold, Brushes.DarkRed, 100, 360);
                }
                else
                {
                    g.DrawString("Eroare la recuperarea datelor abonatului.", fontContinut, Brushes.Red, 100, 170);
                }
            }
            else
            {
                g.DrawString("Selectati un rand din tabel pentru a genera factura!", fontContinut, Brushes.Red, 100, 170);
            }
        }

        private void previzualizareFacturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            printPreviewDialog1.WindowState = FormWindowState.Maximized;
            printPreviewDialog1.ShowDialog();
        }

        private void imprimareToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }


    }






}
