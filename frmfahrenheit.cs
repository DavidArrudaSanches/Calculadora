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
    public partial class frmfahrenheit : Form
    {
        double calc;
        public frmfahrenheit()
        {
            InitializeComponent();
        }

        private void txtCelsius_TextChanged(object sender, EventArgs e)
        {
        }

        private void buttoncalcf_Click(object sender, EventArgs e)
        {
            calc = 1.8 * Convert.ToDouble(txtCelsius.Text) + 32;
            txtfahrenheit.Text = calc.ToString() ;
        
        }

        private void txtfahrenheit_TextChanged(object sender, EventArgs e)
        {
        }
    }
}
