namespace Przeglądarka
{
    partial class Przegladarka
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Przegladarka));
            this.Web = new System.Windows.Forms.WebBrowser();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btbOdswierz = new System.Windows.Forms.Button();
            this.btbWyszukaj = new System.Windows.Forms.Button();
            this.txtLine = new System.Windows.Forms.TextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.oProgramieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.wyjścieToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.autorzyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ądakaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbLista = new System.Windows.Forms.ComboBox();
            this.btbZakladki = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Web
            // 
            this.Web.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Web.Location = new System.Drawing.Point(0, 24);
            this.Web.MinimumSize = new System.Drawing.Size(20, 20);
            this.Web.Name = "Web";
            this.Web.Size = new System.Drawing.Size(1298, 486);
            this.Web.TabIndex = 0;
            this.Web.DocumentCompleted += new System.Windows.Forms.WebBrowserDocumentCompletedEventHandler(this.Web_DocumentCompleted);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(292, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "<";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(322, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(24, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = ">";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btbOdswierz
            // 
            this.btbOdswierz.Location = new System.Drawing.Point(352, 1);
            this.btbOdswierz.Name = "btbOdswierz";
            this.btbOdswierz.Size = new System.Drawing.Size(81, 23);
            this.btbOdswierz.TabIndex = 3;
            this.btbOdswierz.Text = "Odświerz";
            this.btbOdswierz.UseVisualStyleBackColor = true;
            this.btbOdswierz.Click += new System.EventHandler(this.btbOdswierz_Click);
            // 
            // btbWyszukaj
            // 
            this.btbWyszukaj.Location = new System.Drawing.Point(1198, 1);
            this.btbWyszukaj.Name = "btbWyszukaj";
            this.btbWyszukaj.Size = new System.Drawing.Size(88, 23);
            this.btbWyszukaj.TabIndex = 4;
            this.btbWyszukaj.Text = "Wyszukaj";
            this.btbWyszukaj.UseVisualStyleBackColor = true;
            this.btbWyszukaj.Click += new System.EventHandler(this.btbWyszukaj_Click);
            // 
            // txtLine
            // 
            this.txtLine.Location = new System.Drawing.Point(439, 3);
            this.txtLine.Name = "txtLine";
            this.txtLine.Size = new System.Drawing.Size(511, 20);
            this.txtLine.TabIndex = 5;
            this.txtLine.Text = "http://";
            this.txtLine.TextChanged += new System.EventHandler(this.txtLine_TextChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.oProgramieToolStripMenuItem,
            this.wyjścieToolStripMenuItem,
            this.autorzyToolStripMenuItem,
            this.ądakaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1298, 24);
            this.menuStrip1.TabIndex = 6;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // oProgramieToolStripMenuItem
            // 
            this.oProgramieToolStripMenuItem.Name = "oProgramieToolStripMenuItem";
            this.oProgramieToolStripMenuItem.Size = new System.Drawing.Size(86, 20);
            this.oProgramieToolStripMenuItem.Text = "O programie";
            this.oProgramieToolStripMenuItem.Click += new System.EventHandler(this.oProgramieToolStripMenuItem_Click);
            // 
            // wyjścieToolStripMenuItem
            // 
            this.wyjścieToolStripMenuItem.Name = "wyjścieToolStripMenuItem";
            this.wyjścieToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.wyjścieToolStripMenuItem.Text = "Wyjście";
            this.wyjścieToolStripMenuItem.Click += new System.EventHandler(this.wyjścieToolStripMenuItem_Click);
            // 
            // autorzyToolStripMenuItem
            // 
            this.autorzyToolStripMenuItem.Name = "autorzyToolStripMenuItem";
            this.autorzyToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.autorzyToolStripMenuItem.Text = "Autorzy";
            this.autorzyToolStripMenuItem.Click += new System.EventHandler(this.autorzyToolStripMenuItem_Click);
            // 
            // ądakaToolStripMenuItem
            // 
            this.ądakaToolStripMenuItem.Name = "ądakaToolStripMenuItem";
            this.ądakaToolStripMenuItem.Size = new System.Drawing.Size(85, 20);
            this.ądakaToolStripMenuItem.Text = "Jak powstala";
            this.ądakaToolStripMenuItem.Click += new System.EventHandler(this.ądakaToolStripMenuItem_Click);
            // 
            // cmbLista
            // 
            this.cmbLista.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbLista.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbLista.DropDownHeight = 100;
            this.cmbLista.FormattingEnabled = true;
            this.cmbLista.IntegralHeight = false;
            this.cmbLista.Items.AddRange(new object[] {
            "http://grykomputerowenews.cba.pl/konkurs%20programowania/index.html",
            "http://musicforlive.cba.pl",
            "http://nowosciosamochodach.cba.pl/Strona%20konkurs/Index.html",
            "http://swiatttechnologii.cba.pl/"});
            this.cmbLista.Location = new System.Drawing.Point(956, 3);
            this.cmbLista.Name = "cmbLista";
            this.cmbLista.Size = new System.Drawing.Size(115, 21);
            this.cmbLista.Sorted = true;
            this.cmbLista.TabIndex = 7;
            this.cmbLista.SelectedIndexChanged += new System.EventHandler(this.cmbLista_SelectedIndexChanged);
            // 
            // btbZakladki
            // 
            this.btbZakladki.Location = new System.Drawing.Point(1077, 1);
            this.btbZakladki.Name = "btbZakladki";
            this.btbZakladki.Size = new System.Drawing.Size(115, 23);
            this.btbZakladki.TabIndex = 8;
            this.btbZakladki.Text = "Dodaj zakładkę";
            this.btbZakladki.UseVisualStyleBackColor = true;
            this.btbZakladki.Click += new System.EventHandler(this.btbZakladki_Click);
            // 
            // Przegladarka
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ClientSize = new System.Drawing.Size(1298, 510);
            this.Controls.Add(this.btbZakladki);
            this.Controls.Add(this.cmbLista);
            this.Controls.Add(this.txtLine);
            this.Controls.Add(this.btbWyszukaj);
            this.Controls.Add(this.btbOdswierz);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Web);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Przegladarka";
            this.Text = "Edu-Przeglądarka";
            this.Load += new System.EventHandler(this.Przegladarka_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.WebBrowser Web;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btbOdswierz;
        private System.Windows.Forms.Button btbWyszukaj;
        private System.Windows.Forms.TextBox txtLine;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem oProgramieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem wyjścieToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem autorzyToolStripMenuItem;
        private System.Windows.Forms.ComboBox cmbLista;
        private System.Windows.Forms.Button btbZakladki;
        private System.Windows.Forms.ToolStripMenuItem ądakaToolStripMenuItem;
    }
}

