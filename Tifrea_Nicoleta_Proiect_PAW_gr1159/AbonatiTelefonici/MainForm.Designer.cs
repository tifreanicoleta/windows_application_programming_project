namespace AbonatiTelefonici
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            menuStrip1 = new MenuStrip();
            fisierToolStripMenuItem = new ToolStripMenuItem();
            salvareToolStripMenuItem = new ToolStripMenuItem();
            incarcaredateToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem1 = new ToolStripSeparator();
            exportCaToolStripMenuItem = new ToolStripMenuItem();
            fisierTextToolStripMenuItem = new ToolStripMenuItem();
            previzualizareFacturaToolStripMenuItem = new ToolStripMenuItem();
            imprimareToolStripMenuItem = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripSeparator();
            iesireToolStripMenuItem = new ToolStripMenuItem();
            gestionareAbonatiToolStripMenuItem = new ToolStripMenuItem();
            adaugaAbonatiToolStripMenuItem = new ToolStripMenuItem();
            actualizareAbonatToolStripMenuItem = new ToolStripMenuItem();
            stergeAbonatToolStrip = new ToolStripMenuItem();
            toolStrip1 = new ToolStrip();
            toolAdaugaAbonat = new ToolStripButton();
            toolStripSeparator1 = new ToolStripSeparator();
            toolEditeazaAbonat = new ToolStripButton();
            toolStripSeparator2 = new ToolStripSeparator();
            toolStergeAbonat = new ToolStripButton();
            toolStripSeparator3 = new ToolStripSeparator();
            toolStripButton4 = new ToolStripButton();
            dataGridView1 = new DataGridView();
            printDocument1 = new System.Drawing.Printing.PrintDocument();
            printDialog1 = new PrintDialog();
            printPreviewDialog1 = new PrintPreviewDialog();
            statusStrip1 = new StatusStrip();
            toolStripStatusLabel1 = new ToolStripStatusLabel();
            id_abonament = new DataGridViewTextBoxColumn();
            Nume = new DataGridViewTextBoxColumn();
            Prenume = new DataGridViewTextBoxColumn();
            Telefon = new DataGridViewTextBoxColumn();
            tip_abonament = new DataGridViewTextBoxColumn();
            menuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            statusStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { fisierToolStripMenuItem, gestionareAbonatiToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 28);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            fisierToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { salvareToolStripMenuItem, incarcaredateToolStripMenuItem, toolStripMenuItem1, exportCaToolStripMenuItem, previzualizareFacturaToolStripMenuItem, imprimareToolStripMenuItem, toolStripMenuItem2, iesireToolStripMenuItem });
            fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            fisierToolStripMenuItem.Size = new Size(57, 24);
            fisierToolStripMenuItem.Text = "Fisier";
            // 
            // salvareToolStripMenuItem
            // 
            salvareToolStripMenuItem.Name = "salvareToolStripMenuItem";
            salvareToolStripMenuItem.Size = new Size(233, 26);
            salvareToolStripMenuItem.Text = "&Salvare ";
            salvareToolStripMenuItem.Click += salvareToolStripMenuItem_Click;
            // 
            // incarcaredateToolStripMenuItem
            // 
            incarcaredateToolStripMenuItem.Name = "incarcaredateToolStripMenuItem";
            incarcaredateToolStripMenuItem.Size = new Size(233, 26);
            incarcaredateToolStripMenuItem.Text = "&Incarcare date";
            incarcaredateToolStripMenuItem.Click += incarcaredateToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(230, 6);
            // 
            // exportCaToolStripMenuItem
            // 
            exportCaToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { fisierTextToolStripMenuItem });
            exportCaToolStripMenuItem.Name = "exportCaToolStripMenuItem";
            exportCaToolStripMenuItem.Size = new Size(233, 26);
            exportCaToolStripMenuItem.Text = "Export ca...";
            // 
            // fisierTextToolStripMenuItem
            // 
            fisierTextToolStripMenuItem.Name = "fisierTextToolStripMenuItem";
            fisierTextToolStripMenuItem.Size = new Size(161, 26);
            fisierTextToolStripMenuItem.Text = "Fisier Text ";
            // 
            // previzualizareFacturaToolStripMenuItem
            // 
            previzualizareFacturaToolStripMenuItem.Name = "previzualizareFacturaToolStripMenuItem";
            previzualizareFacturaToolStripMenuItem.Size = new Size(233, 26);
            previzualizareFacturaToolStripMenuItem.Text = "Previzualizare factura";
            previzualizareFacturaToolStripMenuItem.Click += previzualizareFacturaToolStripMenuItem_Click;
            // 
            // imprimareToolStripMenuItem
            // 
            imprimareToolStripMenuItem.Name = "imprimareToolStripMenuItem";
            imprimareToolStripMenuItem.Size = new Size(233, 26);
            imprimareToolStripMenuItem.Text = "&Imprimare";
            imprimareToolStripMenuItem.Click += imprimareToolStripMenuItem_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(230, 6);
            // 
            // iesireToolStripMenuItem
            // 
            iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            iesireToolStripMenuItem.Size = new Size(233, 26);
            iesireToolStripMenuItem.Text = "&Iesire";
            // 
            // gestionareAbonatiToolStripMenuItem
            // 
            gestionareAbonatiToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { adaugaAbonatiToolStripMenuItem, actualizareAbonatToolStripMenuItem, stergeAbonatToolStrip });
            gestionareAbonatiToolStripMenuItem.Name = "gestionareAbonatiToolStripMenuItem";
            gestionareAbonatiToolStripMenuItem.Size = new Size(151, 24);
            gestionareAbonatiToolStripMenuItem.Text = "Gestionare Abonati";
            // 
            // adaugaAbonatiToolStripMenuItem
            // 
            adaugaAbonatiToolStripMenuItem.Name = "adaugaAbonatiToolStripMenuItem";
            adaugaAbonatiToolStripMenuItem.Size = new Size(217, 26);
            adaugaAbonatiToolStripMenuItem.Text = "&Adauga abonat";
            adaugaAbonatiToolStripMenuItem.Click += adaugaAbonatiToolStripMenuItem_Click;
            // 
            // actualizareAbonatToolStripMenuItem
            // 
            actualizareAbonatToolStripMenuItem.Name = "actualizareAbonatToolStripMenuItem";
            actualizareAbonatToolStripMenuItem.Size = new Size(217, 26);
            actualizareAbonatToolStripMenuItem.Text = "&Actualizare abonat";
            actualizareAbonatToolStripMenuItem.Click += actualizareAbonatToolStripMenuItem_Click;
            // 
            // stergeAbonatToolStrip
            // 
            stergeAbonatToolStrip.Name = "stergeAbonatToolStrip";
            stergeAbonatToolStrip.Size = new Size(217, 26);
            stergeAbonatToolStrip.Text = "&Sterge abonat";
            stergeAbonatToolStrip.Click += stergeAbonatToolStrip_Click;
            // 
            // toolStrip1
            // 
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolAdaugaAbonat, toolStripSeparator1, toolEditeazaAbonat, toolStripSeparator2, toolStergeAbonat, toolStripSeparator3, toolStripButton4 });
            toolStrip1.Location = new Point(0, 28);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 27);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolAdaugaAbonat
            // 
            toolAdaugaAbonat.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolAdaugaAbonat.Image = (Image)resources.GetObject("toolAdaugaAbonat.Image");
            toolAdaugaAbonat.ImageTransparentColor = Color.Magenta;
            toolAdaugaAbonat.Name = "toolAdaugaAbonat";
            toolAdaugaAbonat.Size = new Size(29, 24);
            toolAdaugaAbonat.Text = "Adauga Abonat";
            toolAdaugaAbonat.Click += toolAdaugaAbonat_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new Size(6, 27);
            // 
            // toolEditeazaAbonat
            // 
            toolEditeazaAbonat.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolEditeazaAbonat.Image = (Image)resources.GetObject("toolEditeazaAbonat.Image");
            toolEditeazaAbonat.ImageTransparentColor = Color.Magenta;
            toolEditeazaAbonat.Name = "toolEditeazaAbonat";
            toolEditeazaAbonat.Size = new Size(29, 24);
            toolEditeazaAbonat.Text = "Modifica abonat";
            toolEditeazaAbonat.Click += toolEditeazaAbonat_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new Size(6, 27);
            // 
            // toolStergeAbonat
            // 
            toolStergeAbonat.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStergeAbonat.Image = (Image)resources.GetObject("toolStergeAbonat.Image");
            toolStergeAbonat.ImageTransparentColor = Color.Magenta;
            toolStergeAbonat.Name = "toolStergeAbonat";
            toolStergeAbonat.Size = new Size(29, 24);
            toolStergeAbonat.Text = "Sterge abonat";
            toolStergeAbonat.Click += toolStergeAbonat_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new Size(6, 27);
            // 
            // toolStripButton4
            // 
            toolStripButton4.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton4.Image = (Image)resources.GetObject("toolStripButton4.Image");
            toolStripButton4.ImageTransparentColor = Color.Magenta;
            toolStripButton4.Name = "toolStripButton4";
            toolStripButton4.Size = new Size(29, 24);
            toolStripButton4.Text = "Printeaza";
            toolStripButton4.Click += imprimareToolStripMenuItem_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowDrop = true;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.BackgroundColor = SystemColors.Window;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { id_abonament, Nume, Prenume, Telefon, tip_abonament });
            dataGridView1.Location = new Point(29, 111);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.Size = new Size(658, 300);
            dataGridView1.TabIndex = 2;
            dataGridView1.DragDrop += dataGridView1_DragDrop;
            dataGridView1.DragEnter += dataGridView1_DragEnter;
            // 
            // printDocument1
            // 
            printDocument1.PrintPage += printDocument1_PrintPage;
            // 
            // printDialog1
            // 
            printDialog1.Document = printDocument1;
            printDialog1.UseEXDialog = true;
            // 
            // printPreviewDialog1
            // 
            printPreviewDialog1.AutoScrollMargin = new Size(0, 0);
            printPreviewDialog1.AutoScrollMinSize = new Size(0, 0);
            printPreviewDialog1.ClientSize = new Size(400, 300);
            printPreviewDialog1.Document = printDocument1;
            printPreviewDialog1.Enabled = true;
            printPreviewDialog1.Icon = (Icon)resources.GetObject("printPreviewDialog1.Icon");
            printPreviewDialog1.Name = "printPreviewDialog1";
            printPreviewDialog1.Visible = false;
            // 
            // statusStrip1
            // 
            statusStrip1.ImageScalingSize = new Size(20, 20);
            statusStrip1.Items.AddRange(new ToolStripItem[] { toolStripStatusLabel1 });
            statusStrip1.Location = new Point(0, 424);
            statusStrip1.Name = "statusStrip1";
            statusStrip1.Size = new Size(800, 26);
            statusStrip1.TabIndex = 3;
            statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            toolStripStatusLabel1.Size = new Size(175, 20);
            toolStripStatusLabel1.Text = "Conectat la baza de date";
            // 
            // id_abonament
            // 
            id_abonament.HeaderText = "ID Abonament";
            id_abonament.MinimumWidth = 6;
            id_abonament.Name = "id_abonament";
            id_abonament.ReadOnly = true;
            // 
            // Nume
            // 
            Nume.HeaderText = "Nume";
            Nume.MinimumWidth = 6;
            Nume.Name = "Nume";
            Nume.ReadOnly = true;
            // 
            // Prenume
            // 
            Prenume.HeaderText = "Prenume";
            Prenume.MinimumWidth = 6;
            Prenume.Name = "Prenume";
            Prenume.ReadOnly = true;
            // 
            // Telefon
            // 
            Telefon.HeaderText = "Telefon";
            Telefon.MinimumWidth = 6;
            Telefon.Name = "Telefon";
            Telefon.ReadOnly = true;
            // 
            // tip_abonament
            // 
            tip_abonament.HeaderText = "Tip Abonament";
            tip_abonament.MinimumWidth = 6;
            tip_abonament.Name = "tip_abonament";
            tip_abonament.ReadOnly = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(statusStrip1);
            Controls.Add(dataGridView1);
            Controls.Add(toolStrip1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "MainForm";
            Text = "MainForm";
            Load += MainForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            statusStrip1.ResumeLayout(false);
            statusStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem fisierToolStripMenuItem;
        private ToolStripMenuItem exportCaToolStripMenuItem;
        private ToolStripMenuItem fisierTextToolStripMenuItem;
        private ToolStripMenuItem previzualizareFacturaToolStripMenuItem;
        private ToolStripMenuItem imprimareToolStripMenuItem;
        private ToolStripMenuItem gestionareAbonatiToolStripMenuItem;
        private ToolStripMenuItem adaugaAbonatiToolStripMenuItem;
        private ToolStripMenuItem actualizareAbonatToolStripMenuItem;
        private ToolStripMenuItem stergeAbonatToolStrip;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem iesireToolStripMenuItem;
        private ToolStripMenuItem salvareToolStripMenuItem;
        private ToolStripMenuItem incarcaredateToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStrip toolStrip1;
        private ToolStripButton toolAdaugaAbonat;
        private ToolStripButton toolEditeazaAbonat;
        private ToolStripButton toolStergeAbonat;
        private ToolStripButton toolStripButton4;
        private ToolStripSeparator toolStripSeparator1;
        private ToolStripSeparator toolStripSeparator2;
        private ToolStripSeparator toolStripSeparator3;
        private DataGridView dataGridView1;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private PrintDialog printDialog1;
        private PrintPreviewDialog printPreviewDialog1;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel toolStripStatusLabel1;
        private DataGridViewTextBoxColumn id_abonament;
        private DataGridViewTextBoxColumn Nume;
        private DataGridViewTextBoxColumn Prenume;
        private DataGridViewTextBoxColumn Telefon;
        private DataGridViewTextBoxColumn tip_abonament;
    }
}