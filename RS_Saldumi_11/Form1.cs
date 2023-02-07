using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RS_Saldumi_11
{
    public partial class Form1 : Form
    {
        double cena = 0.00;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Daudzums_TTb.Text))
            {
                Daudzums_TTb.Text = Convert.ToString(1);
            }

            if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == false)
            {
                cena = 9.88;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                cena = 5.77;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                cena = 7.88;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                cena = 9.88 + 7.88 + 5.77;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == true && checkBox3.Checked == false)
            {
                cena = 9.88 + 5.77;
            }
            else if (checkBox1.Checked == true && checkBox2.Checked == false && checkBox3.Checked == true)
            {
                cena = 9.88 + 7.88;
            }
            else if (checkBox1.Checked == false && checkBox2.Checked == true && checkBox3.Checked == true)
            {
                cena = 5.77 + 7.88;
            }
            aprekini(cena);
        }
        private void aprekini(double cena)
        {
            double nauda = Convert.ToDouble(Daudzums_TTb.Text);
            double daudzums = nauda / cena;
            daudzums = Math.Round(daudzums, 2);
            this.Izmaksas_TTb.Text = Convert.ToString(daudzums);
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
