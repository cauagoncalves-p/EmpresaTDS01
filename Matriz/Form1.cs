using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Matriz
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[,] prova1 = new int[3,3];
        int[,] prova2 = new int[3, 3];
        int[,] prova3 = new int[3, 3];
        int[,] trabalho = new int[3, 3];
        string[,] resultado = new string[3, 3];
        double[,] media = new double[3, 3];
        string[,] aluno = new string[3, 3];
        int linha = 0;
        int coluna = 0;



        private void carregar()
        {
            int provaAluno1 = Convert.ToInt32(txtProva1.Text);
            int provaAluno2 = Convert.ToInt32(txtProva2.Text);
            int provaAluno3 = Convert.ToInt32(txtProva3.Text);
            int trabalhoAluno = Convert.ToInt32(txtnotaTrabalho.Text);


            lboListaMatriz.Items.Clear();
            try
            {
                aluno[linha, coluna] = txtNome.Text;
                prova1[linha, coluna] = provaAluno1;
                prova2[linha, coluna] = provaAluno2;
                prova3[linha, coluna] = provaAluno3;
                trabalho[linha, coluna] = trabalhoAluno; 
                txtNome.Clear();
                txtProva1.Clear();
                txtProva2.Clear();
                txtProva3.Clear();
                txtnotaTrabalho.Clear();

                txtNome.Focus();
            }
            catch (Exception) 
            {
                MessageBox.Show("A matriz atingiu seu limite!");
                return;
            } 
           
        }
        private void btnCarregarMatriz_Click(object sender, EventArgs e)
        { 
            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                for (int j = 0; j < aluno.GetLength(1); j++)
                {
                    lboListaMatriz.Items.Add($"Aluno(a): {aluno[i, j]}");
                    lboListaMatriz.Items.Add($"Nota da primeira prova: {prova1[i, j]}");
                    lboListaMatriz.Items.Add($"Nota da segunda prova: {prova2[i, j]}");
                    lboListaMatriz.Items.Add($"Nota da terceira prova: {prova3[i, j]}");
                    lboListaMatriz.Items.Add($"Nota do trabalho: {trabalho[i, j]}");
                    lboListaMatriz.Items.Add($"Média do aluno(a) {aluno[i,j]}: { media[i,j] = (double)(prova1[i, j] + prova2[i, j] + prova3[i, j] + trabalho[i, j]) / 4}");

                    if (media[i, j] >= 8)
                    {
                        resultado[i, j] = "Aprovado!";
                    }
                    else if (media[i, j] > 5)
                    {
                        resultado[i, j] = "Recuperação";
                    }
                    else
                    {
                        resultado[i, j] = "Reprovado";
                    }
                    lboListaMatriz.Items.Add($"Resultado: {resultado[i, j]}");
                    lboListaMatriz.Items.Add("");
                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtNome.Text == "" || txtProva1.Text == "" || txtProva2.Text == "" || txtProva3.Text == "" || txtnotaTrabalho.Text == "")
            {
                MessageBox.Show("Por favor inserir todos os campos!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int provaAluno1 = Convert.ToInt32(txtProva1.Text);
            int provaAluno2 = Convert.ToInt32(txtProva2.Text);
            int provaAluno3 = Convert.ToInt32(txtProva3.Text);
            int trabalhoAluno = Convert.ToInt32(txtnotaTrabalho.Text);

            if ((provaAluno1 < 0 || provaAluno1 > 10) || (provaAluno2 < 0 || provaAluno2 > 10) || (provaAluno3 < 0 || provaAluno3 > 10)
              || (trabalhoAluno < 0 || trabalhoAluno > 10))
            {
                MessageBox.Show("As notas vão de 0 até 10!");
                return;
            }

            carregar();

            coluna++;

            //[3;3]
            if (coluna >= aluno.GetLength(1))
            {
                coluna = 0;
                linha++;
                if (linha >= aluno.GetLength(0))
                {
                    MessageBox.Show("Todos os foram adicionados");
                    return;
                }
            }
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < aluno.GetLength(0); i++)
            {
                for (int j = 0; j < aluno.GetLength(1); j++)
                {
                    aluno[i, j] = string.Empty;
                    prova1[i, j] = 0;
                    prova2[i, j] = 0;
                    prova3[i, j] = 0;
                    trabalho[i, j] = 0;
                    media[i, j] = 0;
                }
            }

            lboListaMatriz.Items.Clear();
            MessageBox.Show("Matriz limpa com sucesso!");
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
