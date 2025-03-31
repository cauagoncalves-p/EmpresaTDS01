namespace Folha_de_Pagamento
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
            this.dtpDataFolha = new System.Windows.Forms.DateTimePicker();
            this.lblDataFolha = new System.Windows.Forms.Label();
            this.lblSalario = new System.Windows.Forms.Label();
            this.nudSalario = new System.Windows.Forms.NumericUpDown();
            this.cbxPlano = new System.Windows.Forms.CheckBox();
            this.lblClubeLazer = new System.Windows.Forms.Label();
            this.cbxClube = new System.Windows.Forms.ComboBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblSalarioFolha = new System.Windows.Forms.Label();
            this.lblImpostoRenda = new System.Windows.Forms.Label();
            this.lblSalarioLiquido = new System.Windows.Forms.Label();
            this.txtSalarioFolha = new System.Windows.Forms.TextBox();
            this.txtImpostoRenda = new System.Windows.Forms.TextBox();
            this.txtSalarioLiquido = new System.Windows.Forms.TextBox();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpDataFolha
            // 
            this.dtpDataFolha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataFolha.Location = new System.Drawing.Point(29, 62);
            this.dtpDataFolha.Name = "dtpDataFolha";
            this.dtpDataFolha.Size = new System.Drawing.Size(111, 20);
            this.dtpDataFolha.TabIndex = 0;
            // 
            // lblDataFolha
            // 
            this.lblDataFolha.AutoSize = true;
            this.lblDataFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataFolha.Location = new System.Drawing.Point(26, 32);
            this.lblDataFolha.Name = "lblDataFolha";
            this.lblDataFolha.Size = new System.Drawing.Size(90, 16);
            this.lblDataFolha.TabIndex = 1;
            this.lblDataFolha.Text = "Data de folha ";
            // 
            // lblSalario
            // 
            this.lblSalario.AutoSize = true;
            this.lblSalario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalario.Location = new System.Drawing.Point(26, 109);
            this.lblSalario.Name = "lblSalario";
            this.lblSalario.Size = new System.Drawing.Size(53, 16);
            this.lblSalario.TabIndex = 2;
            this.lblSalario.Text = "Salário ";
            // 
            // nudSalario
            // 
            this.nudSalario.DecimalPlaces = 2;
            this.nudSalario.Location = new System.Drawing.Point(29, 143);
            this.nudSalario.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.nudSalario.Name = "nudSalario";
            this.nudSalario.Size = new System.Drawing.Size(120, 20);
            this.nudSalario.TabIndex = 3;
            // 
            // cbxPlano
            // 
            this.cbxPlano.AutoSize = true;
            this.cbxPlano.Checked = true;
            this.cbxPlano.CheckState = System.Windows.Forms.CheckState.Indeterminate;
            this.cbxPlano.Location = new System.Drawing.Point(29, 188);
            this.cbxPlano.Name = "cbxPlano";
            this.cbxPlano.Size = new System.Drawing.Size(102, 17);
            this.cbxPlano.TabIndex = 4;
            this.cbxPlano.Text = "Plano de Saúde";
            this.cbxPlano.UseVisualStyleBackColor = true;
            // 
            // lblClubeLazer
            // 
            this.lblClubeLazer.AutoSize = true;
            this.lblClubeLazer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClubeLazer.Location = new System.Drawing.Point(26, 240);
            this.lblClubeLazer.Name = "lblClubeLazer";
            this.lblClubeLazer.Size = new System.Drawing.Size(93, 16);
            this.lblClubeLazer.TabIndex = 5;
            this.lblClubeLazer.Text = "Clube de lazer";
            // 
            // cbxClube
            // 
            this.cbxClube.FormattingEnabled = true;
            this.cbxClube.Items.AddRange(new object[] {
            "Clube A",
            "Clube B",
            "Clube C"});
            this.cbxClube.Location = new System.Drawing.Point(28, 271);
            this.cbxClube.Name = "cbxClube";
            this.cbxClube.Size = new System.Drawing.Size(121, 21);
            this.cbxClube.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Location = new System.Drawing.Point(260, 25);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(75, 23);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblSalarioFolha
            // 
            this.lblSalarioFolha.AutoSize = true;
            this.lblSalarioFolha.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioFolha.Location = new System.Drawing.Point(257, 77);
            this.lblSalarioFolha.Name = "lblSalarioFolha";
            this.lblSalarioFolha.Size = new System.Drawing.Size(87, 16);
            this.lblSalarioFolha.TabIndex = 8;
            this.lblSalarioFolha.Text = "Salário Folha";
            // 
            // lblImpostoRenda
            // 
            this.lblImpostoRenda.AutoSize = true;
            this.lblImpostoRenda.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblImpostoRenda.Location = new System.Drawing.Point(257, 122);
            this.lblImpostoRenda.Name = "lblImpostoRenda";
            this.lblImpostoRenda.Size = new System.Drawing.Size(118, 16);
            this.lblImpostoRenda.TabIndex = 9;
            this.lblImpostoRenda.Text = "Imposto de Renda";
            // 
            // lblSalarioLiquido
            // 
            this.lblSalarioLiquido.AutoSize = true;
            this.lblSalarioLiquido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSalarioLiquido.Location = new System.Drawing.Point(257, 178);
            this.lblSalarioLiquido.Name = "lblSalarioLiquido";
            this.lblSalarioLiquido.Size = new System.Drawing.Size(97, 16);
            this.lblSalarioLiquido.TabIndex = 10;
            this.lblSalarioLiquido.Text = "Salário Liquido";
            // 
            // txtSalarioFolha
            // 
            this.txtSalarioFolha.Enabled = false;
            this.txtSalarioFolha.Location = new System.Drawing.Point(381, 73);
            this.txtSalarioFolha.Name = "txtSalarioFolha";
            this.txtSalarioFolha.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioFolha.TabIndex = 11;
            // 
            // txtImpostoRenda
            // 
            this.txtImpostoRenda.Enabled = false;
            this.txtImpostoRenda.Location = new System.Drawing.Point(381, 118);
            this.txtImpostoRenda.Name = "txtImpostoRenda";
            this.txtImpostoRenda.Size = new System.Drawing.Size(100, 20);
            this.txtImpostoRenda.TabIndex = 12;
            // 
            // txtSalarioLiquido
            // 
            this.txtSalarioLiquido.Enabled = false;
            this.txtSalarioLiquido.Location = new System.Drawing.Point(381, 174);
            this.txtSalarioLiquido.Name = "txtSalarioLiquido";
            this.txtSalarioLiquido.Size = new System.Drawing.Size(100, 20);
            this.txtSalarioLiquido.TabIndex = 13;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(406, 25);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 14;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(516, 345);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.txtSalarioLiquido);
            this.Controls.Add(this.txtImpostoRenda);
            this.Controls.Add(this.txtSalarioFolha);
            this.Controls.Add(this.lblSalarioLiquido);
            this.Controls.Add(this.lblImpostoRenda);
            this.Controls.Add(this.lblSalarioFolha);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.cbxClube);
            this.Controls.Add(this.lblClubeLazer);
            this.Controls.Add(this.cbxPlano);
            this.Controls.Add(this.nudSalario);
            this.Controls.Add(this.lblSalario);
            this.Controls.Add(this.lblDataFolha);
            this.Controls.Add(this.dtpDataFolha);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Folha de pagamento";
            ((System.ComponentModel.ISupportInitialize)(this.nudSalario)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataFolha;
        private System.Windows.Forms.Label lblDataFolha;
        private System.Windows.Forms.Label lblSalario;
        private System.Windows.Forms.NumericUpDown nudSalario;
        private System.Windows.Forms.CheckBox cbxPlano;
        private System.Windows.Forms.Label lblClubeLazer;
        private System.Windows.Forms.ComboBox cbxClube;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblSalarioFolha;
        private System.Windows.Forms.Label lblImpostoRenda;
        private System.Windows.Forms.Label lblSalarioLiquido;
        private System.Windows.Forms.TextBox txtSalarioFolha;
        private System.Windows.Forms.TextBox txtImpostoRenda;
        private System.Windows.Forms.TextBox txtSalarioLiquido;
        private System.Windows.Forms.Button btnLimpar;
    }
}

