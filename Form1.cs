using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Impar_ou_Par_2
{
    public partial class FrmImpPar : Form
    {
        public FrmImpPar()
        {
            InitializeComponent();
        }

        private void btnVerif_Click(object sender, EventArgs e)
        {
            Double n1, n2;
            n1 = Double.Parse(txtNum1.Text);
            n2 = Double.Parse(txtNum2.Text);

            if (n1 % 2 == 0 && n2 % 2 == 0)
            {
                lblResult.Text = "Ambos Pares";
            }
            else if (n1 % 2 != 0 && n2 % 2 != 0)
            {
                lblResult.Text = "Ambos Ímpares";
            }
            else
            {
                lblResult.Text = "Um é par e outro ímpar";
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
