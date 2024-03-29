﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WinFormsApp4
{
    public partial class NesneSecForm : Form
    {

        public NesneSecForm()
        {

            InitializeComponent();
        }


        int sayac = 0;


        public static List<dynamic> nesneListesi = new List<dynamic>();

        public static List<dynamic> kullaniciNesneListesi = new List<dynamic>();


        private void button3_Click_1(object sender, EventArgs e)
        {
            for (int i = 0; i < 5; i++)
            {
                nesneListesi.Add(new Tas(2, 20, 0, "tas"));
                nesneListesi.Add(new Kagit(2, 20, 0, "kagit"));
                nesneListesi.Add(new Makas(2, 20, 0, "makas"));


            }



            if (sayac >= 5)
            {
                Oyun_KB_Form form6 = new Oyun_KB_Form(nesneListesi, kullaniciNesneListesi);



                form6.ad = label1.Text;


                form6.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("5 Nesne seçiniz!");
            }

        }


        public static void Random(List<object> nesneListesi, List<object> bilgisayarNesneListesi)
        {

            Random rastgele = new Random();

            for (int i = 0; i < 5; i++)
            {
                int sayi = rastgele.Next(0, 15);
                bilgisayarNesneListesi[i] = nesneListesi[sayi];

            }


        }



        private void button4_Click(object sender, EventArgs e)
        {

            Tas tas1 = new Tas(2, 20, 0, "tas");
            dynamic tas1_1 = tas1;
            //  nesneListesi.Add(tas1_1);
            if (true)
            {
                kullaniciNesneListesi.Add(tas1_1);
                sayac++;
                button14.Enabled = false;
                button9.Enabled = false;
                button4.Enabled = false;



                button4.BackColor = Color.Aquamarine;


            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Tas tas2 = new Tas(2, 20, 0, "tas");
            dynamic tas2_2 = tas2;
            //tas2_2.ad; 
            //tas2_2
            //   nesneListesi.Add(tas2_2);
            if (true)
            {
                kullaniciNesneListesi.Add(tas2_2);

                button15.Enabled = false;
                button10.Enabled = false;
                button5.Enabled = false;
                button5.BackColor = Color.Aquamarine;

                sayac++;



            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Tas tas3 = new Tas(2, 20, 0, "tas");
            dynamic tas3_3 = tas3;
            //   nesneListesi.Add(tas3_3);
            if (true)
            {
                kullaniciNesneListesi.Add(tas3_3);
                button6.Enabled = false;
                button11.Enabled = false;
                button16.Enabled = false;
                button6.BackColor = Color.Aquamarine;

                sayac++;


            }
        }


        private void button7_Click(object sender, EventArgs e)
        {
            Tas tas4 = new Tas(2, 20, 0, "tas");
            dynamic tas4_4 = tas4;
            //  nesneListesi.Add(tas4_4);
            if (true)
            {
                kullaniciNesneListesi.Add(tas4_4);
                button7.Enabled = false;
                button12.Enabled = false;
                button17.Enabled = false;

                button7.BackColor = Color.Aquamarine;

                sayac++;

            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Tas tas5 = new Tas(2, 20, 0, "tas");
            dynamic tas5_5 = tas5;
            //    nesneListesi.Add(tas5_5);
            if (true)
            {
                kullaniciNesneListesi.Add(tas5_5);
                button13.Enabled = false;
                button18.Enabled = false;
                button8.Enabled = false;
                button8.BackColor = Color.Aquamarine;

                sayac++;



            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Kagit kagit1 = new Kagit(2, 20, 0, "kagit");
            dynamic kagit1_1 = kagit1;
            //    nesneListesi.Add(kagit1_1);
            if (true)
            {
                kullaniciNesneListesi.Add(kagit1_1);
                button14.Enabled = false;
                button9.Enabled = false;
                button4.Enabled = false;
                button9.BackColor = Color.Aquamarine;

                sayac++;


            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Kagit kagit2 = new Kagit(2, 20, 0, "kagit");
            dynamic kagit2_2 = kagit2;
            //     nesneListesi.Add(kagit2_2);
            //nesneListesi.Add((Kagit)kagit2);
            if (true)
            {
                kullaniciNesneListesi.Add(kagit2_2);
                button15.Enabled = false;
                button10.Enabled = false;
                button5.Enabled = false;
                button10.BackColor = Color.Aquamarine;


                sayac++;


            }
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Kagit kagit3 = new Kagit(2, 20, 0, "kagit");
            dynamic kagit3_3 = kagit3;
            //   nesneListesi.Add(kagit3_3);
            if (true)
            {
                kullaniciNesneListesi.Add(kagit3_3);
                button6.Enabled = false;
                button11.Enabled = false;
                button16.Enabled = false;
                button11.BackColor = Color.Aquamarine;

                sayac++;

            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Kagit kagit4 = new Kagit(2, 20, 0, "kagit");
            dynamic kagit4_4 = kagit4;
            //    nesneListesi.Add(kagit4_4);
            if (true)
            {
                kullaniciNesneListesi.Add(kagit4_4);
                button7.Enabled = false;
                button12.Enabled = false;
                button17.Enabled = false;
                button12.BackColor = Color.Aquamarine;

                sayac++;


            }
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Kagit kagit5 = new Kagit(2, 20, 0, "kagit");
            dynamic kagit5_5 = kagit5;
            //     nesneListesi.Add(kagit5_5);
            if (true)
            {
                kullaniciNesneListesi.Add(kagit5_5);
                button13.Enabled = false;
                button18.Enabled = false;
                button8.Enabled = false;
                button13.BackColor = Color.Aquamarine;
                sayac++;





            }
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Makas makas1 = new Makas(2, 20, 0, "makas");
            dynamic makas1_1 = makas1;
            //    nesneListesi.Add(makas1_1);
            if (true)
            {
                kullaniciNesneListesi.Add(makas1_1);
                button14.Enabled = false;
                button9.Enabled = false;
                button4.Enabled = false;
                button14.BackColor = Color.Aquamarine;


                sayac++;


            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Makas makas2 = new Makas(2, 20, 0, "makas");
            dynamic makas2_2 = makas2;
            //   nesneListesi.Add(makas2_2);
            if (true)
            {
                kullaniciNesneListesi.Add(makas2_2);
                button15.Enabled = false;
                button10.Enabled = false;
                button5.Enabled = false;
                button15.BackColor = Color.Aquamarine;

                sayac++;

            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Makas makas3 = new Makas(2, 20, 0, "makas");
            dynamic makas3_3 = makas3;
            //  nesneListesi.Add(makas3_3);
            if (true)
            {
                kullaniciNesneListesi.Add(makas3_3);
                button6.Enabled = false;
                button11.Enabled = false;
                button16.Enabled = false;
                button16.BackColor = Color.Aquamarine;
                sayac++;




            }
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Makas makas4 = new Makas(2, 20, 0, "makas");
            dynamic makas4_4 = makas4;
            //   nesneListesi.Add(makas4_4);
            if (true)
            {
                kullaniciNesneListesi.Add(makas4_4);

                button7.Enabled = false;
                button12.Enabled = false;
                button17.Enabled = false;
                button17.BackColor = Color.Aquamarine;
                sayac++;



            }
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Makas makas5 = new Makas(2, 20, 0, "makas");
            dynamic makas5_5 = makas5;
            //      nesneListesi.Add(makas5_5);
            if (true)
            {
                kullaniciNesneListesi.Add(makas5_5);
                button13.Enabled = false;
                button18.Enabled = false;
                button8.Enabled = false;

                button18.BackColor = Color.Aquamarine;

                sayac++;

            }
        }

        private void Form5_Load(object sender, EventArgs e)
        {
            label1.Visible = false;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
