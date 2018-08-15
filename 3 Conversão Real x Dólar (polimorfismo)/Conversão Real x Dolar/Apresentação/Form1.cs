using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversão_Real_x_Dolar
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            Modelo.Controle controle = new Modelo.Controle(txbNumeroReal.Text, txbNumeroDolar.Text);

            if(controle.mensagem.Equals(""))
            {
                lblResposta.Text = controle.ToString();
            }

            else
            {
                MessageBox.Show(controle.mensagem);
            }
        }              
    }
}
