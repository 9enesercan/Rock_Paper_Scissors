namespace WinFormsApp4
{
    public partial class secimForm : Form
    {
        public secimForm()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {

            GecisKBForm form3 = new GecisKBForm();
            Hide(); form3.Show();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            GecisBBForm form2 = new GecisBBForm();
            Hide();
            form2.Show();





        }

        private void secimForm_Load(object sender, EventArgs e)
        {

        }
    }
}