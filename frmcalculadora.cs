using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{

    public partial class frmcalculadora : Form
    {
        float valor1 = 0;
        float valor2 = 0;
        string operacao = "";
        float resultado = 0;
        public frmcalculadora()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "00";
        }

        private void num0_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "0";
        }

        private void num1_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "1";
        }

        private void num2_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "2";
        }

        private void num3_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "3";
        }

        private void num4_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "4";
        }

        private void num5_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "5";
        }

        private void num6_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "6";
        }

        private void num7_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "7";
        }

        private void num8_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "8";
        }

        private void num9_Click(object sender, EventArgs e)
        {
            txtVisor.Text = txtVisor.Text + "9";
        }

        private void sinMult_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "multiplicacao";
            txtVisor.Clear();
        }

        private void sinMais_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "soma";
            txtVisor.Clear();
        }

        private void sinIgual_Click(object sender, EventArgs e)
        {
            valor2 = Convert.ToSingle(txtVisor.Text);
            if (operacao == "soma")
            {
                resultado = valor1 + valor2;
            }
            if (operacao == "subtracao")
            {
                resultado = valor1 - valor2;
            }
            if (operacao == "divicao")
            {
                resultado = valor1 / valor2;
            }
            if (operacao == "multiplicacao")
            {
                resultado = valor1 * valor2;
            }
            txtVisor.Text = resultado.ToString();
        }

        private void sinMenos_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "subtracao";
            txtVisor.Clear();
        }

        private void sinDiv_Click(object sender, EventArgs e)
        {
            valor1 = Convert.ToSingle(txtVisor.Text);
            operacao = "divisao";
            txtVisor.Clear();
        }

        private void conversorToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void celsiusParaFahToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void frmcalculadora_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
