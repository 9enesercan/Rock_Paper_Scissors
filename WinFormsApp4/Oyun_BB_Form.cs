﻿

namespace WinFormsApp4
{
    public partial class Oyun_BB_Form : Form
    {
        int turSayac = 1;
        int bsayi = 5;
        int bsayi_2 = 5;

        public static List<dynamic> nesne_Listesi_1 = new List<dynamic>();
        public static List<dynamic> nesne_Listesi_2 = new List<dynamic>(); //tüm nesnelerin oldugu



        public List<int> indisler_1 = new List<int>();
        public List<int> indisler_2 = new List<int>();
        public List<int> indis_cpy = new List<int>();
        public List<int> indis_cpy_2 = new List<int>();



        public List<int> control_random = new List<int>();
        public List<int> control_random_2 = new List<int>();


        public Oyun_BB_Form(List<dynamic> nesne_Listesi, List<dynamic> nesne_Listesi2)
        {
            nesne_Listesi_1 = nesne_Listesi;
            nesne_Listesi_2 = nesne_Listesi2;

            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button7.Enabled = false;
            button8.Enabled = false;
            button9.Enabled = false;
            button10.Enabled = false;


            Random random = new Random();


            int k = 0;
            while (k < 15)
            {
                int sayi = random.Next(15);
                if (indisler_1.Contains(sayi))
                    continue;
                indisler_1.Add(sayi);
                k++;
            }
            k = 0;
            while (k < 15)
            {
                int sayi = random.Next(15);
                if (indisler_2.Contains(sayi))
                    continue;
                indisler_2.Add(sayi);
                k++;
            }

            foreach (int i in indisler_1)
            {
                indis_cpy.Add(i);
            }
            foreach (int i in indisler_2)
            {
                indis_cpy_2.Add(i);
            }



            guncelle();
            guncelle();


            timer1.Interval = 1000;

            timer1.Start();



        }

        public void guncelle()
        {
            int k_say = 0, b_say = 0;


            for (int i = 0; i < 5; i++)
            {
                if (nesne_Listesi_2[indisler_2[i]].getDayaniklik() <= 0)
                {
                    k_say++;
                }
                if (nesne_Listesi_1[indisler_1[i]].getDayaniklik() <= 0)
                {
                    b_say++;
                }
            }




            label29.Text = turSayac.ToString() + ". Tur";
            int b1_puan = 0;
            int b2_puan = 0;

            for (int i = 0; i < 5; i++)
            {
                b1_puan += nesne_Listesi_1[indisler_1[i]].getSeviye_puani();
                b2_puan += nesne_Listesi_2[indisler_2[i]].getSeviye_puani();
            }

            label30.Text = b2_puan.ToString() + " Puan";
            label31.Text = b1_puan.ToString() + " Puan";




            if (turSayac - 1 >= 40)
            {

                timer1.Stop();

                if (b1_puan > b2_puan)
                {
                    MessageBox.Show("Oyun bitmiştir \nBilgisayar 1 : " + b1_puan + "\nBilgisayar 2 : " + b2_puan + " \nkazanan Bilgisayar 1");


                }
                else if (b2_puan > b1_puan)
                {

                    MessageBox.Show("Oyun bitmiştir \nBilgisayar 1 : " + b1_puan + "\nBilgisayar 2 : " + b2_puan + " \nkazanan Bilgisayar 2");

                }
                else
                {
                    MessageBox.Show("Oyun bitmiştir Oyun bitmiştir \nBilgisayar 1 : " + b1_puan + "\nBilgisayar 2 : " + b2_puan + " \nBeraberlik");

                }



                Application.Exit();
            }
            else if (b_say == 5)
            {
                timer1.Stop();
                MessageBox.Show("Oyun bitmiştir \nBilgisayar 1 : " + b1_puan + "\nBilgisayar 2 : " + b2_puan + " \nkazanan Bilgisayar 2");
                Application.Exit();
            }
            else if (k_say == 5)
            {
                timer1.Stop();
                MessageBox.Show("Oyun bitmiştir \nBilgisayar 1 : " + b1_puan + "\nBilgisayar 2 : " + b2_puan + " \nkazanan Bilgisayar 1");
                Application.Exit();
            }


            string[] isimler = new string[10];

            for (int i = 0; i < 5; i++)
            {
                isimler[i] = nesne_Listesi_2[indisler_2[i]].ToString().Substring(13);

            }

            int k = 5;
            for (int i = 0; i < 5; i++)
            {
                isimler[k] = nesne_Listesi_1[indisler_1[i]].ToString().Substring(13);
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


            if (nesne_Listesi_2[indisler_2[0]].getDayaniklik() <= 0)
            {
                button1.BackColor = Color.Red;
            }
            if (nesne_Listesi_2[indisler_2[1]].getDayaniklik() <= 0)
            {
                button2.BackColor = Color.Red;
            }
            if (nesne_Listesi_2[indisler_2[2]].getDayaniklik() <= 0)
            {
                button3.BackColor = Color.Red;
            }
            if (nesne_Listesi_2[indisler_2[3]].getDayaniklik() <= 0)
            {
                button4.BackColor = Color.Red;
            }
            if (nesne_Listesi_2[indisler_2[4]].getDayaniklik() <= 0)
            {
                button5.BackColor = Color.Red;
            }


            //bot 2
            if (nesne_Listesi_1[indisler_1[0]].getDayaniklik() <= 0)
            {
                button6.BackColor = Color.Red;
            }
            if (nesne_Listesi_1[indisler_1[1]].getDayaniklik() <= 0)
            {
                button7.BackColor = Color.Red;
            }
            if (nesne_Listesi_1[indisler_1[2]].getDayaniklik() <= 0)
            {
                button8.BackColor = Color.Red;
            }
            if (nesne_Listesi_1[indisler_1[3]].getDayaniklik() <= 0)
            {
                button9.BackColor = Color.Red;
            }
            if (nesne_Listesi_1[indisler_1[4]].getDayaniklik() <= 0)
            {
                button10.BackColor = Color.Red;
            }



            if (label6.Text != nesne_Listesi_2[indisler_2[0]].getDayaniklik().ToString())
            {
                label5.Text = nesne_Listesi_2[indisler_2[0]].getSeviye_puani().ToString();
                label6.Text = nesne_Listesi_2[indisler_2[0]].getDayaniklik().ToString();

                if (nesne_Listesi_2[indisler_2[0]].getDayaniklik() > 0)
                {
                    button1.BackColor = Color.LightGreen;

                }

            }

            if (label8.Text != nesne_Listesi_2[indisler_2[1]].getDayaniklik().ToString())
            {
                label7.Text = nesne_Listesi_2[indisler_2[1]].getSeviye_puani().ToString();
                label8.Text = nesne_Listesi_2[indisler_2[1]].getDayaniklik().ToString();
                if (nesne_Listesi_2[indisler_2[1]].getDayaniklik() > 0)
                {
                    button2.BackColor = Color.LightGreen;

                }
            }


            if (label10.Text != nesne_Listesi_2[indisler_2[2]].getDayaniklik().ToString())
            {
                label9.Text = nesne_Listesi_2[indisler_2[2]].getSeviye_puani().ToString();
                label10.Text = nesne_Listesi_2[indisler_2[2]].getDayaniklik().ToString();

                if (nesne_Listesi_2[indisler_2[2]].getDayaniklik() > 0)
                {
                    button3.BackColor = Color.LightGreen;

                }

            }

            if (label12.Text != nesne_Listesi_2[indisler_2[3]].getDayaniklik().ToString())
            {
                label11.Text = nesne_Listesi_2[indisler_2[3]].getSeviye_puani().ToString();
                label12.Text = nesne_Listesi_2[indisler_2[3]].getDayaniklik().ToString();
                if (nesne_Listesi_2[indisler_2[3]].getDayaniklik() > 0)
                {
                    button4.BackColor = Color.LightGreen;

                }
            }


            if (label14.Text != nesne_Listesi_2[indisler_2[4]].getDayaniklik().ToString())
            {
                label13.Text = nesne_Listesi_2[indisler_2[4]].getSeviye_puani().ToString();
                label14.Text = nesne_Listesi_2[indisler_2[4]].getDayaniklik().ToString();
                if (nesne_Listesi_2[indisler_2[4]].getDayaniklik() > 0)
                {
                    button5.BackColor = Color.LightGreen;

                }
            }


            if (label16.Text != nesne_Listesi_1[indisler_1[0]].getDayaniklik().ToString())
            {
                label15.Text = nesne_Listesi_1[indisler_1[0]].getSeviye_puani().ToString();
                label16.Text = nesne_Listesi_1[indisler_1[0]].getDayaniklik().ToString();
                if (nesne_Listesi_1[indisler_1[0]].getDayaniklik() > 0)
                {
                    button6.BackColor = Color.LightGreen;
                }
            }

            if (label18.Text != nesne_Listesi_1[indisler_1[1]].getDayaniklik().ToString())
            {
                label17.Text = nesne_Listesi_1[indisler_1[1]].getSeviye_puani().ToString();
                label18.Text = nesne_Listesi_1[indisler_1[1]].getDayaniklik().ToString();
                if (nesne_Listesi_1[indisler_1[1]].getDayaniklik() > 0)
                {
                    button7.BackColor = Color.LightGreen;

                }


            }
            if (label20.Text != nesne_Listesi_1[indisler_1[2]].getDayaniklik().ToString())
            {
                label19.Text = nesne_Listesi_1[indisler_1[2]].getSeviye_puani().ToString();
                label20.Text = nesne_Listesi_1[indisler_1[2]].getDayaniklik().ToString();
                if (nesne_Listesi_1[indisler_1[2]].getDayaniklik() > 0)
                {
                    button8.BackColor = Color.LightGreen;

                }

            }
            if (label22.Text != nesne_Listesi_1[indisler_1[3]].getDayaniklik().ToString())
            {
                label21.Text = nesne_Listesi_1[indisler_1[3]].getSeviye_puani().ToString();
                label22.Text = nesne_Listesi_1[indisler_1[3]].getDayaniklik().ToString();
                if (nesne_Listesi_1[indisler_1[3]].getDayaniklik() > 0)
                {

                    button9.BackColor = Color.LightGreen;
                }

            }
            if (label24.Text != nesne_Listesi_1[indisler_1[4]].getDayaniklik().ToString())
            {
                label23.Text = nesne_Listesi_1[indisler_1[4]].getSeviye_puani().ToString();
                label24.Text = nesne_Listesi_1[indisler_1[4]].getDayaniklik().ToString();

                if (nesne_Listesi_1[indisler_1[4]].getDayaniklik() > 0)
                {
                    button10.BackColor = Color.LightGreen;

                }


            }






        }



        private void timer1_Tick_1(object sender, EventArgs e)
        {

            //bot 1 rastgelelik
            int b_indis;

            Random random = new Random();
            int a;


            int kalan_say = bsayi;

            for (int i = 0; i < kalan_say; i++)
            {
                if (nesne_Listesi_1[indis_cpy[i]].getDayaniklik() <= 0)
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
            //bot 2 rastgelelik

            int b_indis_2;

            int b;


            int kalan_say_2 = bsayi_2;

            for (int i = 0; i < kalan_say_2; i++)
            {
                if (nesne_Listesi_2[indis_cpy_2[i]].getDayaniklik() <= 0)
                {
                    for (int j = 0; j < control_random_2.Count; j++)
                    {
                        if (control_random_2[j] > i)
                        {
                            control_random_2[j]--;
                        }
                    }


                    indis_cpy_2.RemoveAt(i);
                    bsayi_2--;


                    break;
                }
            }


            if (control_random_2.Count == 0)
            {
                for (int i = 0; i < bsayi_2;)
                {
                    b = random.Next(bsayi_2);
                    if (control_random_2.Contains(b))
                    {
                        continue;
                    }

                    control_random_2.Add(b);
                    i++;
                }
            }


            b_indis_2 = control_random_2[0];
            control_random_2.RemoveAt(0);




            //rastgele hamleler ortaya getiriliyor
            label3.Text = nesne_Listesi_2[indis_cpy_2[b_indis_2]].ToString().Substring(13);
            label4.Text = nesne_Listesi_1[indis_cpy[b_indis]].ToString().Substring(13);


            //Birbirlerine etkileri hesaplanıp karşılaştırılıyor
            double bot_etki_2;
            double bot_etki_1;

            bot_etki_2 = nesne_Listesi_2[indis_cpy_2[b_indis_2]].etkiHesapla(nesne_Listesi_1[indis_cpy[b_indis]].getTur(), nesne_Listesi_1[indis_cpy[b_indis]].getGuc(), nesne_Listesi_1[indis_cpy[b_indis]].getOzelguc());
            bot_etki_1 = nesne_Listesi_2[indis_cpy[b_indis]].etkiHesapla(nesne_Listesi_2[indis_cpy_2[b_indis_2]].getTur(), nesne_Listesi_2[indis_cpy_2[b_indis_2]].getGuc(), nesne_Listesi_2[indis_cpy_2[b_indis_2]].getOzelguc());

            label32.Text = " -" + bot_etki_2.ToString();
            label33.Text = " -" + bot_etki_1.ToString();


            if (bot_etki_1 > bot_etki_2)
            {
                nesne_Listesi_2[indis_cpy_2[b_indis_2]].durumGuncelle(bot_etki_1, 0);
                nesne_Listesi_1[indis_cpy[b_indis]].durumGuncelle(bot_etki_2, 1);

            }
            else if (bot_etki_1 < bot_etki_2)
            {
                nesne_Listesi_1[indis_cpy[b_indis]].durumGuncelle(bot_etki_2, 0);
                nesne_Listesi_2[indis_cpy_2[b_indis_2]].durumGuncelle(bot_etki_1, 1);

            }
            else
            {
                nesne_Listesi_2[indis_cpy_2[b_indis_2]].durumGuncelle(bot_etki_1, 0);
                nesne_Listesi_1[indis_cpy[b_indis]].durumGuncelle(bot_etki_2, 0);
            }




            //Kullanıcı terfi kontrolü
            if (Convert.ToInt32(nesne_Listesi_2[indis_cpy_2[b_indis_2]].getSeviye_puani()) >= 30 && nesne_Listesi_2[indis_cpy_2[b_indis_2]].getTur() == "tas")
            {
                Agir_tas agirtas = new(2, nesne_Listesi_2[indis_cpy_2[b_indis_2]].getKatilik(), nesne_Listesi_2[indis_cpy_2[b_indis_2]].getDayaniklik(), nesne_Listesi_2[indis_cpy_2[b_indis_2]].getSeviye_puani(), "agirtas");

                nesne_Listesi_2[indis_cpy_2[b_indis_2]] = agirtas;
            }
            if (Convert.ToInt32(nesne_Listesi_2[indis_cpy_2[b_indis_2]].getSeviye_puani()) >= 30 && nesne_Listesi_2[indis_cpy_2[b_indis_2]].getTur() == "kagit")
            {
                Ozel_kagit ozelkagit = new(2, nesne_Listesi_2[indis_cpy_2[b_indis_2]].getNufuz(), nesne_Listesi_2[indis_cpy_2[b_indis_2]].getDayaniklik(), nesne_Listesi_2[indis_cpy_2[b_indis_2]].getSeviye_puani(), "ozelkagit");
                nesne_Listesi_2[indis_cpy_2[b_indis_2]] = ozelkagit;
            }
            if (Convert.ToInt32(nesne_Listesi_2[indis_cpy_2[b_indis_2]].getSeviye_puani()) >= 30 && nesne_Listesi_2[indis_cpy_2[b_indis_2]].getTur() == "makas")
            {
                Usta_makas ustamakas = new(2, nesne_Listesi_2[indis_cpy_2[b_indis_2]].getKeskinlik(), nesne_Listesi_2[indis_cpy_2[b_indis_2]].getDayaniklik(), nesne_Listesi_2[indis_cpy_2[b_indis_2]].getSeviye_puani(), "ustamakas");
                nesne_Listesi_2[indis_cpy_2[b_indis_2]] = ustamakas;
            }


            //Bilgisayar terfi kontrolü
            if (Convert.ToInt32(nesne_Listesi_1[indis_cpy[b_indis]].getSeviye_puani()) >= 30 && nesne_Listesi_1[indis_cpy[b_indis]].getTur() == "tas")
            {
                Agir_tas agirtas = new(2, nesne_Listesi_1[indis_cpy[b_indis]].getKatilik(), nesne_Listesi_1[indis_cpy[b_indis]].getDayaniklik(), nesne_Listesi_1[indis_cpy[b_indis]].getSeviye_puani(), "agirtas");

                nesne_Listesi_1[indis_cpy[b_indis]] = agirtas;
            }
            if (Convert.ToInt32(nesne_Listesi_1[indis_cpy[b_indis]].getSeviye_puani()) >= 30 && nesne_Listesi_1[indis_cpy[b_indis]].getTur() == "kagit")
            {
                Ozel_kagit ozelkagit = new(2, nesne_Listesi_1[indis_cpy[b_indis]].getNufuz(), nesne_Listesi_1[indis_cpy[b_indis]].getDayaniklik(), nesne_Listesi_1[indis_cpy[b_indis]].getSeviye_puani(), "ozelkagit");
                nesne_Listesi_1[indis_cpy[b_indis]] = ozelkagit;
            }
            if (Convert.ToInt32(nesne_Listesi_1[indis_cpy[b_indis]].getSeviye_puani()) >= 30 && nesne_Listesi_1[indis_cpy[b_indis]].getTur() == "makas")
            {
                Usta_makas ustamakas = new(2, nesne_Listesi_1[indis_cpy[b_indis]].getKeskinlik(), nesne_Listesi_1[indis_cpy[b_indis]].getDayaniklik(), nesne_Listesi_1[indis_cpy[b_indis]].getSeviye_puani(), "ustamakas");
                nesne_Listesi_1[indis_cpy[b_indis]] = ustamakas;
            }

            guncelle();
            turSayac++;


        }

        private void Form4_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


    }
}
