using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace tabuada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja realmente sair?", "Sair", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            lsbResultado.Items.Clear();
            txtNumero.Clear();
            txtNumero.Focus();
        }

        private void btnExibir_Click(object sender, EventArgs e)
        {
            int valor = int.Parse(txtNumero.Text);

            for (int i = 1; i <= 100; i++)
            {
                lsbResultado.Items.Add($"{valor} x {i} = {valor * i}");
            }
            
        }
    }
}
