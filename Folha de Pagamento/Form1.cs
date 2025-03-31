using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Folha_de_Pagamento
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double imposto = 0;
        private double salario = 0;
       
        private void btnCalcular_Click(object sender, EventArgs e)
        {

            salario = Convert.ToDouble(nudSalario.Value);
            txtSalarioFolha.Text = salario.ToString("C2");


            if (salario <= 2259.20)
            {
                imposto = 0;
            }
            else if (salario > 2259.21 && salario <= 2826.65)
            {
                imposto = 7.5;
            }
            else if (salario > 2826.65 && salario <= 3751.05)
            {
                imposto = 15;
            }
            else if (salario > 3751.05 && salario <= 4664.68)
            {
                imposto = 22.5;
            }
            else
            {
                imposto = 27.5;
            }

            txtImpostoRenda.Text = $"{imposto}%";

            if (cbxPlano.CheckState == CheckState.Indeterminate) 
            {
                MessageBox.Show("Selecione se você tem plano ou não", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double precoPlano;

            if (cbxPlano.Checked)
            {
                precoPlano = 400;
            }
            else 
            {
                precoPlano = 0;
            }

            double precoClube;
            if (string.IsNullOrEmpty(cbxClube.Text)) 
            {
                MessageBox.Show("Selecione qual é seu clube de lazer", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            else 
            {
             

                if (cbxClube.Text == "Clube A")
                {
                    precoClube = 100;
                }
                else if (cbxClube.Text == "Clube B")
                {
                    precoClube = 50;
                }
                else 
                {
                    precoClube = 30;
                }
            }

            // Calculado o salario menos o imposto
            double calcImposto = (salario * imposto) / 100;
            salario -= calcImposto;
            // Calculado o salario menos os outros adicionais
            salario -= precoPlano + precoClube;
            
            txtSalarioLiquido.Text = salario.ToString();

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            dtpDataFolha.Value = DateTime.Now;
            nudSalario.Value = 0;
            txtImpostoRenda.Clear();
            txtSalarioFolha.Clear();
            txtSalarioLiquido.Clear();    
            cbxClube.Text = string.Empty;
            cbxPlano.CheckState = CheckState.Indeterminate;
        }
    }
}
