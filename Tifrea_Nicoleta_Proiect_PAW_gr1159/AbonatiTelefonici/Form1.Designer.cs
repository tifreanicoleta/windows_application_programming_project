namespace AbonatiTelefonici
{
    partial class AbonatiTelefonici
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            NumeAbonat = new Label();
            PrenumeAbonat = new Label();
            TelefonAbonat = new Label();
            EmailAbonat = new Label();
            tbNumeAbonat = new TextBox();
            tbPrenumeAbonat = new TextBox();
            tbTelefonAbonat = new TextBox();
            tbEmailAbonat = new TextBox();
            JudetAbonat = new Label();
            comboBoxJudet = new ComboBox();
            menuStrip1 = new MenuStrip();
            fisierToolStripMenuItem = new ToolStripMenuItem();
            exportRaportCaToolStripMenuItem = new ToolStripMenuItem();
            fisiertxtToolStripMenuItem = new ToolStripMenuItem();
            fisierToolStripMenuItem1 = new ToolStripMenuItem();
            imprimareToolStripMenuItem = new ToolStripMenuItem();
            actualizareToolStripMenuItem = new ToolStripMenuItem();
            actualizareToolStripMenuItem1 = new ToolStripMenuItem();
            actualizareAbonatToolStripMenuItem = new ToolStripMenuItem();
            stergereAbonatToolStripMenuItem = new ToolStripMenuItem();
            LocalitateAbonat = new Label();
            tbLocalitateAbonat = new TextBox();
            btnSalvareAbonat = new Button();
            btnAnulareSalvareAbonat = new Button();
            errorProvider = new ErrorProvider(components);
            checkListExtraOptiuni = new CheckedListBox();
            gboxExtraoptiuni = new GroupBox();
            groupBox1 = new GroupBox();
            cbTipAbonament = new ComboBox();
            menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            gboxExtraoptiuni.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // NumeAbonat
            // 
            NumeAbonat.AutoSize = true;
            NumeAbonat.Location = new Point(67, 72);
            NumeAbonat.Name = "NumeAbonat";
            NumeAbonat.Size = new Size(52, 20);
            NumeAbonat.TabIndex = 0;
            NumeAbonat.Text = "Nume:";
            NumeAbonat.Click += NumeAbonat_Click;
            // 
            // PrenumeAbonat
            // 
            PrenumeAbonat.AutoSize = true;
            PrenumeAbonat.Location = new Point(67, 118);
            PrenumeAbonat.Name = "PrenumeAbonat";
            PrenumeAbonat.Size = new Size(70, 20);
            PrenumeAbonat.TabIndex = 1;
            PrenumeAbonat.Text = "Prenume:";
            PrenumeAbonat.Click += PrenumeAbonat_Click;
            // 
            // TelefonAbonat
            // 
            TelefonAbonat.AutoSize = true;
            TelefonAbonat.Location = new Point(67, 170);
            TelefonAbonat.Name = "TelefonAbonat";
            TelefonAbonat.Size = new Size(61, 20);
            TelefonAbonat.TabIndex = 2;
            TelefonAbonat.Text = "Telefon:";
            // 
            // EmailAbonat
            // 
            EmailAbonat.AutoSize = true;
            EmailAbonat.Location = new Point(67, 225);
            EmailAbonat.Name = "EmailAbonat";
            EmailAbonat.Size = new Size(59, 20);
            EmailAbonat.TabIndex = 3;
            EmailAbonat.Text = "E-mail: ";
            EmailAbonat.Click += EmailAbonat_Click;
            // 
            // tbNumeAbonat
            // 
            tbNumeAbonat.Location = new Point(158, 65);
            tbNumeAbonat.Name = "tbNumeAbonat";
            tbNumeAbonat.Size = new Size(214, 27);
            tbNumeAbonat.TabIndex = 4;
            // 
            // tbPrenumeAbonat
            // 
            tbPrenumeAbonat.Location = new Point(158, 111);
            tbPrenumeAbonat.Name = "tbPrenumeAbonat";
            tbPrenumeAbonat.Size = new Size(214, 27);
            tbPrenumeAbonat.TabIndex = 5;
            tbPrenumeAbonat.TextChanged += textBox2_TextChanged;
            // 
            // tbTelefonAbonat
            // 
            tbTelefonAbonat.Location = new Point(158, 167);
            tbTelefonAbonat.Name = "tbTelefonAbonat";
            tbTelefonAbonat.Size = new Size(214, 27);
            tbTelefonAbonat.TabIndex = 6;
            // 
            // tbEmailAbonat
            // 
            tbEmailAbonat.Location = new Point(158, 218);
            tbEmailAbonat.Name = "tbEmailAbonat";
            tbEmailAbonat.Size = new Size(214, 27);
            tbEmailAbonat.TabIndex = 7;
            // 
            // JudetAbonat
            // 
            JudetAbonat.AutoSize = true;
            JudetAbonat.Location = new Point(67, 279);
            JudetAbonat.Name = "JudetAbonat";
            JudetAbonat.Size = new Size(47, 20);
            JudetAbonat.TabIndex = 8;
            JudetAbonat.Text = "Judet:";
            JudetAbonat.Click += JudetAbonat_Click;
            // 
            // comboBoxJudet
            // 
            comboBoxJudet.FormattingEnabled = true;
            comboBoxJudet.Items.AddRange(new object[] { "Alba", "Arad", "Arges", "Bacau", "Bihor", "Bistrita - Nasaud", "Botosani", "Brasov", "Braila", "Buzau", "Caras - Severin", "Calarasi", "Cluj", "Constanta", "Covasna", "Dambovita", "Dolj", "Galati", "Giurgiu", "Gorj", "Harghita", "Hunedoara", "Ialomita", "Iasi", "Ilfov", "Maramures", "Mehedinti", "Mures", "Neamt", "Olt", "Prahova", "Satu Mare", "Salaj", "Sibiu", "Suceava", "Teleorman", "Timis", "Tulcea", "Vaslui", "Valcea", "Vrancea", "Municipiul Bucuresti" });
            comboBoxJudet.Location = new Point(158, 271);
            comboBoxJudet.Name = "comboBoxJudet";
            comboBoxJudet.Size = new Size(214, 28);
            comboBoxJudet.TabIndex = 9;
            comboBoxJudet.SelectedIndexChanged += comboBoxJudet_SelectedIndexChanged;
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fisierToolStripMenuItem, actualizareToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(896, 28);
            menuStrip1.TabIndex = 10;
            menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportRaportCaToolStripMenuItem, fisierToolStripMenuItem1, imprimareToolStripMenuItem });
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(57, 24);
            fisierToolStripMenuItem.Text = "Fisier";
            fisierToolStripMenuItem.Click += fisierToolStripMenuItem_Click;
            // 
            // exportRaportCaToolStripMenuItem
            // 
            exportRaportCaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fisiertxtToolStripMenuItem });
            exportRaportCaToolStripMenuItem.Name = "exportRaportCaToolStripMenuItem";
            exportRaportCaToolStripMenuItem.Size = new Size(233, 26);
            exportRaportCaToolStripMenuItem.Text = "Export raport ca...";
            // 
            // fisiertxtToolStripMenuItem
            // 
            fisiertxtToolStripMenuItem.Name = "fisiertxtToolStripMenuItem";
            fisiertxtToolStripMenuItem.Size = new Size(189, 26);
            fisiertxtToolStripMenuItem.Text = "Fisier text (.txt)";
            // 
            // fisierToolStripMenuItem1
            // 
            fisierToolStripMenuItem1.Name = "fisierToolStripMenuItem1";
            fisierToolStripMenuItem1.Size = new Size(233, 26);
            fisierToolStripMenuItem1.Text = "Previzualizare factura";
            // 
            // imprimareToolStripMenuItem
            // 
            imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            imprimareToolStripMenuItem.Size = new Size(233, 26);
            imprimareToolStripMenuItem.Text = "Imprimare ";
            // 
            // actualizareToolStripMenuItem
            // 
            actualizareToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { actualizareToolStripMenuItem1, actualizareAbonatToolStripMenuItem, stergereAbonatToolStripMenuItem });
            actualizareToolStripMenuItem.Name = "actualizareToolStripMenuItem";
            actualizareToolStripMenuItem.Size = new Size(101, 24);
            actualizareToolStripMenuItem.Text = "Actualizare ";
            actualizareToolStripMenuItem.Click += actualizareToolStripMenuItem_Click;
            // 
            // actualizareToolStripMenuItem1
            // 
            actualizareToolStripMenuItem1.Name = "actualizareToolStripMenuItem1";
            actualizareToolStripMenuItem1.Size = new Size(217, 26);
            actualizareToolStripMenuItem1.Text = "Abonat nou";
            actualizareToolStripMenuItem1.Click += actualizareToolStripMenuItem1_Click;
            // 
            // actualizareAbonatToolStripMenuItem
            // 
            actualizareAbonatToolStripMenuItem.Name = "actualizareAbonatToolStripMenuItem";
            actualizareAbonatToolStripMenuItem.Size = new Size(217, 26);
            actualizareAbonatToolStripMenuItem.Text = "Actualizare abonat";
            // 
            // stergereAbonatToolStripMenuItem
            // 
            stergereAbonatToolStripMenuItem.Name = "stergereAbonatToolStripMenuItem";
            stergereAbonatToolStripMenuItem.Size = new Size(217, 26);
            stergereAbonatToolStripMenuItem.Text = "Stergere abonat";
            // 
            // LocalitateAbonat
            // 
            LocalitateAbonat.AutoSize = true;
            LocalitateAbonat.Location = new Point(67, 317);
            LocalitateAbonat.Name = "LocalitateAbonat";
            LocalitateAbonat.Size = new Size(77, 20);
            LocalitateAbonat.TabIndex = 11;
            LocalitateAbonat.Text = "Localitate:";
            // 
            // tbLocalitateAbonat
            // 
            tbLocalitateAbonat.Location = new Point(158, 317);
            tbLocalitateAbonat.Name = "tbLocalitateAbonat";
            tbLocalitateAbonat.Size = new Size(214, 27);
            tbLocalitateAbonat.TabIndex = 12;
            tbLocalitateAbonat.TextChanged += textBox1_TextChanged;
            // 
            // btnSalvareAbonat
            // 
            btnSalvareAbonat.Location = new Point(311, 384);
            btnSalvareAbonat.Name = "btnSalvareAbonat";
            btnSalvareAbonat.Size = new Size(95, 32);
            btnSalvareAbonat.TabIndex = 13;
            btnSalvareAbonat.Text = "&Salveaza";
            btnSalvareAbonat.UseVisualStyleBackColor = true;
            btnSalvareAbonat.Click += btnSalvareAbonat_Click;
            // 
            // btnAnulareSalvareAbonat
            // 
            btnAnulareSalvareAbonat.Location = new Point(450, 384);
            btnAnulareSalvareAbonat.Name = "btnAnulareSalvareAbonat";
            btnAnulareSalvareAbonat.Size = new Size(106, 32);
            btnAnulareSalvareAbonat.TabIndex = 14;
            btnAnulareSalvareAbonat.Text = "&Anulare";
            btnAnulareSalvareAbonat.UseVisualStyleBackColor = true;
            btnAnulareSalvareAbonat.Click += btnAnulareSalvareAbonat_Click;
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // checkListExtraOptiuni
            // 
            checkListExtraOptiuni.FormattingEnabled = true;
            checkListExtraOptiuni.Items.AddRange(new object[] { "Internet 5G", "Roaming", "Internet + Minute", "Internet 5GG + Minute internationale" });
            checkListExtraOptiuni.Location = new Point(27, 26);
            checkListExtraOptiuni.Name = "checkListExtraOptiuni";
            checkListExtraOptiuni.Size = new Size(288, 114);
            checkListExtraOptiuni.TabIndex = 15;
            // 
            // gboxExtraoptiuni
            // 
            gboxExtraoptiuni.Controls.Add(checkListExtraOptiuni);
            gboxExtraoptiuni.Location = new Point(473, 170);
            gboxExtraoptiuni.Name = "gboxExtraoptiuni";
            gboxExtraoptiuni.Size = new Size(321, 167);
            gboxExtraoptiuni.TabIndex = 16;
            gboxExtraoptiuni.TabStop = false;
            gboxExtraoptiuni.Text = "Extraoptiuni Abonament";
            gboxExtraoptiuni.Enter += gboxExtraoptiuni_Enter;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cbTipAbonament);
            groupBox1.Location = new Point(473, 74);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(321, 85);
            groupBox1.TabIndex = 17;
            groupBox1.TabStop = false;
            groupBox1.Text = "Alegeti tipul de abonament";
            // 
            // cbTipAbonament
            // 
            cbTipAbonament.FormattingEnabled = true;
            cbTipAbonament.Items.AddRange(new object[] { "Standard", "Premium", "Business" });
            cbTipAbonament.Location = new Point(27, 37);
            cbTipAbonament.Name = "cbTipAbonament";
            cbTipAbonament.Size = new Size(248, 28);
            cbTipAbonament.TabIndex = 0;
            // 
            // AbonatiTelefonici
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(896, 450);
            Controls.Add(groupBox1);
            Controls.Add(gboxExtraoptiuni);
            Controls.Add(btnAnulareSalvareAbonat);
            Controls.Add(btnSalvareAbonat);
            Controls.Add(tbLocalitateAbonat);
            Controls.Add(LocalitateAbonat);
            Controls.Add(comboBoxJudet);
            Controls.Add(JudetAbonat);
            Controls.Add(tbEmailAbonat);
            Controls.Add(tbTelefonAbonat);
            Controls.Add(tbPrenumeAbonat);
            Controls.Add(tbNumeAbonat);
            Controls.Add(EmailAbonat);
            Controls.Add(TelefonAbonat);
            Controls.Add(PrenumeAbonat);
            Controls.Add(NumeAbonat);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "AbonatiTelefonici";
            Text = "Abonati Telefonici";
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            gboxExtraoptiuni.ResumeLayout(false);
            groupBox1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label NumeAbonat;
        private Label PrenumeAbonat;
        private Label TelefonAbonat;
        private Label EmailAbonat;
        private TextBox tbNumeAbonat;
        private TextBox tbPrenumeAbonat;
        private TextBox tbTelefonAbonat;
        private TextBox tbEmailAbonat;
        private Label JudetAbonat;
        private ComboBox comboBoxJudet;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem exportRaportCaToolStripMenuItem;
        private ToolStripMenuItem fisiertxtToolStripMenuItem;
        private ToolStripMenuItem fisierToolStripMenuItem1;
        private ToolStripMenuItem imprimareToolStripMenuItem;
        private Label LocalitateAbonat;
        private TextBox tbLocalitateAbonat;
        private Button btnSalvareAbonat;
        private Button btnAnulareSalvareAbonat;
        private ErrorProvider errorProvider;
        private ToolStripMenuItem actualizareToolStripMenuItem;
        private ToolStripMenuItem actualizareToolStripMenuItem1;
        private ToolStripMenuItem actualizareAbonatToolStripMenuItem;
        private ToolStripMenuItem stergereAbonatToolStripMenuItem;
        private GroupBox gboxExtraoptiuni;
        private CheckedListBox checkListExtraOptiuni;
        private GroupBox groupBox1;
        private ComboBox cbTipAbonament;
    }
}
