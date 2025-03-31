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

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            /* Declarando uma variável no C#
             *  tipo e nome
             */

            //int valor1, valor4, resp;
            //double valor2; 
            //float valor3;
            //bool flag;
            //string name;
            //char sexo;

            //// Inicializando as variáveis

            //valor1 = 10;
            //valor4 = 20;
            //resp = valor1 + valor4;

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
                        res = num1 + num2;
                    }
                    if (rdbtnSubtrair.Checked)
                    {
                        res = num1 - num2;
                    }
                    if (rdbtnMultiplicar.Checked)
                    {
                        res = num1 * num2;
                    }
                    if (rdbtnDividir.Checked)
                    {
                        if (num2 == 0)
                        {
                            MessageBox.Show("Impossivel dividir por zero", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
                            res = 0;
                        }
                        else
                        {
                            res = num1 / num2;
                        }

                    }

                    txtbResposta.Text = res.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Favor inserir somente numeros", "Error", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Error, MessageBoxDefaultButton.Button1);
            }

        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtbNum1.Clear();
            txtbNum2.Clear();
            txtbResposta.Clear();

            rdbtnDividir.Checked = false;
            rdbtnSoma.Checked = false;
            rdbtnMultiplicar.Checked = false;
            rdbtnSubtrair.Checked = false;
        }
    }
}
