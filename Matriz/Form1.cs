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

        int[,] prova1 = new int[1, 4];
        int[,] prova2 = new int[1, 4];
        int[,] prova3 = new int[1, 4];
        int[,] trabalho = new int[1, 4];
        string[,] aluno = new string[1, 4];

        //aluno[0,0] = "pedro";
        //notas[0,0] = 10;
        //notas[0,1] = 10;
        //notas[0,2] = 10;
        //notas[0,3] = 40;
       
        private void btnCarregarMatriz_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            //double prova1 = Convert.ToDouble(txtProva1.Text);
            //double prova2 = Convert.ToDouble(txtProva2.Text);
            //double prova3 = Convert.ToDouble(txtProva3.Text);
            //double trabalho = Convert.ToDouble(txtnotaTrabalho.Text);

            for (int i = 0; i < aluno.GetLength(0); i++) 
            {
                for (int j = 0; j < aluno.GetLength(1); j++) 
                {
                   


                }
            }
        }
    }
}
