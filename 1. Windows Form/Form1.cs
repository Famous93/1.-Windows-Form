using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _1.Windows_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void tiedostoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void tietojaToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void domainUpDown2_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void infoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Tämän sovelluksen on tehnyt Maroof Ghalji");
        }

        private void textBox3_Enter(object sender, EventArgs e)
        {
            if (textBox3.Text == "[syötä elokuvan nimi]")
            {
                textBox3.Text = "";
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            julkaisvuosi.Text = DateTime.Now.Year.ToString();
            arvio.Text = "[Kirjoita arvio tähän!";

        }

        private void julkaisvuosi_Enter(object sender, EventArgs e)
        {

            if (julkaisvuosi.Text == DateTime.Now.Year.ToString())
            {
                julkaisvuosi.Text = "";
            }
        }

        private void arvio_Enter(object sender, EventArgs e)
        {

            if (arvio.Text == "[Kirjoita arvio tähän!")
            {
                arvio.Text = "";
            }


        }

        private void textBox7_Enter(object sender, EventArgs e)
        {
            if (kesto.Text == "0")
            {
                kesto.Text = "";
            }
        }

        private void poistuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void arvio_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void arvio_Leave(object sender, EventArgs e)
        {
            if (arvio.Text == "")
            {
                arvio.Text = "[Kirjoita arvio tähän!";
            }
        }

        private void julkaisvuosi_Leave(object sender, EventArgs e)
        {
            if (julkaisvuosi.Text == "")
            {
                julkaisvuosi.Text = DateTime.Now.Year.ToString();
            }
        }

        private void textBox3_Leave(object sender, EventArgs e)
        {

            if (textBox3.Text == "")
            {
                textBox3.Text = "[syötä elokuvan nimi]";
            }
        }
    }
}
