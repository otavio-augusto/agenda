namespace trabalho_agenda
{
    partial class TelaLogin
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastrarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.mskdCPF = new System.Windows.Forms.MaskedTextBox();
            this.linkPrim = new System.Windows.Forms.LinkLabel();
            this.btnLogin = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(325, 24);
            this.menuStrip1.TabIndex = 3;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastrarPacienteToolStripMenuItem,
            this.cadastrarMédicoToolStripMenuItem,
            this.cadastrarConsultaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastrarPacienteToolStripMenuItem
            // 
            this.cadastrarPacienteToolStripMenuItem.Name = "cadastrarPacienteToolStripMenuItem";
            this.cadastrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarPacienteToolStripMenuItem.Text = "Cadastrar paciente";
            this.cadastrarPacienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPacienteToolStripMenuItem_Click);
            // 
            // cadastrarMédicoToolStripMenuItem
            // 
            this.cadastrarMédicoToolStripMenuItem.Name = "cadastrarMédicoToolStripMenuItem";
            this.cadastrarMédicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarMédicoToolStripMenuItem.Text = "Cadastrar médico";
            this.cadastrarMédicoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMédicoToolStripMenuItem_Click);
            // 
            // cadastrarConsultaToolStripMenuItem
            // 
            this.cadastrarConsultaToolStripMenuItem.Name = "cadastrarConsultaToolStripMenuItem";
            this.cadastrarConsultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastrarConsultaToolStripMenuItem.Text = "Cadastrar consulta";
            this.cadastrarConsultaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarConsultaToolStripMenuItem_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(45, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bem-vindo ao sistema";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 16);
            this.label2.TabIndex = 5;
            this.label2.Text = "CPF do Usuário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Senha:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtSenha);
            this.groupBox1.Controls.Add(this.mskdCPF);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.linkPrim);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(27, 69);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(270, 182);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(20, 114);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.Size = new System.Drawing.Size(123, 22);
            this.txtSenha.TabIndex = 10;
            this.txtSenha.UseSystemPasswordChar = true;
            // 
            // mskdCPF
            // 
            this.mskdCPF.Location = new System.Drawing.Point(20, 65);
            this.mskdCPF.Mask = "000,000,000-00";
            this.mskdCPF.Name = "mskdCPF";
            this.mskdCPF.Size = new System.Drawing.Size(123, 22);
            this.mskdCPF.TabIndex = 9;
            // 
            // linkPrim
            // 
            this.linkPrim.AutoSize = true;
            this.linkPrim.Location = new System.Drawing.Point(20, 150);
            this.linkPrim.Name = "linkPrim";
            this.linkPrim.Size = new System.Drawing.Size(106, 16);
            this.linkPrim.TabIndex = 7;
            this.linkPrim.TabStop = true;
            this.linkPrim.Text = "Primeiro acesso";
            this.linkPrim.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkPrim_LinkClicked);
            // 
            // btnLogin
            // 
            this.btnLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogin.Location = new System.Drawing.Point(222, 257);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 27);
            this.btnLogin.TabIndex = 8;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // TelaLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(325, 312);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.label1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TelaLogin";
            this.Text = "Login";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarConsultaToolStripMenuItem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.MaskedTextBox mskdCPF;
        private System.Windows.Forms.LinkLabel linkPrim;
        private System.Windows.Forms.Button btnLogin;
    }
}

