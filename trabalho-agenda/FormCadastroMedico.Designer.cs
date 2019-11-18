namespace trabalho_agenda
{
    partial class FormCadastroMedico
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dateTimeNascimento = new System.Windows.Forms.DateTimePicker();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonCadastrar = new System.Windows.Forms.Button();
            this.maskedTextCPF = new System.Windows.Forms.MaskedTextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.textEspecialidade = new System.Windows.Forms.TextBox();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textTelefone = new System.Windows.Forms.TextBox();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTipoSang = new System.Windows.Forms.Label();
            this.lblMail = new System.Windows.Forms.Label();
            this.lblTelefone = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtComp = new System.Windows.Forms.TextBox();
            this.lblComp = new System.Windows.Forms.Label();
            this.txtEstado = new System.Windows.Forms.TextBox();
            this.txtCidade = new System.Windows.Forms.TextBox();
            this.txtBairro = new System.Windows.Forms.TextBox();
            this.txtRua = new System.Windows.Forms.TextBox();
            this.mskdCep = new System.Windows.Forms.MaskedTextBox();
            this.btnConsultar = new System.Windows.Forms.Button();
            this.lblUF = new System.Windows.Forms.Label();
            this.lblCidade = new System.Windows.Forms.Label();
            this.lblBairro = new System.Windows.Forms.Label();
            this.lblRua = new System.Windows.Forms.Label();
            this.lblCEP = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimeNascimento);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.buttonCadastrar);
            this.groupBox1.Controls.Add(this.maskedTextCPF);
            this.groupBox1.Controls.Add(this.lblCPF);
            this.groupBox1.Controls.Add(this.textEspecialidade);
            this.groupBox1.Controls.Add(this.textBoxEmail);
            this.groupBox1.Controls.Add(this.textTelefone);
            this.groupBox1.Controls.Add(this.textNome);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblTipoSang);
            this.groupBox1.Controls.Add(this.lblMail);
            this.groupBox1.Controls.Add(this.lblTelefone);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtComp);
            this.groupBox1.Controls.Add(this.lblComp);
            this.groupBox1.Controls.Add(this.txtEstado);
            this.groupBox1.Controls.Add(this.txtCidade);
            this.groupBox1.Controls.Add(this.txtBairro);
            this.groupBox1.Controls.Add(this.txtRua);
            this.groupBox1.Controls.Add(this.mskdCep);
            this.groupBox1.Controls.Add(this.btnConsultar);
            this.groupBox1.Controls.Add(this.lblUF);
            this.groupBox1.Controls.Add(this.lblCidade);
            this.groupBox1.Controls.Add(this.lblBairro);
            this.groupBox1.Controls.Add(this.lblRua);
            this.groupBox1.Controls.Add(this.lblCEP);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(391, 432);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            // 
            // dateTimeNascimento
            // 
            this.dateTimeNascimento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimeNascimento.Location = new System.Drawing.Point(9, 170);
            this.dateTimeNascimento.Name = "dateTimeNascimento";
            this.dateTimeNascimento.Size = new System.Drawing.Size(126, 22);
            this.dateTimeNascimento.TabIndex = 27;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(87, 385);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 26;
            this.button2.Text = "Alterar";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // buttonCadastrar
            // 
            this.buttonCadastrar.Location = new System.Drawing.Point(6, 385);
            this.buttonCadastrar.Name = "buttonCadastrar";
            this.buttonCadastrar.Size = new System.Drawing.Size(75, 23);
            this.buttonCadastrar.TabIndex = 25;
            this.buttonCadastrar.Text = "Cadastrar";
            this.buttonCadastrar.UseVisualStyleBackColor = true;
            this.buttonCadastrar.Click += new System.EventHandler(this.buttonCadastrar_Click);
            // 
            // maskedTextCPF
            // 
            this.maskedTextCPF.Location = new System.Drawing.Point(263, 170);
            this.maskedTextCPF.Mask = "000,000,000-00";
            this.maskedTextCPF.Name = "maskedTextCPF";
            this.maskedTextCPF.Size = new System.Drawing.Size(110, 22);
            this.maskedTextCPF.TabIndex = 24;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(260, 150);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(37, 16);
            this.lblCPF.TabIndex = 23;
            this.lblCPF.Text = "CPF:";
            // 
            // textEspecialidade
            // 
            this.textEspecialidade.Location = new System.Drawing.Point(152, 169);
            this.textEspecialidade.Name = "textEspecialidade";
            this.textEspecialidade.Size = new System.Drawing.Size(93, 22);
            this.textEspecialidade.TabIndex = 21;
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(9, 125);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(364, 22);
            this.textBoxEmail.TabIndex = 20;
            // 
            // textTelefone
            // 
            this.textTelefone.Location = new System.Drawing.Point(9, 81);
            this.textTelefone.Name = "textTelefone";
            this.textTelefone.Size = new System.Drawing.Size(364, 22);
            this.textTelefone.TabIndex = 19;
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(9, 37);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(364, 22);
            this.textNome.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(4, 150);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 16);
            this.label1.TabIndex = 17;
            this.label1.Text = "Data de nascimento:";
            // 
            // lblTipoSang
            // 
            this.lblTipoSang.AutoSize = true;
            this.lblTipoSang.Location = new System.Drawing.Point(149, 150);
            this.lblTipoSang.Name = "lblTipoSang";
            this.lblTipoSang.Size = new System.Drawing.Size(99, 16);
            this.lblTipoSang.TabIndex = 16;
            this.lblTipoSang.Text = "Especialidade:";
            // 
            // lblMail
            // 
            this.lblMail.AutoSize = true;
            this.lblMail.Location = new System.Drawing.Point(6, 106);
            this.lblMail.Name = "lblMail";
            this.lblMail.Size = new System.Drawing.Size(49, 16);
            this.lblMail.TabIndex = 15;
            this.lblMail.Text = "E-Mail:";
            // 
            // lblTelefone
            // 
            this.lblTelefone.AutoSize = true;
            this.lblTelefone.Location = new System.Drawing.Point(6, 62);
            this.lblTelefone.Name = "lblTelefone";
            this.lblTelefone.Size = new System.Drawing.Size(65, 16);
            this.lblTelefone.TabIndex = 14;
            this.lblTelefone.Text = "Telefone:";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(6, 18);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(48, 16);
            this.lblNome.TabIndex = 13;
            this.lblNome.Text = "Nome:";
            // 
            // txtComp
            // 
            this.txtComp.Location = new System.Drawing.Point(6, 357);
            this.txtComp.Name = "txtComp";
            this.txtComp.Size = new System.Drawing.Size(171, 22);
            this.txtComp.TabIndex = 12;
            // 
            // lblComp
            // 
            this.lblComp.AutoSize = true;
            this.lblComp.Location = new System.Drawing.Point(6, 338);
            this.lblComp.Name = "lblComp";
            this.lblComp.Size = new System.Drawing.Size(95, 16);
            this.lblComp.TabIndex = 11;
            this.lblComp.Text = "Complemento:";
            // 
            // txtEstado
            // 
            this.txtEstado.Location = new System.Drawing.Point(193, 357);
            this.txtEstado.Name = "txtEstado";
            this.txtEstado.Size = new System.Drawing.Size(180, 22);
            this.txtEstado.TabIndex = 10;
            // 
            // txtCidade
            // 
            this.txtCidade.Location = new System.Drawing.Point(193, 313);
            this.txtCidade.Name = "txtCidade";
            this.txtCidade.Size = new System.Drawing.Size(180, 22);
            this.txtCidade.TabIndex = 9;
            // 
            // txtBairro
            // 
            this.txtBairro.Location = new System.Drawing.Point(6, 313);
            this.txtBairro.Name = "txtBairro";
            this.txtBairro.Size = new System.Drawing.Size(171, 22);
            this.txtBairro.TabIndex = 8;
            // 
            // txtRua
            // 
            this.txtRua.Location = new System.Drawing.Point(6, 268);
            this.txtRua.Name = "txtRua";
            this.txtRua.Size = new System.Drawing.Size(367, 22);
            this.txtRua.TabIndex = 7;
            // 
            // mskdCep
            // 
            this.mskdCep.Location = new System.Drawing.Point(6, 224);
            this.mskdCep.Mask = "00000-000";
            this.mskdCep.Name = "mskdCep";
            this.mskdCep.Size = new System.Drawing.Size(129, 22);
            this.mskdCep.TabIndex = 6;
            // 
            // btnConsultar
            // 
            this.btnConsultar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnConsultar.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnConsultar.Location = new System.Drawing.Point(152, 223);
            this.btnConsultar.Name = "btnConsultar";
            this.btnConsultar.Size = new System.Drawing.Size(221, 23);
            this.btnConsultar.TabIndex = 5;
            this.btnConsultar.Text = "Consultar";
            this.btnConsultar.UseVisualStyleBackColor = true;
            this.btnConsultar.Click += new System.EventHandler(this.btnConsultar_Click);
            // 
            // lblUF
            // 
            this.lblUF.AutoSize = true;
            this.lblUF.Location = new System.Drawing.Point(191, 338);
            this.lblUF.Name = "lblUF";
            this.lblUF.Size = new System.Drawing.Size(54, 16);
            this.lblUF.TabIndex = 4;
            this.lblUF.Text = "Estado:";
            // 
            // lblCidade
            // 
            this.lblCidade.AutoSize = true;
            this.lblCidade.Location = new System.Drawing.Point(190, 293);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(55, 16);
            this.lblCidade.TabIndex = 3;
            this.lblCidade.Text = "Cidade:";
            // 
            // lblBairro
            // 
            this.lblBairro.AutoSize = true;
            this.lblBairro.Location = new System.Drawing.Point(3, 293);
            this.lblBairro.Name = "lblBairro";
            this.lblBairro.Size = new System.Drawing.Size(47, 16);
            this.lblBairro.TabIndex = 2;
            this.lblBairro.Text = "Bairro:";
            // 
            // lblRua
            // 
            this.lblRua.AutoSize = true;
            this.lblRua.Location = new System.Drawing.Point(6, 249);
            this.lblRua.Name = "lblRua";
            this.lblRua.Size = new System.Drawing.Size(36, 16);
            this.lblRua.TabIndex = 1;
            this.lblRua.Text = "Rua:";
            // 
            // lblCEP
            // 
            this.lblCEP.AutoSize = true;
            this.lblCEP.Location = new System.Drawing.Point(3, 204);
            this.lblCEP.Name = "lblCEP";
            this.lblCEP.Size = new System.Drawing.Size(38, 16);
            this.lblCEP.TabIndex = 0;
            this.lblCEP.Text = "CEP:";
            // 
            // FormCadastroMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 456);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(431, 494);
            this.Name = "FormCadastroMedico";
            this.Text = "Cadastro Medico";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox maskedTextCPF;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.TextBox textEspecialidade;
        private System.Windows.Forms.TextBox textBoxEmail;
        private System.Windows.Forms.TextBox textTelefone;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTipoSang;
        private System.Windows.Forms.Label lblMail;
        private System.Windows.Forms.Label lblTelefone;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtComp;
        private System.Windows.Forms.Label lblComp;
        private System.Windows.Forms.TextBox txtEstado;
        private System.Windows.Forms.TextBox txtCidade;
        private System.Windows.Forms.TextBox txtBairro;
        private System.Windows.Forms.TextBox txtRua;
        private System.Windows.Forms.MaskedTextBox mskdCep;
        private System.Windows.Forms.Button btnConsultar;
        private System.Windows.Forms.Label lblUF;
        private System.Windows.Forms.Label lblCidade;
        private System.Windows.Forms.Label lblBairro;
        private System.Windows.Forms.Label lblRua;
        private System.Windows.Forms.Label lblCEP;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonCadastrar;
        private System.Windows.Forms.DateTimePicker dateTimeNascimento;
    }
}