using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class isimForm : Form
    {
        public string kullanici_adi="";
        public isimForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                button1.Enabled = false;
            }
            else
            {

                button1.Enabled = true;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NesneSecForm form5 = new NesneSecForm();
            //form5.kullanici_adi = textBox1.Text;
            form5.Show();
            Hide();



        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void form8_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
        }
    }
}
