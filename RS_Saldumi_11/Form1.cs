using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace RS_Saldumi_11
{
    public partial class Form1 : Form
    {
        //Define cenu ka globalu mainigo
        double cena = 0.00;



        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //Poga, kura izsauc funkciju
        private void button1_Click(object sender, EventArgs e)
        {
                parbaudinators();
        }
        //Funkcija, kas veic pieejama produkta daudzumu, sanemot naudas daudzumu.
        public void aprekini(double cena)
        {
            double nauda = Convert.ToDouble(Daudzums_TTb.Text);
            double daudzums = nauda / cena;
            daudzums = Math.Round(daudzums, 2);
            this.Izmaksas_TTb.Text = Convert.ToString(daudzums);
        }
        //Funkcija, kas parbauda izveletos checkboxus un attiecigi nosaka cenu un izsauc aprekinu funkciju.
        public void parbaudinators()
        {
            if (String.IsNullOrEmpty(Daudzums_TTb.Text))
            {
                MessageBox.Show("Ievadiet savu naudas daudzumu!");
            }

            if (Convert.ToInt32(Daudzums_TTb.Text)  < 0)
            {
                MessageBox.Show("Ievadiet pozitivu skaitli!"); 
            }

            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                MessageBox.Show("Izvelaties, ko velaties iegadaties!");
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                cena = 9.88;
                aprekini(cena);
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                cena = 5.77;
                aprekini(cena);
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                cena = 7.88;
                aprekini(cena);
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                cena = 9.88 + 7.88 + 5.77;
                aprekini(cena);
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                cena = 9.88 + 5.77;
                aprekini(cena);
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                cena = 9.88 + 7.88;
                aprekini(cena);
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                cena = 5.77 + 7.88;
                aprekini(cena);
            }
        }
        

        //Funkcija, kas saglaba ievaditos datus, kuru izsauc ceka izsisanas poga 
        public void Saglabatajs()
        {

            string vards = textBox1.Text;
            string laiks = DateTime.Now.ToString("Mdyyyy");
            string Fcels = "\\Ceki\\" + vards + "_" + laiks + "_ceks.txt";
            StreamWriter fails = new StreamWriter(Application.StartupPath + Fcels);

            fails.WriteLine("Izmaksas: " + Daudzums_TTb.Text + "€");
            fails.WriteLine("Produkta daudzums: " + Izmaksas_TTb.Text + "KG");
            fails.WriteLine("Vards: " + vards);
            fails.WriteLine("Datums: " + DateTime.Now.ToString("M/d/yyyy"));
            fails.Close();
        }
        
        //Poga, kas saglaba lietotaja ievaditos datus txt faila
        private void Ceks_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Ievadiet savu vardu!");
            }
            else
            {
                Saglabatajs();
            }
        }

    }
}
