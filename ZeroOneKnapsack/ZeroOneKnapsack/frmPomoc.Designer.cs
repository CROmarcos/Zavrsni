namespace ZeroOneKnapsack
{
    partial class frmPomoc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPomoc));
            this.lbNaslov = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbNaslov
            // 
            this.lbNaslov.AutoSize = true;
            this.lbNaslov.Font = new System.Drawing.Font("Century Schoolbook", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNaslov.ForeColor = System.Drawing.Color.MidnightBlue;
            this.lbNaslov.Location = new System.Drawing.Point(98, 18);
            this.lbNaslov.Name = "lbNaslov";
            this.lbNaslov.Size = new System.Drawing.Size(294, 32);
            this.lbNaslov.TabIndex = 2;
            this.lbNaslov.Text = "Zero-One Knapsack";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Schoolbook", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(138, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pomoć za korisnike";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 107);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(463, 51);
            this.label2.TabIndex = 4;
            this.label2.Text = "Dobrodošli u Zero-One Knapsack aplikaciju. Zero-One Knapsack\r\nkalkulator je za rj" +
    "ešavanje problema ranca, konkretno za problem 0-1,\r\nodnosno hoće li varijabla il" +
    "i neće biti u rancu.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(15, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(465, 102);
            this.label3.TabIndex = 5;
            this.label3.Text = resources.GetString("label3.Text");
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(15, 287);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(448, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "U svakom trenutku unošenja rezultata moguće je odustati pritiskom\r\nna tipku Odust" +
    "ani, koja Vas vraća na početnu stranicu.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(15, 333);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(411, 34);
            this.label5.TabIndex = 7;
            this.label5.Text = "Za pitanja i nejasnoće, ili primijećene greške u radu aplikacije,\r\nobratite se au" +
    "toru aplikacije.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Schoolbook", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(122, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(232, 68);
            this.label6.TabIndex = 8;
            this.label6.Text = "Izradio: Marko Fabijan Pavlović\r\nmarpavlov@foi.hr\r\nVaraždin, 2017\r\nFakultet organ" +
    "izacije i informatike";
            this.label6.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // frmPomoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 511);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbNaslov);
            this.Name = "frmPomoc";
            this.Text = "Zero-One Knapsack - Pomoć";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbNaslov;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}