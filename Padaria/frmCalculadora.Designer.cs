namespace Padaria
{
    partial class frmCalculadora
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCalculadora));
            this.lblNum1 = new System.Windows.Forms.Label();
            this.lblNum2 = new System.Windows.Forms.Label();
            this.lblResposta = new System.Windows.Forms.Label();
            this.txtbNum1 = new System.Windows.Forms.TextBox();
            this.txtbNum2 = new System.Windows.Forms.TextBox();
            this.txtbResposta = new System.Windows.Forms.TextBox();
            this.gpbOperacoes = new System.Windows.Forms.GroupBox();
            this.rdbtnDividir = new System.Windows.Forms.RadioButton();
            this.rdbtnMultiplicar = new System.Windows.Forms.RadioButton();
            this.rdbtnSubtrair = new System.Windows.Forms.RadioButton();
            this.rdbtnSoma = new System.Windows.Forms.RadioButton();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.gpbOperacoes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblNum1
            // 
            this.lblNum1.AutoSize = true;
            this.lblNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum1.Location = new System.Drawing.Point(45, 41);
            this.lblNum1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum1.Name = "lblNum1";
            this.lblNum1.Size = new System.Drawing.Size(105, 25);
            this.lblNum1.TabIndex = 0;
            this.lblNum1.Text = "Numero 1";
            // 
            // lblNum2
            // 
            this.lblNum2.AutoSize = true;
            this.lblNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNum2.Location = new System.Drawing.Point(43, 103);
            this.lblNum2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNum2.Name = "lblNum2";
            this.lblNum2.Size = new System.Drawing.Size(105, 25);
            this.lblNum2.TabIndex = 1;
            this.lblNum2.Text = "Numero 2";
            // 
            // lblResposta
            // 
            this.lblResposta.AutoSize = true;
            this.lblResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResposta.Location = new System.Drawing.Point(43, 196);
            this.lblResposta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblResposta.Name = "lblResposta";
            this.lblResposta.Size = new System.Drawing.Size(103, 25);
            this.lblResposta.TabIndex = 2;
            this.lblResposta.Text = "Resposta";
            // 
            // txtbNum1
            // 
            this.txtbNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNum1.Location = new System.Drawing.Point(49, 69);
            this.txtbNum1.MaxLength = 10;
            this.txtbNum1.Name = "txtbNum1";
            this.txtbNum1.Size = new System.Drawing.Size(157, 31);
            this.txtbNum1.TabIndex = 0;
            // 
            // txtbNum2
            // 
            this.txtbNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbNum2.Location = new System.Drawing.Point(48, 131);
            this.txtbNum2.MaxLength = 10;
            this.txtbNum2.Name = "txtbNum2";
            this.txtbNum2.Size = new System.Drawing.Size(157, 31);
            this.txtbNum2.TabIndex = 1;
            // 
            // txtbResposta
            // 
            this.txtbResposta.Enabled = false;
            this.txtbResposta.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbResposta.Location = new System.Drawing.Point(49, 224);
            this.txtbResposta.MaxLength = 10;
            this.txtbResposta.Name = "txtbResposta";
            this.txtbResposta.Size = new System.Drawing.Size(157, 31);
            this.txtbResposta.TabIndex = 2;
            // 
            // gpbOperacoes
            // 
            this.gpbOperacoes.Controls.Add(this.rdbtnDividir);
            this.gpbOperacoes.Controls.Add(this.rdbtnMultiplicar);
            this.gpbOperacoes.Controls.Add(this.rdbtnSubtrair);
            this.gpbOperacoes.Controls.Add(this.rdbtnSoma);
            this.gpbOperacoes.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbOperacoes.Location = new System.Drawing.Point(327, 41);
            this.gpbOperacoes.Name = "gpbOperacoes";
            this.gpbOperacoes.Size = new System.Drawing.Size(181, 214);
            this.gpbOperacoes.TabIndex = 3;
            this.gpbOperacoes.TabStop = false;
            this.gpbOperacoes.Text = "Operações";
            // 
            // rdbtnDividir
            // 
            this.rdbtnDividir.AutoSize = true;
            this.rdbtnDividir.Location = new System.Drawing.Point(35, 146);
            this.rdbtnDividir.Name = "rdbtnDividir";
            this.rdbtnDividir.Size = new System.Drawing.Size(79, 28);
            this.rdbtnDividir.TabIndex = 7;
            this.rdbtnDividir.TabStop = true;
            this.rdbtnDividir.Text = "Dividir";
            this.rdbtnDividir.UseVisualStyleBackColor = true;
            // 
            // rdbtnMultiplicar
            // 
            this.rdbtnMultiplicar.AutoSize = true;
            this.rdbtnMultiplicar.Location = new System.Drawing.Point(35, 112);
            this.rdbtnMultiplicar.Name = "rdbtnMultiplicar";
            this.rdbtnMultiplicar.Size = new System.Drawing.Size(112, 28);
            this.rdbtnMultiplicar.TabIndex = 6;
            this.rdbtnMultiplicar.TabStop = true;
            this.rdbtnMultiplicar.Text = "Multiplicar";
            this.rdbtnMultiplicar.UseVisualStyleBackColor = true;
            // 
            // rdbtnSubtrair
            // 
            this.rdbtnSubtrair.AutoSize = true;
            this.rdbtnSubtrair.Location = new System.Drawing.Point(35, 78);
            this.rdbtnSubtrair.Name = "rdbtnSubtrair";
            this.rdbtnSubtrair.Size = new System.Drawing.Size(92, 28);
            this.rdbtnSubtrair.TabIndex = 5;
            this.rdbtnSubtrair.TabStop = true;
            this.rdbtnSubtrair.Text = "Subtrair";
            this.rdbtnSubtrair.UseVisualStyleBackColor = true;
            // 
            // rdbtnSoma
            // 
            this.rdbtnSoma.AutoSize = true;
            this.rdbtnSoma.Location = new System.Drawing.Point(35, 44);
            this.rdbtnSoma.Name = "rdbtnSoma";
            this.rdbtnSoma.Size = new System.Drawing.Size(83, 28);
            this.rdbtnSoma.TabIndex = 4;
            this.rdbtnSoma.TabStop = true;
            this.rdbtnSoma.Text = "Somar";
            this.rdbtnSoma.UseVisualStyleBackColor = true;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Image = ((System.Drawing.Image)(resources.GetObject("btnCalcular.Image")));
            this.btnCalcular.Location = new System.Drawing.Point(622, 84);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(120, 50);
            this.btnCalcular.TabIndex = 8;
            this.btnCalcular.Text = "&Calcular";
            this.btnCalcular.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Image = ((System.Drawing.Image)(resources.GetObject("btnLimpar.Image")));
            this.btnLimpar.Location = new System.Drawing.Point(622, 140);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(120, 50);
            this.btnLimpar.TabIndex = 9;
            this.btnLimpar.Text = "&Limpar";
            this.btnLimpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnSair
            // 
            this.btnSair.Image = ((System.Drawing.Image)(resources.GetObject("btnSair.Image")));
            this.btnSair.Location = new System.Drawing.Point(622, 196);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(120, 50);
            this.btnSair.TabIndex = 10;
            this.btnSair.Text = "&Sair";
            this.btnSair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // frmCalculadora
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 361);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.gpbOperacoes);
            this.Controls.Add(this.txtbResposta);
            this.Controls.Add(this.txtbNum2);
            this.Controls.Add(this.txtbNum1);
            this.Controls.Add(this.lblResposta);
            this.Controls.Add(this.lblNum2);
            this.Controls.Add(this.lblNum1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCalculadora";
            this.Text = "Padaria - Calculadora";
            this.gpbOperacoes.ResumeLayout(false);
            this.gpbOperacoes.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNum1;
        private System.Windows.Forms.Label lblNum2;
        private System.Windows.Forms.Label lblResposta;
        private System.Windows.Forms.TextBox txtbNum1;
        private System.Windows.Forms.TextBox txtbNum2;
        private System.Windows.Forms.TextBox txtbResposta;
        private System.Windows.Forms.GroupBox gpbOperacoes;
        private System.Windows.Forms.RadioButton rdbtnDividir;
        private System.Windows.Forms.RadioButton rdbtnMultiplicar;
        private System.Windows.Forms.RadioButton rdbtnSubtrair;
        private System.Windows.Forms.RadioButton rdbtnSoma;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnSair;
    }
}