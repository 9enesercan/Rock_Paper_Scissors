﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp4
{
    public partial class GecisBBForm : Form
    {
        public static List<dynamic> nesneListesi = new List<dynamic>();
        public static List<dynamic> nesneListesi2 = new List<dynamic>();


        public GecisBBForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Oyun_BB_Form form4 = new Oyun_BB_Form(nesneListesi, nesneListesi2);
            form4.Show();
            Hide();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            Tas tas111 = new Tas(2, 20, 0, "tas");
            Tas tas222 = new Tas(2, 20, 0, "tas");
            Tas tas333 = new Tas(2, 20, 0, "tas");
            Tas tas444 = new Tas(2, 20, 0, "tas");
            Tas tas555 = new Tas(2, 20, 0, "tas");

            Kagit kagit111 = new Kagit(2, 20, 0, "kagit");
            Kagit kagit222 = new Kagit(2, 20, 0, "kagit");
            Kagit kagit333 = new Kagit(2, 20, 0, "kagit");
            Kagit kagit444 = new Kagit(2, 20, 0, "kagit");
            Kagit kagit555 = new Kagit(2, 20, 0, "kagit");

            Makas makas111 = new Makas(2, 20, 0, "makas");
            Makas makas222 = new Makas(2, 20, 0, "makas");
            Makas makas333 = new Makas(2, 20, 0, "makas");
            Makas makas444 = new Makas(2, 20, 0, "makas");
            Makas makas555 = new Makas(2, 20, 0, "makas");

            nesneListesi.Add(tas111);
            nesneListesi.Add(tas222);
            nesneListesi.Add(tas333);
            nesneListesi.Add(tas444);
            nesneListesi.Add(tas555);

            nesneListesi.Add(kagit111);
            nesneListesi.Add(kagit222);
            nesneListesi.Add(kagit333);
            nesneListesi.Add(kagit444);
            nesneListesi.Add(kagit555);

            nesneListesi.Add(makas111);
            nesneListesi.Add(makas222);
            nesneListesi.Add(makas333);
            nesneListesi.Add(makas444);
            nesneListesi.Add(makas555);


            Tas tas11 = new Tas(2, 20, 0, "tas");
            Tas tas22 = new Tas(2, 20, 0, "tas");
            Tas tas33 = new Tas(2, 20, 0, "tas");
            Tas tas44 = new Tas(2, 20, 0, "tas");
            Tas tas55 = new Tas(2, 20, 0, "tas");

            Kagit kagit11 = new Kagit(2, 20, 0, "kagit");
            Kagit kagit22 = new Kagit(2, 20, 0, "kagit");
            Kagit kagit33 = new Kagit(2, 20, 0, "kagit");
            Kagit kagit44 = new Kagit(2, 20, 0, "kagit");
            Kagit kagit55 = new Kagit(2, 20, 0, "kagit");

            Makas makas11 = new Makas(2, 20, 0, "makas");
            Makas makas22 = new Makas(2, 20, 0, "makas");
            Makas makas33 = new Makas(2, 20, 0, "makas");
            Makas makas44 = new Makas(2, 20, 0, "makas");
            Makas makas55 = new Makas(2, 20, 0, "makas");

            nesneListesi2.Add(tas11);
            nesneListesi2.Add(tas22);
            nesneListesi2.Add(tas33);
            nesneListesi2.Add(tas44);
            nesneListesi2.Add(tas55);

            nesneListesi2.Add(kagit11);
            nesneListesi2.Add(kagit22);
            nesneListesi2.Add(kagit33);
            nesneListesi2.Add(kagit44);
            nesneListesi2.Add(kagit55);

            nesneListesi2.Add(makas11);
            nesneListesi2.Add(makas22);
            nesneListesi2.Add(makas33);
            nesneListesi2.Add(makas44);
            nesneListesi2.Add(makas55);



        }


    }
}
