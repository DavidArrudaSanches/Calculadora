namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }





        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            progressBar1.Value += 1;
            if (progressBar1.Value == 10)
            {   
                this.Hide();
                timer1.Enabled = false;
                frmcalculadora frmcalculadora = new frmcalculadora();
                frmcalculadora.ShowDialog();
                
            }
            if (progressBar1.Value == 9)
            {
                pictureBox2.Visible = true;
                pictureBox1.Visible = false;
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
