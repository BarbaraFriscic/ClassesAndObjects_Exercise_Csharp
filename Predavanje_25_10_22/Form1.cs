using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Predavanje_25_10_22
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Biljka prvaBiljka = new Biljka();
            prvaBiljka.ImeBiljke = "Adam";
            prvaBiljka.Vrijednost = 180.45;
            prvaBiljka.Zalijevanje = true;

            Biljka drugaBiljka = new Biljka();
            drugaBiljka.ImeBiljke = "Dracena";
            drugaBiljka.Vrijednost = 54.76;
            drugaBiljka.Zalijevanje = false;

            Biljka trecaBiljka = new Biljka();
            trecaBiljka.ImeBiljke = "Tulipan";
            trecaBiljka.Vrijednost = 72.16;
            trecaBiljka.Zalijevanje = true;

            Ispis(prvaBiljka.ImeBiljke, prvaBiljka.Vrijednost, prvaBiljka.Zalijevanje);
            Ispis(drugaBiljka.ImeBiljke, drugaBiljka.Vrijednost, drugaBiljka.Zalijevanje);
            Ispis(trecaBiljka.ImeBiljke, trecaBiljka.Vrijednost, trecaBiljka.Zalijevanje);
        }

        void Ispis (string a, double b, bool c)
        {
            
            if (c == true)
                label1.Text += String.Format("{0} vrijedan {1:C} je zaliven\n", a, b );
            else
                label1.Text += String.Format("{0} vrijedan {1:C} nije zaliven\n", a, b);



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Krug k1 = new Krug();
            Krug k2 = new Krug();
            Krug k3 = new Krug();

            k1.Polumjer = 3;
            k2.Polumjer = 23;

            label2.Text += String.Format("\n{0,10}      {1,10}      {2,10}", "Polumjer", "Promjer", "Površina");

            Ispis(k1);
            Ispis(k2);  
            Ispis(k3);

        }

        void Ispis(Krug k)
        {
            label2.Text += String.Format("\n{0,10}      {1,10}      {2,10}", k.Polumjer, k.Promjer, k.Povrsina.ToString("F2"));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Kvadrat[] niz = new Kvadrat[10];
            for(int i= 0; i < niz.Length; i++)
            {
                niz[i] = new Kvadrat(i + 1);
                label3.Text += String.Format("Površina kvadrata {0} sa {0} iznosi {1}\n", niz[i].Stranica, niz[i].Povrsina);
            }    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Izvidjac izv1 = new Izvidjac();
            izv1.Ime = "Mate";
            izv1.BrojCete = 6;
            izv1.clanarina = 130;

            Izvidjac izv2 = new Izvidjac();
            
            label4.Text += String.Format("Izvidjac {0} iz čete {1} duguje {2:C} članarine\n", izv1.Ime, izv1.BrojCete, izv1.Clanarina);
            label4.Text += String.Format("Izvidjac {0} iz čete {1} duguje {2:C} članarine\n", izv2.Ime, izv2.BrojCete, izv2.Clanarina);
            label4.Text += String.Format("Naš moto je...\n\"{0}\"", Izvidjac.MOTO);
        }


        //Globalne varijable i objekti
        PorezniObveznik[] porezniObveznici = new PorezniObveznik[3];
        int counter = 0;

        

        private void btnInput_Click(object sender, EventArgs e)
        {
            lblTaxPrint.Hide();
            if (txtOIB.Text.Length > 11 || txtOIB.Text.Length < 11)
            {
                MessageBox.Show("OIB mora imati 11 znamenaka");
                txtOIB.Focus();
            }
            else if (txtPlaca.Text == "")
            {
                MessageBox.Show("Molimo unesite godišnji iznos plaće");
                txtPlaca.Focus();
            }
            else
            {
                porezniObveznici[counter] = new PorezniObveznik(txtOIB.Text, Convert.ToInt32(txtPlaca.Text));

                lblTaxPrint.Text += String.Format("Porezni obveznik #{0} - OIB: {1}, iznos poreza: {2:C}\n", counter + 1, porezniObveznici[counter].Oib, porezniObveznici[counter].Porez);

                txtOIB.Clear();
                txtOIB.Focus();
                txtPlaca.Clear();

                counter++;

                if (counter == porezniObveznici.Length)
                {
                    lblTaxPrint.Show();
                    txtOIB.Enabled = false;
                    txtPlaca.Enabled = false;
                    btnInput.Enabled = false;

                    lblTaxPrint.Text += String.Format("Nakon sortiranja:\n");
                    Array.Sort(porezniObveznici);
                    
                    for (int i = 0; i < porezniObveznici.Length; i++)
                        lblTaxPrint.Text += String.Format("Porezni obveznik #{0} - OIB: {1}, iznos poreza: {2:C}\n", i + 1, porezniObveznici[i].Oib, porezniObveznici[i].Porez);

                }
            }
        



        }
        
    }
}
