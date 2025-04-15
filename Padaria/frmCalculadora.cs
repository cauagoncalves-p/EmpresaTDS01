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
    public partial class frmCalculadora : Form
    {
        public frmCalculadora()
        {
            InitializeComponent();
        }

        public void LimparCampos() 
        {
            txtbNum1.Clear();
            txtbNum2.Clear();
            txtbResposta.Clear();
        }
        public void LimparCamposDesabilitados() 
        {
            txtbNum1.Clear();
            txtbNum2.Clear();
            txtbResposta.Clear();

            rdbtnDividir.Checked = false;
            rdbtnSoma.Checked = false;
            rdbtnMultiplicar.Checked = false;
            rdbtnSubtrair.Checked = false;
        }
        private void btnCalcular_Click(object sender, EventArgs e)
        {
            operacoes operacoes = new operacoes();  
            double num1, num2, res = 0;
            if (string.IsNullOrEmpty(txtbNum1.Text) || string.IsNullOrEmpty(txtbNum2.Text))
            {
                MessageBox.Show("Informe os valores a serem calculados");
                return;
            }

            try { 
                num1 = Convert.ToDouble(txtbNum1.Text);
                num2 = Convert.ToDouble(txtbNum2.Text);

                if (rdbtnSoma.Checked == false && rdbtnMultiplicar.Checked == false && rdbtnDividir.Checked == false && rdbtnSubtrair.Checked == false)
                {
                    MessageBox.Show("Selecionar uma operação", "Mensagem do sistema", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    if (rdbtnSoma.Checked)
                    {
                       
                        res = operacoes.Soma(num1, num2);
                    }
                    if (rdbtnSubtrair.Checked)
                    {
                       
                        res = operacoes.Subtratir(num1, num2);
                    }
                    if (rdbtnMultiplicar.Checked)
                    {
                      
                        res = operacoes.Multiplicar(num1, num2);
                    }
                    if (rdbtnDividir.Checked)
                    {
                        res = operacoes.Divisao(num1, num2);
                    }

                    txtbResposta.Text = res.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir somente numeros", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                LimparCampos();            
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            LimparCamposDesabilitados();
        }
    }
}
