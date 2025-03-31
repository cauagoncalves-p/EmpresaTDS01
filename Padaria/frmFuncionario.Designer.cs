namespace Padaria
{
    partial class frmFuncionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFuncionario));
            this.gpbDadosPessoais = new System.Windows.Forms.GroupBox();
            this.gpbFoto = new System.Windows.Forms.GroupBox();
            this.pcbFotoDoFuncionario = new System.Windows.Forms.PictureBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnUpload = new System.Windows.Forms.Button();
            this.btnAprovar = new System.Windows.Forms.Button();
            this.gpbSexo = new System.Windows.Forms.GroupBox();
            this.rdbtnNaoDeclarar = new System.Windows.Forms.RadioButton();
            this.rdbtnMasc = new System.Windows.Forms.RadioButton();
            this.rdbtnFem = new System.Windows.Forms.RadioButton();
            this.mskbTelefone = new System.Windows.Forms.MaskedTextBox();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.dttmNascimento = new System.Windows.Forms.DateTimePicker();
            this.lblNascimento = new System.Windows.Forms.Label();
            this.mskbCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txtbEmail = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtbNome = new System.Windows.Forms.TextBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtbCodigo = new System.Windows.Forms.TextBox();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.gpbEndereco = new System.Windows.Forms.GroupBox();
            this.txtbComplemento = new System.Windows.Forms.TextBox();
            this.lblComplemento = new System.Windows.Forms.Label();
            this.pnlCRUD = new System.Windows.Forms.Panel();
            this.btnVoltar = new System.Windows.Forms.Button();
            this.btnLimparCad = new System.Windows.Forms.Button();
            this.btnPesqisarCad = new System.Windows.Forms.Button();
            this.btnExcluirCad = new System.Windows.Forms.Button();
            this.btnAlterarCad = new System.Windows.Forms.Button();
            this.btnNovo = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.txtbNumero = new System.Windows.Forms.TextBox();
            this.lblNumero = new System.Windows.Forms.Label();
            this.cmbbEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.txtbCidade = new System.Windows.Forms.TextBox();
            this.lblCidade = new System.Windows.Forms.Label();
            this.mskbCEP = new System.Windows.Forms.MaskedTextBox();
            this.txtbBairro = new System.Windows.Forms.TextBox();
            this.lblBairro = new System.Windows.Forms.Label();
            this.txtbLogradouro = new System.Windows.Forms.TextBox();
            this.lblLogradouro = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.gpbDadosPessoais.SuspendLayout();
            this.gpbFoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoDoFuncionario)).BeginInit();
            this.gpbSexo.SuspendLayout();
            this.gpbEndereco.SuspendLayout();
            this.pnlCRUD.SuspendLayout();
            this.SuspendLayout();
            // 
            // gpbDadosPessoais
            // 
            this.gpbDadosPessoais.Controls.Add(this.gpbFoto);
            this.gpbDadosPessoais.Controls.Add(this.gpbSexo);
            this.gpbDadosPessoais.Controls.Add(this.mskbTelefone);
            this.gpbDadosPessoais.Controls.Add(this.lblTelefone);
            this.gpbDadosPessoais.Controls.Add(this.dttmNascimento);
            this.gpbDadosPessoais.Controls.Add(this.lblNascimento);
            this.gpbDadosPessoais.Controls.Add(this.mskbCPF);
            this.gpbDadosPessoais.Controls.Add(this.lblCPF);
            this.gpbDadosPessoais.Controls.Add(this.txtbEmail);
            this.gpbDadosPessoais.Controls.Add(this.lblEmail);
            this.gpbDadosPessoais.Controls.Add(this.txtbNome);
            this.gpbDadosPessoais.Controls.Add(this.lblNome);
            this.gpbDadosPessoais.Controls.Add(this.txtbCodigo);
            this.gpbDadosPessoais.Controls.Add(this.lblCodigo);
            this.gpbDadosPessoais.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDadosPessoais.Location = new System.Drawing.Point(12, 2);
            this.gpbDadosPessoais.Name = "gpbDadosPessoais";
            this.gpbDadosPessoais.Size = new System.Drawing.Size(760, 299);
            this.gpbDadosPessoais.TabIndex = 0;
            this.gpbDadosPessoais.TabStop = false;
            this.gpbDadosPessoais.Text = "Dados pessoais";
            // 
            // gpbFoto
            // 
            this.gpbFoto.Controls.Add(this.pcbFotoDoFuncionario);
            this.gpbFoto.Controls.Add(this.btnCancelar);
            this.gpbFoto.Controls.Add(this.btnUpload);
            this.gpbFoto.Controls.Add(this.btnAprovar);
            this.gpbFoto.Location = new System.Drawing.Point(229, 117);
            this.gpbFoto.Name = "gpbFoto";
            this.gpbFoto.Size = new System.Drawing.Size(213, 173);
            this.gpbFoto.TabIndex = 11;
            this.gpbFoto.TabStop = false;
            this.gpbFoto.Text = "Foto";
            // 
            // pcbFotoDoFuncionario
            // 
            this.pcbFotoDoFuncionario.Location = new System.Drawing.Point(6, 20);
            this.pcbFotoDoFuncionario.Name = "pcbFotoDoFuncionario";
            this.pcbFotoDoFuncionario.Size = new System.Drawing.Size(146, 147);
            this.pcbFotoDoFuncionario.TabIndex = 13;
            this.pcbFotoDoFuncionario.TabStop = false;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Image = ((System.Drawing.Image)(resources.GetObject("btnCancelar.Image")));
            this.btnCancelar.Location = new System.Drawing.Point(162, 122);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(45, 45);
            this.btnCancelar.TabIndex = 14;
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnUpload
            // 
            this.btnUpload.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpload.Image = ((System.Drawing.Image)(resources.GetObject("btnUpload.Image")));
            this.btnUpload.Location = new System.Drawing.Point(162, 20);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(45, 45);
            this.btnUpload.TabIndex = 12;
            this.btnUpload.UseVisualStyleBackColor = true;
            // 
            // btnAprovar
            // 
            this.btnAprovar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAprovar.Image = ((System.Drawing.Image)(resources.GetObject("btnAprovar.Image")));
            this.btnAprovar.Location = new System.Drawing.Point(162, 71);
            this.btnAprovar.Name = "btnAprovar";
            this.btnAprovar.Size = new System.Drawing.Size(45, 45);
            this.btnAprovar.TabIndex = 13;
            this.btnAprovar.UseVisualStyleBackColor = true;
            // 
            // gpbSexo
            // 
            this.gpbSexo.Controls.Add(this.rdbtnNaoDeclarar);
            this.gpbSexo.Controls.Add(this.rdbtnMasc);
            this.gpbSexo.Controls.Add(this.rdbtnFem);
            this.gpbSexo.Location = new System.Drawing.Point(17, 117);
            this.gpbSexo.Name = "gpbSexo";
            this.gpbSexo.Size = new System.Drawing.Size(180, 129);
            this.gpbSexo.TabIndex = 7;
            this.gpbSexo.TabStop = false;
            this.gpbSexo.Text = "Sexo";
            // 
            // rdbtnNaoDeclarar
            // 
            this.rdbtnNaoDeclarar.AutoSize = true;
            this.rdbtnNaoDeclarar.Location = new System.Drawing.Point(6, 88);
            this.rdbtnNaoDeclarar.Name = "rdbtnNaoDeclarar";
            this.rdbtnNaoDeclarar.Size = new System.Drawing.Size(170, 24);
            this.rdbtnNaoDeclarar.TabIndex = 10;
            this.rdbtnNaoDeclarar.TabStop = true;
            this.rdbtnNaoDeclarar.Text = "Desejo não informar";
            this.rdbtnNaoDeclarar.UseVisualStyleBackColor = true;
            // 
            // rdbtnMasc
            // 
            this.rdbtnMasc.AutoSize = true;
            this.rdbtnMasc.Location = new System.Drawing.Point(6, 58);
            this.rdbtnMasc.Name = "rdbtnMasc";
            this.rdbtnMasc.Size = new System.Drawing.Size(98, 24);
            this.rdbtnMasc.TabIndex = 9;
            this.rdbtnMasc.TabStop = true;
            this.rdbtnMasc.Text = "Masculino";
            this.rdbtnMasc.UseVisualStyleBackColor = true;
            // 
            // rdbtnFem
            // 
            this.rdbtnFem.AutoSize = true;
            this.rdbtnFem.Location = new System.Drawing.Point(6, 28);
            this.rdbtnFem.Name = "rdbtnFem";
            this.rdbtnFem.Size = new System.Drawing.Size(92, 24);
            this.rdbtnFem.TabIndex = 8;
            this.rdbtnFem.TabStop = true;
            this.rdbtnFem.Text = "Feminino";
            this.rdbtnFem.UseVisualStyleBackColor = true;
            // 
            // mskbTelefone
            // 
            this.mskbTelefone.Location = new System.Drawing.Point(578, 79);
            this.mskbTelefone.Mask = "00000-0000";
            this.mskbTelefone.Name = "mskbTelefone";
            this.mskbTelefone.Size = new System.Drawing.Size(93, 26);
            this.mskbTelefone.TabIndex = 6;
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(501, 82);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(71, 20);
            this.lblTelefone.TabIndex = 9;
            this.lblTelefone.Text = "Telefone";
            // 
            // dttmNascimento
            // 
            this.dttmNascimento.Checked = false;
            this.dttmNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dttmNascimento.Location = new System.Drawing.Point(359, 79);
            this.dttmNascimento.Name = "dttmNascimento";
            this.dttmNascimento.Size = new System.Drawing.Size(127, 26);
            this.dttmNascimento.TabIndex = 5;
            // 
            // lblNascimento
            // 
            this.lblNascimento.AutoSize = true;
            this.lblNascimento.Location = new System.Drawing.Point(199, 82);
            this.lblNascimento.Name = "lblNascimento";
            this.lblNascimento.Size = new System.Drawing.Size(154, 20);
            this.lblNascimento.TabIndex = 8;
            this.lblNascimento.Text = "Data de Nascimento";
            // 
            // mskbCPF
            // 
            this.mskbCPF.Location = new System.Drawing.Point(59, 79);
            this.mskbCPF.Mask = "000,000,000-00";
            this.mskbCPF.Name = "mskbCPF";
            this.mskbCPF.Size = new System.Drawing.Size(130, 26);
            this.mskbCPF.TabIndex = 4;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(13, 82);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(40, 20);
            this.lblCPF.TabIndex = 6;
            this.lblCPF.Text = "CPF";
            // 
            // txtbEmail
            // 
            this.txtbEmail.Location = new System.Drawing.Point(560, 35);
            this.txtbEmail.MaxLength = 100;
            this.txtbEmail.Name = "txtbEmail";
            this.txtbEmail.Size = new System.Drawing.Size(180, 26);
            this.txtbEmail.TabIndex = 3;
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(501, 38);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(53, 20);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "E-mail";
            // 
            // txtbNome
            // 
            this.txtbNome.Location = new System.Drawing.Point(256, 35);
            this.txtbNome.MaxLength = 100;
            this.txtbNome.Name = "txtbNome";
            this.txtbNome.Size = new System.Drawing.Size(230, 26);
            this.txtbNome.TabIndex = 2;
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(199, 38);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(51, 20);
            this.lblNome.TabIndex = 2;
            this.lblNome.Text = "Nome";
            // 
            // txtbCodigo
            // 
            this.txtbCodigo.Enabled = false;
            this.txtbCodigo.Location = new System.Drawing.Point(78, 35);
            this.txtbCodigo.MaxLength = 10;
            this.txtbCodigo.Name = "txtbCodigo";
            this.txtbCodigo.Size = new System.Drawing.Size(110, 26);
            this.txtbCodigo.TabIndex = 1;
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(13, 38);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(59, 20);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // gpbEndereco
            // 
            this.gpbEndereco.Controls.Add(this.txtbComplemento);
            this.gpbEndereco.Controls.Add(this.lblComplemento);
            this.gpbEndereco.Controls.Add(this.pnlCRUD);
            this.gpbEndereco.Controls.Add(this.txtbNumero);
            this.gpbEndereco.Controls.Add(this.lblNumero);
            this.gpbEndereco.Controls.Add(this.cmbbEstado);
            this.gpbEndereco.Controls.Add(this.lblEstado);
            this.gpbEndereco.Controls.Add(this.txtbCidade);
            this.gpbEndereco.Controls.Add(this.lblCidade);
            this.gpbEndereco.Controls.Add(this.mskbCEP);
            this.gpbEndereco.Controls.Add(this.txtbBairro);
            this.gpbEndereco.Controls.Add(this.lblBairro);
            this.gpbEndereco.Controls.Add(this.txtbLogradouro);
            this.gpbEndereco.Controls.Add(this.lblLogradouro);
            this.gpbEndereco.Controls.Add(this.lblCEP);
            this.gpbEndereco.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbEndereco.Location = new System.Drawing.Point(12, 307);
            this.gpbEndereco.Name = "gpbEndereco";
            this.gpbEndereco.Size = new System.Drawing.Size(760, 242);
            this.gpbEndereco.TabIndex = 15;
            this.gpbEndereco.TabStop = false;
            this.gpbEndereco.Text = "Endereço";
            // 
            // txtbComplemento
            // 
            this.txtbComplemento.Location = new System.Drawing.Point(606, 75);
            this.txtbComplemento.MaxLength = 30;
            this.txtbComplemento.Name = "txtbComplemento";
            this.txtbComplemento.Size = new System.Drawing.Size(145, 26);
            this.txtbComplemento.TabIndex = 20;
            // 
            // lblComplemento
            // 
            this.lblComplemento.AutoSize = true;
            this.lblComplemento.Location = new System.Drawing.Point(492, 78);
            this.lblComplemento.Name = "lblComplemento";
            this.lblComplemento.Size = new System.Drawing.Size(108, 20);
            this.lblComplemento.TabIndex = 22;
            this.lblComplemento.Text = "Complemento";
            // 
            // pnlCRUD
            // 
            this.pnlCRUD.Controls.Add(this.btnVoltar);
            this.pnlCRUD.Controls.Add(this.btnLimparCad);
            this.pnlCRUD.Controls.Add(this.btnPesqisarCad);
            this.pnlCRUD.Controls.Add(this.btnExcluirCad);
            this.pnlCRUD.Controls.Add(this.btnAlterarCad);
            this.pnlCRUD.Controls.Add(this.btnNovo);
            this.pnlCRUD.Controls.Add(this.btnCadastrar);
            this.pnlCRUD.Location = new System.Drawing.Point(6, 164);
            this.pnlCRUD.Name = "pnlCRUD";
            this.pnlCRUD.Size = new System.Drawing.Size(748, 72);
            this.pnlCRUD.TabIndex = 23;
            // 
            // btnVoltar
            // 
            this.btnVoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoltar.Image = ((System.Drawing.Image)(resources.GetObject("btnVoltar.Image")));
            this.btnVoltar.Location = new System.Drawing.Point(657, 16);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(88, 40);
            this.btnVoltar.TabIndex = 30;
            this.btnVoltar.Text = "&Voltar";
            this.btnVoltar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVoltar.UseVisualStyleBackColor = true;
            // 
            // btnLimparCad
            // 
            this.btnLimparCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimparCad.Image = ((System.Drawing.Image)(resources.GetObject("btnLimparCad.Image")));
            this.btnLimparCad.Location = new System.Drawing.Point(553, 16);
            this.btnLimparCad.Name = "btnLimparCad";
            this.btnLimparCad.Size = new System.Drawing.Size(98, 40);
            this.btnLimparCad.TabIndex = 29;
            this.btnLimparCad.Text = "&Limpar";
            this.btnLimparCad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimparCad.UseVisualStyleBackColor = true;
            // 
            // btnPesqisarCad
            // 
            this.btnPesqisarCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPesqisarCad.Image = ((System.Drawing.Image)(resources.GetObject("btnPesqisarCad.Image")));
            this.btnPesqisarCad.Location = new System.Drawing.Point(427, 16);
            this.btnPesqisarCad.Name = "btnPesqisarCad";
            this.btnPesqisarCad.Size = new System.Drawing.Size(120, 40);
            this.btnPesqisarCad.TabIndex = 28;
            this.btnPesqisarCad.Text = "&Pesquisar";
            this.btnPesqisarCad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnPesqisarCad.UseVisualStyleBackColor = true;
            // 
            // btnExcluirCad
            // 
            this.btnExcluirCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluirCad.Image = ((System.Drawing.Image)(resources.GetObject("btnExcluirCad.Image")));
            this.btnExcluirCad.Location = new System.Drawing.Point(322, 16);
            this.btnExcluirCad.Name = "btnExcluirCad";
            this.btnExcluirCad.Size = new System.Drawing.Size(99, 40);
            this.btnExcluirCad.TabIndex = 27;
            this.btnExcluirCad.Text = "E&xcluir";
            this.btnExcluirCad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnExcluirCad.UseVisualStyleBackColor = true;
            // 
            // btnAlterarCad
            // 
            this.btnAlterarCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAlterarCad.Image = ((System.Drawing.Image)(resources.GetObject("btnAlterarCad.Image")));
            this.btnAlterarCad.Location = new System.Drawing.Point(223, 16);
            this.btnAlterarCad.Name = "btnAlterarCad";
            this.btnAlterarCad.Size = new System.Drawing.Size(93, 40);
            this.btnAlterarCad.TabIndex = 26;
            this.btnAlterarCad.Text = "&Alterar";
            this.btnAlterarCad.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAlterarCad.UseVisualStyleBackColor = true;
            // 
            // btnNovo
            // 
            this.btnNovo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNovo.Image = ((System.Drawing.Image)(resources.GetObject("btnNovo.Image")));
            this.btnNovo.Location = new System.Drawing.Point(3, 16);
            this.btnNovo.Name = "btnNovo";
            this.btnNovo.Size = new System.Drawing.Size(90, 40);
            this.btnNovo.TabIndex = 24;
            this.btnNovo.Text = "&Novo";
            this.btnNovo.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNovo.UseVisualStyleBackColor = true;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Image = ((System.Drawing.Image)(resources.GetObject("btnCadastrar.Image")));
            this.btnCadastrar.Location = new System.Drawing.Point(99, 16);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(118, 40);
            this.btnCadastrar.TabIndex = 25;
            this.btnCadastrar.Text = "&Cadastrar";
            this.btnCadastrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCadastrar.UseVisualStyleBackColor = true;
            // 
            // txtbNumero
            // 
            this.txtbNumero.Location = new System.Drawing.Point(399, 75);
            this.txtbNumero.MaxLength = 10;
            this.txtbNumero.Name = "txtbNumero";
            this.txtbNumero.Size = new System.Drawing.Size(87, 26);
            this.txtbNumero.TabIndex = 19;
            // 
            // lblNumero
            // 
            this.lblNumero.AutoSize = true;
            this.lblNumero.Location = new System.Drawing.Point(328, 78);
            this.lblNumero.Name = "lblNumero";
            this.lblNumero.Size = new System.Drawing.Size(65, 20);
            this.lblNumero.TabIndex = 11;
            this.lblNumero.Text = "Numero";
            // 
            // cmbbEstado
            // 
            this.cmbbEstado.FormattingEnabled = true;
            this.cmbbEstado.ItemHeight = 20;
            this.cmbbEstado.Items.AddRange(new object[] {
            "AC",
            "",
            "AL",
            "",
            "AP",
            "",
            "AM",
            "",
            "BA",
            "",
            "CE",
            "",
            "DF",
            "",
            "ES",
            "",
            "GO",
            "",
            "MA",
            "",
            "MT",
            "",
            "MS",
            "",
            "MG",
            "PA",
            "",
            "PB",
            "",
            "PR",
            "",
            "PE",
            "",
            "PI",
            "",
            "RJ",
            "",
            "RN",
            "",
            "RS",
            "",
            "RO",
            "",
            "RR",
            "",
            "SC",
            "",
            "SP",
            "",
            "SE",
            "",
            "TO"});
            this.cmbbEstado.Location = new System.Drawing.Point(399, 117);
            this.cmbbEstado.MaxLength = 2;
            this.cmbbEstado.Name = "cmbbEstado";
            this.cmbbEstado.Size = new System.Drawing.Size(87, 28);
            this.cmbbEstado.TabIndex = 22;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(328, 122);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(60, 20);
            this.lblEstado.TabIndex = 9;
            this.lblEstado.Text = "Estado";
            // 
            // txtbCidade
            // 
            this.txtbCidade.Location = new System.Drawing.Point(78, 119);
            this.txtbCidade.MaxLength = 100;
            this.txtbCidade.Name = "txtbCidade";
            this.txtbCidade.Size = new System.Drawing.Size(244, 26);
            this.txtbCidade.TabIndex = 21;
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(13, 122);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(59, 20);
            this.lblCidade.TabIndex = 7;
            this.lblCidade.Text = "Cidade";
            // 
            // mskbCEP
            // 
            this.mskbCEP.Location = new System.Drawing.Point(60, 35);
            this.mskbCEP.Mask = "00000-000";
            this.mskbCEP.Name = "mskbCEP";
            this.mskbCEP.Size = new System.Drawing.Size(86, 26);
            this.mskbCEP.TabIndex = 16;
            // 
            // txtbBairro
            // 
            this.txtbBairro.Location = new System.Drawing.Point(70, 75);
            this.txtbBairro.MaxLength = 100;
            this.txtbBairro.Name = "txtbBairro";
            this.txtbBairro.Size = new System.Drawing.Size(252, 26);
            this.txtbBairro.TabIndex = 18;
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(13, 78);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(51, 20);
            this.lblBairro.TabIndex = 4;
            this.lblBairro.Text = "Bairro";
            // 
            // txtbLogradouro
            // 
            this.txtbLogradouro.Location = new System.Drawing.Point(256, 35);
            this.txtbLogradouro.MaxLength = 100;
            this.txtbLogradouro.Name = "txtbLogradouro";
            this.txtbLogradouro.Size = new System.Drawing.Size(495, 26);
            this.txtbLogradouro.TabIndex = 17;
            // 
            // lblLogradouro
            // 
            this.lblLogradouro.AutoSize = true;
            this.lblLogradouro.Location = new System.Drawing.Point(159, 38);
            this.lblLogradouro.Name = "lblLogradouro";
            this.lblLogradouro.Size = new System.Drawing.Size(91, 20);
            this.lblLogradouro.TabIndex = 2;
            this.lblLogradouro.Text = "Logradouro";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(13, 38);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(41, 20);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP";
            // 
            // frmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.gpbEndereco);
            this.Controls.Add(this.gpbDadosPessoais);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Padaria - Funcionários";
            this.gpbDadosPessoais.ResumeLayout(false);
            this.gpbDadosPessoais.PerformLayout();
            this.gpbFoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbFotoDoFuncionario)).EndInit();
            this.gpbSexo.ResumeLayout(false);
            this.gpbSexo.PerformLayout();
            this.gpbEndereco.ResumeLayout(false);
            this.gpbEndereco.PerformLayout();
            this.pnlCRUD.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gpbDadosPessoais;
        private System.Windows.Forms.TextBox txtbCodigo;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.TextBox txtbNome;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtbEmail;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mskbCPF;
        private System.Windows.Forms.Label lblNascimento;
        private System.Windows.Forms.DateTimePicker dttmNascimento;
        private System.Windows.Forms.MaskedTextBox mskbTelefone;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.GroupBox gpbSexo;
        private System.Windows.Forms.RadioButton rdbtnNaoDeclarar;
        private System.Windows.Forms.RadioButton rdbtnMasc;
        private System.Windows.Forms.RadioButton rdbtnFem;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnAprovar;
        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.PictureBox pcbFotoDoFuncionario;
        private System.Windows.Forms.GroupBox gpbEndereco;
        private System.Windows.Forms.TextBox txtbLogradouro;
        private System.Windows.Forms.Label lblLogradouro;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.MaskedTextBox mskbCEP;
        private System.Windows.Forms.TextBox txtbBairro;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.TextBox txtbCidade;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblNumero;
        private System.Windows.Forms.ComboBox cmbbEstado;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.TextBox txtbNumero;
        private System.Windows.Forms.Panel pnlCRUD;
        private System.Windows.Forms.Button btnLimparCad;
        private System.Windows.Forms.Button btnPesqisarCad;
        private System.Windows.Forms.Button btnExcluirCad;
        private System.Windows.Forms.Button btnAlterarCad;
        private System.Windows.Forms.Button btnNovo;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Button btnVoltar;
        private System.Windows.Forms.GroupBox gpbFoto;
        private System.Windows.Forms.TextBox txtbComplemento;
        private System.Windows.Forms.Label lblComplemento;
    }
}