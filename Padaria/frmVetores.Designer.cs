namespace Padaria
{
    partial class frmVetores
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
            this.lblTamanho = new System.Windows.Forms.Label();
            this.lblInsiraNome = new System.Windows.Forms.Label();
            this.gpxNomes = new System.Windows.Forms.GroupBox();
            this.btnSalvarNome = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.txtNomes = new System.Windows.Forms.TextBox();
            this.listNome = new System.Windows.Forms.ListBox();
            this.txtTamanho = new System.Windows.Forms.TextBox();
            this.gpxNomes.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblTamanho
            // 
            this.lblTamanho.AutoSize = true;
            this.lblTamanho.Location = new System.Drawing.Point(17, 42);
            this.lblTamanho.Name = "lblTamanho";
            this.lblTamanho.Size = new System.Drawing.Size(52, 13);
            this.lblTamanho.TabIndex = 0;
            this.lblTamanho.Text = "Tamanho";
            // 
            // lblInsiraNome
            // 
            this.lblInsiraNome.AutoSize = true;
            this.lblInsiraNome.Location = new System.Drawing.Point(17, 149);
            this.lblInsiraNome.Name = "lblInsiraNome";
            this.lblInsiraNome.Size = new System.Drawing.Size(66, 13);
            this.lblInsiraNome.TabIndex = 1;
            this.lblInsiraNome.Text = "Insira nomes";
            // 
            // gpxNomes
            // 
            this.gpxNomes.Controls.Add(this.btnSalvarNome);
            this.gpxNomes.Controls.Add(this.btnAdicionar);
            this.gpxNomes.Controls.Add(this.txtNomes);
            this.gpxNomes.Controls.Add(this.listNome);
            this.gpxNomes.Controls.Add(this.txtTamanho);
            this.gpxNomes.Controls.Add(this.lblTamanho);
            this.gpxNomes.Controls.Add(this.lblInsiraNome);
            this.gpxNomes.Location = new System.Drawing.Point(12, 26);
            this.gpxNomes.Name = "gpxNomes";
            this.gpxNomes.Size = new System.Drawing.Size(748, 398);
            this.gpxNomes.TabIndex = 2;
            this.gpxNomes.TabStop = false;
            this.gpxNomes.Text = "Nomes";
            // 
            // btnSalvarNome
            // 
            this.btnSalvarNome.Location = new System.Drawing.Point(154, 328);
            this.btnSalvarNome.Name = "btnSalvarNome";
            this.btnSalvarNome.Size = new System.Drawing.Size(105, 40);
            this.btnSalvarNome.TabIndex = 5;
            this.btnSalvarNome.Text = "Salavar nome";
            this.btnSalvarNome.UseVisualStyleBackColor = true;
            this.btnSalvarNome.Click += new System.EventHandler(this.btnSalvarNome_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(20, 328);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(105, 40);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "Adicionar nome";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // txtNomes
            // 
            this.txtNomes.Location = new System.Drawing.Point(20, 185);
            this.txtNomes.Name = "txtNomes";
            this.txtNomes.Size = new System.Drawing.Size(100, 20);
            this.txtNomes.TabIndex = 4;
            // 
            // listNome
            // 
            this.listNome.FormattingEnabled = true;
            this.listNome.Location = new System.Drawing.Point(452, 48);
            this.listNome.Name = "listNome";
            this.listNome.Size = new System.Drawing.Size(254, 303);
            this.listNome.TabIndex = 3;
            // 
            // txtTamanho
            // 
            this.txtTamanho.Location = new System.Drawing.Point(20, 75);
            this.txtTamanho.Name = "txtTamanho";
            this.txtTamanho.Size = new System.Drawing.Size(100, 20);
            this.txtTamanho.TabIndex = 2;
            // 
            // frmVetores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gpxNomes);
            this.Name = "frmVetores";
            this.Text = "frmVetores";
            this.gpxNomes.ResumeLayout(false);
            this.gpxNomes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblTamanho;
        private System.Windows.Forms.Label lblInsiraNome;
        private System.Windows.Forms.GroupBox gpxNomes;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListBox listNome;
        private System.Windows.Forms.TextBox txtTamanho;
        private System.Windows.Forms.TextBox txtNomes;
        private System.Windows.Forms.Button btnSalvarNome;
    }
}