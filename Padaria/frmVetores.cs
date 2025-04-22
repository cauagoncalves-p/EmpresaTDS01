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
        public static int tamanho = 0;
        private string[] nomes = new string[5];
        private int contador = 0;
        
        public frmVetores()
        {
            InitializeComponent();
        }

        private void adicionarnome()
        {
            //tamanho = int.Parse(txtTamanho.Text);
            for (int i = contador; i < nomes.Length; i++) 
            {
                if (txtNomes.Text == "") 
                {
                    MessageBox.Show("Nome Adicionado");
                    return;
                }
                txtNomes.Focus();
                string palavra = txtNomes.Text;
                nomes[i] = palavra;
                txtNomes.Clear();
                contador++;
            }
            listNome.Items.Clear();
            foreach (string s in nomes) 
            {
                listNome.Items.Add(s);  
            }  
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            adicionarnome();
           
        }
    }
}
