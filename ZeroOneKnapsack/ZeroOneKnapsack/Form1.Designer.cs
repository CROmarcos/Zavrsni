namespace ZeroOneKnapsack
{
    partial class Form1
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
            this.btnDalje = new System.Windows.Forms.Button();
            this.lbNaslov = new System.Windows.Forms.Label();
            this.btnPomoc = new System.Windows.Forms.Button();
            this.lbBrojVar = new System.Windows.Forms.Label();
            this.lbKapacitet = new System.Windows.Forms.Label();
            this.tbBrojVar = new System.Windows.Forms.TextBox();
            this.tbKapacitet = new System.Windows.Forms.TextBox();
            this.btnUnesi = new System.Windows.Forms.Button();
            this.lbNetoVrijednost = new System.Windows.Forms.Label();
            this.lbTezinskaVrijednost = new System.Windows.Forms.Label();
            this.tbNetoVrijednost = new System.Windows.Forms.TextBox();
            this.tbTezinskaVrijednost = new System.Windows.Forms.TextBox();
            this.lbPreostalo = new System.Windows.Forms.Label();
            this.lbRjesenjeText = new System.Windows.Forms.Label();
            this.lbRjesenjeIznos = new System.Windows.Forms.Label();
            this.lbVarURancu = new System.Windows.Forms.Label();
            this.lbVarURancuIspis = new System.Windows.Forms.Label();
            this.btnPovratak = new System.Windows.Forms.Button();
            this.btnOdustani = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDalje
            // 
            this.btnDalje.BackColor = System.Drawing.Color.Silver;
            this.btnDalje.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDalje.Location = new System.Drawing.Point(124, 177);
            this.btnDalje.Name = "btnDalje";
            this.btnDalje.Size = new System.Drawing.Size(126, 29);
            this.btnDalje.TabIndex = 0;
            this.btnDalje.Text = "Dalje >>";
            this.btnDalje.UseVisualStyleBackColor = false;
            this.btnDalje.Click += new System.EventHandler(this.btnDalje_Click);
            // 
            // lbNaslov
            // 
            this.lbNaslov.AutoSize = true;
            this.lbNaslov.Font = new System.Drawing.Font("Century Schoolbook", 26F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaslov.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.lbNaslov.Location = new System.Drawing.Point(1, 74);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(373, 41);
            this.lbNaslov.TabIndex = 1;
            this.lbNaslov.Text = "Zero-One Knapsack";
            // 
            // btnPomoc
            // 
            this.btnPomoc.BackColor = System.Drawing.Color.Silver;
            this.btnPomoc.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPomoc.Location = new System.Drawing.Point(23, 24);
            this.btnPomoc.Name = "btnPomoc";
            this.btnPomoc.Size = new System.Drawing.Size(94, 26);
            this.btnPomoc.TabIndex = 2;
            this.btnPomoc.Text = "Pomoć";
            this.btnPomoc.UseVisualStyleBackColor = false;
            this.btnPomoc.Click += new System.EventHandler(this.btnPomoc_Click);
            // 
            // lbBrojVar
            // 
            this.lbBrojVar.AutoSize = true;
            this.lbBrojVar.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbBrojVar.Location = new System.Drawing.Point(41, 94);
            this.lbBrojVar.Name = "lbBrojVar";
            this.lbBrojVar.Size = new System.Drawing.Size(213, 16);
            this.lbBrojVar.TabIndex = 3;
            this.lbBrojVar.Text = "Koliko varijabli želite unijeti?";
            // 
            // lbKapacitet
            // 
            this.lbKapacitet.AutoSize = true;
            this.lbKapacitet.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbKapacitet.Location = new System.Drawing.Point(41, 128);
            this.lbKapacitet.Name = "lbKapacitet";
            this.lbKapacitet.Size = new System.Drawing.Size(183, 16);
            this.lbKapacitet.TabIndex = 4;
            this.lbKapacitet.Text = "Koliki je kapacitet ranca?";
            // 
            // tbBrojVar
            // 
            this.tbBrojVar.Location = new System.Drawing.Point(280, 93);
            this.tbBrojVar.Name = "tbBrojVar";
            this.tbBrojVar.Size = new System.Drawing.Size(42, 20);
            this.tbBrojVar.TabIndex = 5;
            this.tbBrojVar.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbBrojVar_KeyPress);
            // 
            // tbKapacitet
            // 
            this.tbKapacitet.Location = new System.Drawing.Point(280, 124);
            this.tbKapacitet.Name = "tbKapacitet";
            this.tbKapacitet.Size = new System.Drawing.Size(42, 20);
            this.tbKapacitet.TabIndex = 6;
            this.tbKapacitet.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbKapacitet_KeyPress);
            // 
            // btnUnesi
            // 
            this.btnUnesi.BackColor = System.Drawing.Color.Silver;
            this.btnUnesi.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUnesi.Location = new System.Drawing.Point(124, 180);
            this.btnUnesi.Name = "btnUnesi";
            this.btnUnesi.Size = new System.Drawing.Size(126, 29);
            this.btnUnesi.TabIndex = 7;
            this.btnUnesi.Text = "Unesi";
            this.btnUnesi.UseVisualStyleBackColor = false;
            this.btnUnesi.Click += new System.EventHandler(this.btnUnesi_Click);
            // 
            // lbNetoVrijednost
            // 
            this.lbNetoVrijednost.AutoSize = true;
            this.lbNetoVrijednost.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNetoVrijednost.Location = new System.Drawing.Point(41, 100);
            this.lbNetoVrijednost.Name = "lbNetoVrijednost";
            this.lbNetoVrijednost.Size = new System.Drawing.Size(178, 16);
            this.lbNetoVrijednost.TabIndex = 8;
            this.lbNetoVrijednost.Text = "Neto vrijednost varijable";
            // 
            // lbTezinskaVrijednost
            // 
            this.lbTezinskaVrijednost.AutoSize = true;
            this.lbTezinskaVrijednost.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTezinskaVrijednost.Location = new System.Drawing.Point(41, 126);
            this.lbTezinskaVrijednost.Name = "lbTezinskaVrijednost";
            this.lbTezinskaVrijednost.Size = new System.Drawing.Size(206, 16);
            this.lbTezinskaVrijednost.TabIndex = 9;
            this.lbTezinskaVrijednost.Text = "Težinska vrijednost varijable";
            // 
            // tbNetoVrijednost
            // 
            this.tbNetoVrijednost.Location = new System.Drawing.Point(280, 99);
            this.tbNetoVrijednost.Name = "tbNetoVrijednost";
            this.tbNetoVrijednost.Size = new System.Drawing.Size(42, 20);
            this.tbNetoVrijednost.TabIndex = 10;
            this.tbNetoVrijednost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNetoVrijednost_KeyPress);
            // 
            // tbTezinskaVrijednost
            // 
            this.tbTezinskaVrijednost.Location = new System.Drawing.Point(280, 128);
            this.tbTezinskaVrijednost.Name = "tbTezinskaVrijednost";
            this.tbTezinskaVrijednost.Size = new System.Drawing.Size(42, 20);
            this.tbTezinskaVrijednost.TabIndex = 11;
            this.tbTezinskaVrijednost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTezinskaVrijednost_KeyPress);
            // 
            // lbPreostalo
            // 
            this.lbPreostalo.AutoSize = true;
            this.lbPreostalo.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbPreostalo.Location = new System.Drawing.Point(41, 68);
            this.lbPreostalo.Name = "lbPreostalo";
            this.lbPreostalo.Size = new System.Drawing.Size(146, 16);
            this.lbPreostalo.TabIndex = 12;
            this.lbPreostalo.Text = "Preostalo za unijeti:";
            // 
            // lbRjesenjeText
            // 
            this.lbRjesenjeText.AutoSize = true;
            this.lbRjesenjeText.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRjesenjeText.Location = new System.Drawing.Point(131, 49);
            this.lbRjesenjeText.Name = "lbRjesenjeText";
            this.lbRjesenjeText.Size = new System.Drawing.Size(105, 25);
            this.lbRjesenjeText.TabIndex = 13;
            this.lbRjesenjeText.Text = "Rješenje:";
            this.lbRjesenjeText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbRjesenjeIznos
            // 
            this.lbRjesenjeIznos.AutoSize = true;
            this.lbRjesenjeIznos.Font = new System.Drawing.Font("Century Schoolbook", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbRjesenjeIznos.Location = new System.Drawing.Point(164, 84);
            this.lbRjesenjeIznos.Name = "lbRjesenjeIznos";
            this.lbRjesenjeIznos.Size = new System.Drawing.Size(23, 25);
            this.lbRjesenjeIznos.TabIndex = 14;
            this.lbRjesenjeIznos.Text = "0";
            this.lbRjesenjeIznos.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbVarURancu
            // 
            this.lbVarURancu.AutoSize = true;
            this.lbVarURancu.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVarURancu.Location = new System.Drawing.Point(55, 126);
            this.lbVarURancu.Name = "lbVarURancu";
            this.lbVarURancu.Size = new System.Drawing.Size(132, 16);
            this.lbVarURancu.TabIndex = 15;
            this.lbVarURancu.Text = "Varijable u rancu:";
            this.lbVarURancu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lbVarURancuIspis
            // 
            this.lbVarURancuIspis.AutoSize = true;
            this.lbVarURancuIspis.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVarURancuIspis.Location = new System.Drawing.Point(193, 126);
            this.lbVarURancuIspis.Name = "lbVarURancuIspis";
            this.lbVarURancuIspis.Size = new System.Drawing.Size(15, 16);
            this.lbVarURancuIspis.TabIndex = 16;
            this.lbVarURancuIspis.Text = "0";
            this.lbVarURancuIspis.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPovratak
            // 
            this.btnPovratak.BackColor = System.Drawing.Color.Silver;
            this.btnPovratak.Font = new System.Drawing.Font("Century Schoolbook", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPovratak.Location = new System.Drawing.Point(136, 165);
            this.btnPovratak.Name = "btnPovratak";
            this.btnPovratak.Size = new System.Drawing.Size(101, 47);
            this.btnPovratak.TabIndex = 17;
            this.btnPovratak.Text = "Vrati se na početak";
            this.btnPovratak.UseVisualStyleBackColor = false;
            this.btnPovratak.Click += new System.EventHandler(this.btnPovratak_Click);
            // 
            // btnOdustani
            // 
            this.btnOdustani.BackColor = System.Drawing.Color.Silver;
            this.btnOdustani.Font = new System.Drawing.Font("Century Schoolbook", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOdustani.Location = new System.Drawing.Point(256, 24);
            this.btnOdustani.Name = "btnOdustani";
            this.btnOdustani.Size = new System.Drawing.Size(94, 26);
            this.btnOdustani.TabIndex = 18;
            this.btnOdustani.Text = "Odustani";
            this.btnOdustani.UseVisualStyleBackColor = false;
            this.btnOdustani.Click += new System.EventHandler(this.btnOdustani_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(373, 250);
            this.Controls.Add(this.btnOdustani);
            this.Controls.Add(this.btnPovratak);
            this.Controls.Add(this.lbVarURancuIspis);
            this.Controls.Add(this.lbVarURancu);
            this.Controls.Add(this.lbRjesenjeIznos);
            this.Controls.Add(this.lbRjesenjeText);
            this.Controls.Add(this.lbPreostalo);
            this.Controls.Add(this.tbTezinskaVrijednost);
            this.Controls.Add(this.tbNetoVrijednost);
            this.Controls.Add(this.lbTezinskaVrijednost);
            this.Controls.Add(this.lbNetoVrijednost);
            this.Controls.Add(this.btnUnesi);
            this.Controls.Add(this.tbKapacitet);
            this.Controls.Add(this.tbBrojVar);
            this.Controls.Add(this.lbKapacitet);
            this.Controls.Add(this.lbBrojVar);
            this.Controls.Add(this.btnPomoc);
            this.Controls.Add(this.lbNaslov);
            this.Controls.Add(this.btnDalje);
            this.Name = "Form1";
            this.Text = "Zero-One Knapsack";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDalje;
        private System.Windows.Forms.Label lbNaslov;
        private System.Windows.Forms.Button btnPomoc;
        private System.Windows.Forms.Label lbBrojVar;
        private System.Windows.Forms.Label lbKapacitet;
        private System.Windows.Forms.TextBox tbBrojVar;
        private System.Windows.Forms.TextBox tbKapacitet;
        private System.Windows.Forms.Button btnUnesi;
        private System.Windows.Forms.Label lbNetoVrijednost;
        private System.Windows.Forms.Label lbTezinskaVrijednost;
        private System.Windows.Forms.TextBox tbNetoVrijednost;
        private System.Windows.Forms.TextBox tbTezinskaVrijednost;
        private System.Windows.Forms.Label lbPreostalo;
        private System.Windows.Forms.Label lbRjesenjeText;
        private System.Windows.Forms.Label lbRjesenjeIznos;
        private System.Windows.Forms.Label lbVarURancu;
        private System.Windows.Forms.Label lbVarURancuIspis;
        private System.Windows.Forms.Button btnPovratak;
        private System.Windows.Forms.Button btnOdustani;
    }
}

