using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZeroOneKnapsack
{
    public partial class Form1 : Form
    {
        bool pocetna;
        int brojVar, brojac, preostalo;
        Ranac ranac;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Pocetna();
        }

        private void btnDalje_Click(object sender, EventArgs e)
        {
            if (pocetna)
            {
                BackColor = Color.LemonChiffon;
                pocetna = false;

                btnPomoc.Visible = true;
                btnOdustani.Visible = true;
                lbNaslov.Visible = false;

                lbBrojVar.Visible = true;
                lbKapacitet.Visible = true;
                tbBrojVar.Visible = true;
                tbKapacitet.Visible = true;
            }
            else
            {
                btnDalje.Visible = false;
                lbBrojVar.Visible = false;
                lbKapacitet.Visible = false;
                tbBrojVar.Visible = false;
                tbKapacitet.Visible = false;

                lbNetoVrijednost.Visible = true;
                lbTezinskaVrijednost.Visible = true;
                tbNetoVrijednost.Visible = true;
                tbTezinskaVrijednost.Visible = true;
                tbPreostalo.Visible = true;

                btnUnesi.Visible = true;

                ranac.Kapacitet = Convert.ToInt32(tbKapacitet.Text);
                brojVar = Convert.ToInt32(tbBrojVar.Text);
                preostalo = brojVar;
                tbPreostalo.Text = "Preostalo za unijeti: " + (preostalo).ToString();
            }
        }

        private void btnPovratak_Click(object sender, EventArgs e)
        {
            Pocetna();
        }

        private void btnOdustani_Click(object sender, EventArgs e)
        {
            DialogResult pitanje = MessageBox.Show("Želite li stvarno odustati?", "Odustani", MessageBoxButtons.YesNo);
            if (pitanje == DialogResult.Yes)
            {
                Pocetna();
            }
        }

        private void btnUnesi_Click(object sender, EventArgs e)
        {
            if (brojac < brojVar)
            {
                Varijabla varijabla = new Varijabla();
                varijabla.Naziv = "X" + (brojac + 1).ToString();
                varijabla.NetoVrijednost = Convert.ToInt32(tbNetoVrijednost.Text);
                varijabla.TezinskaVrijednost = Convert.ToInt32(tbTezinskaVrijednost.Text);
                ranac.ListaUnosa.Add(varijabla);
                brojac++;
                preostalo--;
                tbPreostalo.Text = "Preostalo za unijeti: " + (preostalo).ToString();
            }
            if (brojac == brojVar)
            {
                ranac.Sortiraj();
                ranac.DodajVarijable();

                lbNetoVrijednost.Visible = false;
                lbTezinskaVrijednost.Visible = false;
                tbNetoVrijednost.Visible = false;
                tbTezinskaVrijednost.Visible = false;
                tbPreostalo.Visible = false;
                btnUnesi.Visible = false;
                btnPomoc.Visible = false;
                btnOdustani.Visible = false;

                lbRjesenjeIznos.Text = ranac.IspisiIznos();
                lbVarURancuIspis.Text = ranac.IspisiVarijable();
                lbRjesenjeText.Visible = true;
                lbRjesenjeIznos.Visible = true;
                lbVarURancu.Visible = true;
                lbVarURancuIspis.Visible = true;
                btnPovratak.Visible = true;
            }
        }

        public void Pocetna()
        {
            foreach (Control x in this.Controls)
            {
                if (x is TextBox)
                {
                    ((TextBox)x).Text = String.Empty;
                }
            }

            ranac = new Ranac();
            pocetna = true;
            BackColor = Color.MidnightBlue;
            brojac = 0;

            btnPomoc.Visible = false;
            btnOdustani.Visible = false;
            btnUnesi.Visible = false;
            btnPovratak.Visible = false;

            lbBrojVar.Visible = false;
            lbKapacitet.Visible = false;
            tbBrojVar.Visible = false;
            tbKapacitet.Visible = false;

            lbNetoVrijednost.Visible = false;
            lbTezinskaVrijednost.Visible = false;
            tbNetoVrijednost.Visible = false;
            tbTezinskaVrijednost.Visible = false;
            tbPreostalo.Visible = false;

            btnDalje.Visible = true;
            lbNaslov.Visible = true;

            lbRjesenjeText.Visible = false;
            lbRjesenjeIznos.Visible = false;
            lbVarURancu.Visible = false;
            lbVarURancuIspis.Visible = false;
        }
    }
}
