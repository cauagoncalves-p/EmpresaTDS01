using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Padaria
{
    public partial class frmVetores : Form
    {
        public frmVetores()
        {
            InitializeComponent();
        }

        private void adicionarnome()
        {
            int tamanho = int.Parse(txtTamanho.Text);
            string[] nomes = new string[tamanho];

           
            string palavra = txtNomes.Text;
            while (tamanho > 0) 
            {
                nomes[tamanho - 1] = palavra;
                tamanho--;
                MessageBox.Show(nomes[tamanho].ToString());
              
            }    
           
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
           adicionarnome();
        }

        private void btnSalvarNome_Click(object sender, EventArgs e)
        {

        }
    }
}
