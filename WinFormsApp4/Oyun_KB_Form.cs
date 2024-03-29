﻿

namespace WinFormsApp4
{
    public partial class Oyun_KB_Form : Form
    {
        public string ad;
        public string b;

        public static List<dynamic> nesne_Listesi2 = new List<dynamic>(); //tüm nesnelerin oldugu
        public static List<dynamic> kullanici_Listesi2 = new List<dynamic>(); //kullanici listeleri
        public List<int> indisler_1 = new List<int>();
        public List<int> indis_cpy = new List<int>();

        public List<int> control_random = new List<int>();


        public Oyun_KB_Form(List<dynamic> nesne_Listesi, List<dynamic> kullanici_Listesi)
        {
            nesne_Listesi2 = nesne_Listesi;
            kullanici_Listesi2 = kullanici_Listesi;

            InitializeComponent();
        }





        int bsayi = 5;
        int sayac = 0;
        int turSayac = 1;


        private void Form6_Load(object sender, EventArgs e)
        {

            label34.Text = ad;


            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;


            Random random = new Random();


            int k = 0;
            while (k < 5)
            {
                int sayi = random.Next(15);
                if (indisler_1.Contains(sayi))
                    continue;
                indisler_1.Add(sayi);
                k++;
            }

            foreach (int i in indisler_1)
            {
                indis_cpy.Add(i);
            }


            guncelle();
            guncelle();


        }



        public void guncelle()
        {

            string[] isimler = new string[10];

            for (int i = 0; i < 5; i++)
            {
                isimler[i] = kullanici_Listesi2[i].ToString().Substring(13);

            }

            int k = 5;
            for (int i = 0; i < 5; i++)
            {
                isimler[k] = nesne_Listesi2[indisler_1[i]].ToString().Substring(13);
                k++;
            }

            button1.Text = isimler[0];
            button2.Text = isimler[1];
            button3.Text = isimler[2];
            button4.Text = isimler[3];
            button5.Text = isimler[4];

            button6.Text = isimler[5];
            button7.Text = isimler[6];
            button8.Text = isimler[7];
            button9.Text = isimler[8];
            button10.Text = isimler[9];

            button1.BackColor = Color.Empty;
            button2.BackColor = Color.Empty;
            button3.BackColor = Color.Empty;
            button4.BackColor = Color.Empty;
            button5.BackColor = Color.Empty;

            button6.BackColor = Color.Empty;
            button7.BackColor = Color.Empty;
            button8.BackColor = Color.Empty;
            button9.BackColor = Color.Empty;
            button10.BackColor = Color.Empty;

            if (kullanici_Listesi2[0].getDayaniklik() <= 0)
            {
                button1.BackColor = Color.Red;
                button1.Enabled = false;
            }
            if (kullanici_Listesi2[1].getDayaniklik() <= 0)
            {
                button2.BackColor = Color.Red;
                button2.Enabled = false;

            }
            if (kullanici_Listesi2[2].getDayaniklik() <= 0)
            {
                button3.BackColor = Color.Red;
                button3.Enabled = false;

            }
            if (kullanici_Listesi2[3].getDayaniklik() <= 0)
            {
                button4.BackColor = Color.Red;
                button4.Enabled = false;

            }

            if (kullanici_Listesi2[4].getDayaniklik() <= 0)
            {
                button5.BackColor = Color.Red;
                button5.Enabled = false;

            }


            //Bilgisayar
            if (nesne_Listesi2[indisler_1[0]].getDayaniklik() <= 0)
            {
                button6.BackColor = Color.Red;

            }
            if (nesne_Listesi2[indisler_1[1]].getDayaniklik() <= 0)
            {
                button7.BackColor = Color.Red;

            }
            if (nesne_Listesi2[indisler_1[2]].getDayaniklik() <= 0)
            {
                button8.BackColor = Color.Red;

            }
            if (nesne_Listesi2[indisler_1[3]].getDayaniklik() <= 0)
            {
                button9.BackColor = Color.Red;

            }
            if (nesne_Listesi2[indisler_1[4]].getDayaniklik() <= 0)
            {
                button10.BackColor = Color.Red;

            }



            if (label6.Text != kullanici_Listesi2[0].getDayaniklik().ToString())
            {
                label5.Text = kullanici_Listesi2[0].getSeviye_puani().ToString();
                label6.Text = kullanici_Listesi2[0].getDayaniklik().ToString();

                if (kullanici_Listesi2[0].getDayaniklik() > 0)
                {
                    button1.BackColor = Color.LightGreen;

                }

            }

            if (label8.Text != kullanici_Listesi2[1].getDayaniklik().ToString())
            {
                label7.Text = kullanici_Listesi2[1].getSeviye_puani().ToString();
                label8.Text = kullanici_Listesi2[1].getDayaniklik().ToString();
                if (kullanici_Listesi2[1].getDayaniklik() > 0)
                {
                    button2.BackColor = Color.LightGreen;

                }
            }


            if (label10.Text != kullanici_Listesi2[2].getDayaniklik().ToString())
            {
                label9.Text = kullanici_Listesi2[2].getSeviye_puani().ToString();
                label10.Text = kullanici_Listesi2[2].getDayaniklik().ToString();

                if (kullanici_Listesi2[2].getDayaniklik() > 0)
                {
                    button3.BackColor = Color.LightGreen;

                }

            }

            if (label12.Text != kullanici_Listesi2[3].getDayaniklik().ToString())
            {
                label11.Text = kullanici_Listesi2[3].getSeviye_puani().ToString();
                label12.Text = kullanici_Listesi2[3].getDayaniklik().ToString();
                if (kullanici_Listesi2[3].getDayaniklik() > 0)
                {
                    button4.BackColor = Color.LightGreen;

                }
            }


            if (label14.Text != kullanici_Listesi2[4].getDayaniklik().ToString())
            {
                label13.Text = kullanici_Listesi2[4].getSeviye_puani().ToString();
                label14.Text = kullanici_Listesi2[4].getDayaniklik().ToString();
                if (kullanici_Listesi2[4].getDayaniklik() > 0)
                {
                    button5.BackColor = Color.LightGreen;

                }
            }


            if (label16.Text != nesne_Listesi2[indisler_1[0]].getDayaniklik().ToString())
            {
                label15.Text = nesne_Listesi2[indisler_1[0]].getSeviye_puani().ToString();
                label16.Text = nesne_Listesi2[indisler_1[0]].getDayaniklik().ToString();
                button6.BackColor = Color.LightGreen;

            }

            if (label18.Text != nesne_Listesi2[indisler_1[1]].getDayaniklik().ToString())
            {
                label17.Text = nesne_Listesi2[indisler_1[1]].getSeviye_puani().ToString();
                label18.Text = nesne_Listesi2[indisler_1[1]].getDayaniklik().ToString();
                button7.BackColor = Color.LightGreen;


            }
            if (label20.Text != nesne_Listesi2[indisler_1[2]].getDayaniklik().ToString())
            {
                label19.Text = nesne_Listesi2[indisler_1[2]].getSeviye_puani().ToString();
                label20.Text = nesne_Listesi2[indisler_1[2]].getDayaniklik().ToString();
                button8.BackColor = Color.LightGreen;

            }
            if (label22.Text != nesne_Listesi2[indisler_1[3]].getDayaniklik().ToString())
            {
                label21.Text = nesne_Listesi2[indisler_1[3]].getSeviye_puani().ToString();
                label22.Text = nesne_Listesi2[indisler_1[3]].getDayaniklik().ToString();
                button9.BackColor = Color.LightGreen;

            }
            if (label24.Text != nesne_Listesi2[indisler_1[4]].getDayaniklik().ToString())
            {
                label23.Text = nesne_Listesi2[indisler_1[4]].getSeviye_puani().ToString();
                label24.Text = nesne_Listesi2[indisler_1[4]].getDayaniklik().ToString();
                button10.BackColor = Color.LightGreen;

            }





            if (sayac >= 5)
            {
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                sayac = 0;

                if (kullanici_Listesi2[0].getDayaniklik() <= 0)
                {
                    button1.Enabled = false;
                }
                if (kullanici_Listesi2[1].getDayaniklik() <= 0)
                {
                    button2.Enabled = false;

                }
                if (kullanici_Listesi2[2].getDayaniklik() <= 0)
                {
                    button3.Enabled = false;

                }
                if (kullanici_Listesi2[3].getDayaniklik() <= 0)
                {
                    button4.Enabled = false;

                }

                if (kullanici_Listesi2[4].getDayaniklik() <= 0)
                {
                    button5.Enabled = false;

                }


                for (int i = 0; i < 5; i++)
                {
                    if (kullanici_Listesi2[i].getDayaniklik() <= 0)
                    {
                        sayac++;
                    }
                }
            }

            int k_say = 0, b_say = 0;


            for (int i = 0; i < 5; i++)
            {
                if (kullanici_Listesi2[i].getDayaniklik() <= 0)
                {
                    k_say++;
                }
                if (nesne_Listesi2[indisler_1[i]].getDayaniklik() <= 0)
                {
                    b_say++;
                }


            }




            label29.Text = turSayac.ToString() + ". Tur";
            int b1_puan = 0;
            int b2_puan = 0;

            for (int i = 0; i < 5; i++)
            {
                b1_puan += nesne_Listesi2[indisler_1[i]].getSeviye_puani();
                b2_puan += kullanici_Listesi2[i].getSeviye_puani();
            }

            label30.Text = b2_puan.ToString() + " Puan";
            label31.Text = b1_puan.ToString() + " Puan";




            if (turSayac - 1 >= 40)
            {


                if (b1_puan > b2_puan)
                {
                    MessageBox.Show("Oyun bitmiştir \n Bilgisayar : " + b1_puan + "\n" + ad.ToString() + " " + b2_puan + " \nkazanan : Bilgisayar");
                }
                else if (b2_puan > b1_puan)
                {
                    MessageBox.Show("Oyun bitmiştir \n Bilgisayar : " + b1_puan + "\n" + ad.ToString() + " " + b2_puan + " \nkazanan : " + ad.ToString());
                }
                else
                {
                    MessageBox.Show("Oyun bitmiştir Oyun bitmiştir \n Bilgisayar : " + b1_puan + "\n Kullanıcı  : " + b2_puan + " \nDostluk Kazandı");
                }

                Application.Exit();
            }
            else if (b_say == 5)
            {
                MessageBox.Show("Oyun bitmiştir \n Bilgisayar : " + b1_puan + "\n" + ad.ToString() + " " + b2_puan + " \nkazanan : " + ad.ToString());
                Application.Exit();
            }
            else if (k_say == 5)
            {
                MessageBox.Show("Oyun bitmiştir \n Bilgisayar : " + b1_puan + "\n" + ad.ToString() + " " + b2_puan + " \nkazanan : Bilgisayar ");
                Application.Exit();
            }



        }


        public void fonksiyon(int k_indis)
        {
            int b_indis;

            Random random = new Random();
            int a;


            int kalan_say = bsayi;

            for (int i = 0; i < kalan_say; i++)
            {
                if (nesne_Listesi2[indis_cpy[i]].getDayaniklik() <= 0)
                {
                    for (int j = 0; j < control_random.Count; j++)
                    {
                        if (control_random[j] > i)
                        {
                            control_random[j]--;
                        }
                    }


                    indis_cpy.RemoveAt(i);
                    bsayi--;


                    break;
                }
            }


            if (control_random.Count == 0)
            {
                for (int i = 0; i < bsayi;)
                {
                    a = random.Next(bsayi);
                    if (control_random.Contains(a))
                    {
                        continue;
                    }

                    control_random.Add(a);
                    i++;
                }
            }


            b_indis = control_random[0];
            control_random.RemoveAt(0);






            //seçilen ve rastgele hamleler ortaya getiriliyor
            label3.Text = kullanici_Listesi2[k_indis].ToString().Substring(13);
            label4.Text = nesne_Listesi2[indis_cpy[b_indis]].ToString().Substring(13);




            //Birbirlerine etkileri hesaplanıp karşılaştırılıyor
            double kullanici_etki;
            double bot_etki;
            kullanici_etki = kullanici_Listesi2[k_indis].etkiHesapla(nesne_Listesi2[indis_cpy[b_indis]].getTur(), nesne_Listesi2[indis_cpy[b_indis]].getGuc(), nesne_Listesi2[indis_cpy[b_indis]].getOzelguc());
            bot_etki = nesne_Listesi2[indis_cpy[b_indis]].etkiHesapla(kullanici_Listesi2[k_indis].getTur(), kullanici_Listesi2[k_indis].getGuc(), kullanici_Listesi2[k_indis].getOzelguc());

            label32.Text = " -" + bot_etki.ToString();
            label33.Text = " -" + kullanici_etki.ToString();




            if (bot_etki > kullanici_etki)
            {
                kullanici_Listesi2[k_indis].durumGuncelle(bot_etki, 0);
                nesne_Listesi2[indis_cpy[b_indis]].durumGuncelle(kullanici_etki, 1);

            }
            else if (bot_etki < kullanici_etki)
            {
                nesne_Listesi2[indis_cpy[b_indis]].durumGuncelle(kullanici_etki, 0);
                kullanici_Listesi2[k_indis].durumGuncelle(bot_etki, 1);

            }
            else
            {
                kullanici_Listesi2[k_indis].durumGuncelle(bot_etki, 0);
                nesne_Listesi2[indis_cpy[b_indis]].durumGuncelle(kullanici_etki, 0);
            }




            //Kullanıcı terfi kontrolü
            if (Convert.ToInt32(kullanici_Listesi2[k_indis].getSeviye_puani()) >= 30 && kullanici_Listesi2[k_indis].getTur() == "tas")
            {
                Agir_tas agirtas = new(2, kullanici_Listesi2[k_indis].getKatilik(), kullanici_Listesi2[k_indis].getDayaniklik(), kullanici_Listesi2[k_indis].getSeviye_puani(), "agirtas");

                kullanici_Listesi2[k_indis] = agirtas;
            }
            if (Convert.ToInt32(kullanici_Listesi2[k_indis].getSeviye_puani()) >= 30 && kullanici_Listesi2[k_indis].getTur() == "kagit")
            {
                Ozel_kagit ozelkagit = new(2, kullanici_Listesi2[k_indis].getNufuz(), kullanici_Listesi2[k_indis].getDayaniklik(), kullanici_Listesi2[k_indis].getSeviye_puani(), "ozelkagit");
                kullanici_Listesi2[k_indis] = ozelkagit;
            }
            if (Convert.ToInt32(kullanici_Listesi2[k_indis].getSeviye_puani()) >= 30 && kullanici_Listesi2[k_indis].getTur() == "makas")
            {
                Usta_makas ustamakas = new(2, kullanici_Listesi2[k_indis].getKeskinlik(), kullanici_Listesi2[k_indis].getDayaniklik(), kullanici_Listesi2[k_indis].getSeviye_puani(), "ustamakas");
                kullanici_Listesi2[k_indis] = ustamakas;
            }


            //Bilgisayar terfi kontrolü
            if (Convert.ToInt32(nesne_Listesi2[indis_cpy[b_indis]].getSeviye_puani()) >= 30 && nesne_Listesi2[indis_cpy[b_indis]].getTur() == "tas")
            {
                Agir_tas agirtas = new(2, nesne_Listesi2[indis_cpy[b_indis]].getKatilik(), nesne_Listesi2[indis_cpy[b_indis]].getDayaniklik(), nesne_Listesi2[indis_cpy[b_indis]].getSeviye_puani(), "agirtas");

                nesne_Listesi2[indis_cpy[b_indis]] = agirtas;
            }
            if (Convert.ToInt32(nesne_Listesi2[indis_cpy[b_indis]].getSeviye_puani()) >= 30 && nesne_Listesi2[indis_cpy[b_indis]].getTur() == "kagit")
            {
                Ozel_kagit ozelkagit = new(2, nesne_Listesi2[indis_cpy[b_indis]].getNufuz(), nesne_Listesi2[indis_cpy[b_indis]].getDayaniklik(), nesne_Listesi2[indis_cpy[b_indis]].getSeviye_puani(), "ozelkagit");
                nesne_Listesi2[indis_cpy[b_indis]] = ozelkagit;
            }
            if (Convert.ToInt32(nesne_Listesi2[indis_cpy[b_indis]].getSeviye_puani()) >= 30 && nesne_Listesi2[indis_cpy[b_indis]].getTur() == "makas")
            {
                Usta_makas ustamakas = new(2, nesne_Listesi2[indis_cpy[b_indis]].getKeskinlik(), nesne_Listesi2[indis_cpy[b_indis]].getDayaniklik(), nesne_Listesi2[indis_cpy[b_indis]].getSeviye_puani(), "ustamakas");
                nesne_Listesi2[indis_cpy[b_indis]] = ustamakas;
            }

            sayac++;
            guncelle();
            turSayac++;

        }

        private void button1_Click(object sender, EventArgs e)
        {

            button1.Enabled = false;

            if (kullanici_Listesi2[0].getDayaniklik() <= 0)
            {
                MessageBox.Show("Nesne Kullanılmaz durumdadır");
            }
            else
            {
                fonksiyon(0);

            }


        }
        private void button2_Click(object sender, EventArgs e)
        {

            button2.Enabled = false;
            if (kullanici_Listesi2[1].getDayaniklik() <= 0)
            {
                MessageBox.Show("Nesne Kullanılmaz durumdadır");
            }
            else
            {
                fonksiyon(1);
            }

        }
        private void button3_Click(object sender, EventArgs e)
        {

            button3.Enabled = false;

            if (kullanici_Listesi2[2].getDayaniklik() <= 0)
            {
                MessageBox.Show("Nesne Kullanılmaz durumdadır");
            }
            else
            {
                fonksiyon(2);
            }

        }
        private void button4_Click(object sender, EventArgs e)
        {

            button4.Enabled = false;

            if (kullanici_Listesi2[3].getDayaniklik() <= 0)
            {
                MessageBox.Show("Nesne Kullanılmaz durumdadır");
            }
            else
            {
                fonksiyon(3);
            }

        }
        private void button5_Click(object sender, EventArgs e)
        {

            button5.Enabled = false;

            if (kullanici_Listesi2[4].getDayaniklik() <= 0)
            {
                MessageBox.Show("Nesne Kullanılmaz durumdadır");
            }
            else
            {
                fonksiyon(4);
            }
        }



        private void Form6_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            //  form8 frm8 = new form8();
            //   frm8.kullanici_adi = label1.Text;

        }
    }

}

