namespace Matriz
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnCarregarMatriz = new System.Windows.Forms.Button();
            this.lblNomeAluno = new System.Windows.Forms.Label();
            this.lboListaMatriz = new System.Windows.Forms.ListBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnSair = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.txtProva1 = new System.Windows.Forms.TextBox();
            this.lblNota1 = new System.Windows.Forms.Label();
            this.txtnotaTrabalho = new System.Windows.Forms.TextBox();
            this.lblTrabalho = new System.Windows.Forms.Label();
            this.txtProva3 = new System.Windows.Forms.TextBox();
            this.lblNota3 = new System.Windows.Forms.Label();
            this.txtProva2 = new System.Windows.Forms.TextBox();
            this.lblNota2 = new System.Windows.Forms.Label();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCarregarMatriz
            // 
            this.btnCarregarMatriz.Location = new System.Drawing.Point(12, 351);
            this.btnCarregarMatriz.Name = "btnCarregarMatriz";
            this.btnCarregarMatriz.Size = new System.Drawing.Size(105, 56);
            this.btnCarregarMatriz.TabIndex = 5;
            this.btnCarregarMatriz.Text = "carregar matriz";
            this.btnCarregarMatriz.UseVisualStyleBackColor = true;
            this.btnCarregarMatriz.Click += new System.EventHandler(this.btnCarregarMatriz_Click);
            // 
            // lblNomeAluno
            // 
            this.lblNomeAluno.AutoSize = true;
            this.lblNomeAluno.Location = new System.Drawing.Point(27, 42);
            this.lblNomeAluno.Name = "lblNomeAluno";
            this.lblNomeAluno.Size = new System.Drawing.Size(76, 13);
            this.lblNomeAluno.TabIndex = 4;
            this.lblNomeAluno.Text = "Nom do aluno ";
            // 
            // lboListaMatriz
            // 
            this.lboListaMatriz.FormattingEnabled = true;
            this.lboListaMatriz.Location = new System.Drawing.Point(468, 42);
            this.lboListaMatriz.Name = "lboListaMatriz";
            this.lboListaMatriz.Size = new System.Drawing.Size(285, 303);
            this.lboListaMatriz.TabIndex = 5;
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(117, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 0;
            // 
            // btnSair
            // 
            this.btnSair.Location = new System.Drawing.Point(396, 351);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(105, 56);
            this.btnSair.TabIndex = 8;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(268, 351);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(105, 56);
            this.btnLimpar.TabIndex = 7;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // txtProva1
            // 
            this.txtProva1.Location = new System.Drawing.Point(117, 106);
            this.txtProva1.Name = "txtProva1";
            this.txtProva1.Size = new System.Drawing.Size(100, 20);
            this.txtProva1.TabIndex = 1;
            // 
            // lblNota1
            // 
            this.lblNota1.AutoSize = true;
            this.lblNota1.Location = new System.Drawing.Point(27, 113);
            this.lblNota1.Name = "lblNota1";
            this.lblNota1.Size = new System.Drawing.Size(44, 13);
            this.lblNota1.TabIndex = 10;
            this.lblNota1.Text = "Prova 1";
            // 
            // txtnotaTrabalho
            // 
            this.txtnotaTrabalho.Location = new System.Drawing.Point(117, 219);
            this.txtnotaTrabalho.Name = "txtnotaTrabalho";
            this.txtnotaTrabalho.Size = new System.Drawing.Size(100, 20);
            this.txtnotaTrabalho.TabIndex = 4;
            // 
            // lblTrabalho
            // 
            this.lblTrabalho.AutoSize = true;
            this.lblTrabalho.Location = new System.Drawing.Point(27, 219);
            this.lblTrabalho.Name = "lblTrabalho";
            this.lblTrabalho.Size = new System.Drawing.Size(49, 13);
            this.lblTrabalho.TabIndex = 12;
            this.lblTrabalho.Text = "Trabalho";
            // 
            // txtProva3
            // 
            this.txtProva3.Location = new System.Drawing.Point(117, 180);
            this.txtProva3.Name = "txtProva3";
            this.txtProva3.Size = new System.Drawing.Size(100, 20);
            this.txtProva3.TabIndex = 3;
        
            // lblNota3
            // 
            this.lblNota3.AutoSize = true;
            this.lblNota3.Location = new System.Drawing.Point(27, 187);
            this.lblNota3.Name = "lblNota3";
            this.lblNota3.Size = new System.Drawing.Size(44, 13);
            this.lblNota3.TabIndex = 14;
            this.lblNota3.Text = "Prova 3";
            // 
            // txtProva2
            // 
            this.txtProva2.Location = new System.Drawing.Point(117, 143);
            this.txtProva2.Name = "txtProva2";
            this.txtProva2.Size = new System.Drawing.Size(100, 20);
            this.txtProva2.TabIndex = 2;
            // 
            // lblNota2
            // 
            this.lblNota2.AutoSize = true;
            this.lblNota2.Location = new System.Drawing.Point(27, 146);
            this.lblNota2.Name = "lblNota2";
            this.lblNota2.Size = new System.Drawing.Size(44, 13);
            this.lblNota2.TabIndex = 16;
            this.lblNota2.Text = "Prova 2";
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(138, 351);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 56);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 441);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtProva2);
            this.Controls.Add(this.lblNota2);
            this.Controls.Add(this.txtProva3);
            this.Controls.Add(this.lblNota3);
            this.Controls.Add(this.txtnotaTrabalho);
            this.Controls.Add(this.lblTrabalho);
            this.Controls.Add(this.txtProva1);
            this.Controls.Add(this.lblNota1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lboListaMatriz);
            this.Controls.Add(this.lblNomeAluno);
            this.Controls.Add(this.btnCarregarMatriz);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCarregarMatriz;
        private System.Windows.Forms.Label lblNomeAluno;
        private System.Windows.Forms.ListBox lboListaMatriz;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.TextBox txtProva1;
        private System.Windows.Forms.Label lblNota1;
        private System.Windows.Forms.TextBox txtnotaTrabalho;
        private System.Windows.Forms.Label lblTrabalho;
        private System.Windows.Forms.TextBox txtProva3;
        private System.Windows.Forms.Label lblNota3;
        private System.Windows.Forms.TextBox txtProva2;
        private System.Windows.Forms.Label lblNota2;
        private System.Windows.Forms.Button btnAdicionar;
    }
}

