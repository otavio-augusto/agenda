namespace trabalho_agenda
{
    partial class Form1
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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
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
            this.cadastrarPacienteToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cadastrarPacienteToolStripMenuItem.Text = "Cadastrar paciente";
            this.cadastrarPacienteToolStripMenuItem.Click += new System.EventHandler(this.cadastrarPacienteToolStripMenuItem_Click);
            // 
            // cadastrarMédicoToolStripMenuItem
            // 
            this.cadastrarMédicoToolStripMenuItem.Name = "cadastrarMédicoToolStripMenuItem";
            this.cadastrarMédicoToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cadastrarMédicoToolStripMenuItem.Text = "Cadastrar médico";
            this.cadastrarMédicoToolStripMenuItem.Click += new System.EventHandler(this.cadastrarMédicoToolStripMenuItem_Click);
            // 
            // cadastrarConsultaToolStripMenuItem
            // 
            this.cadastrarConsultaToolStripMenuItem.Name = "cadastrarConsultaToolStripMenuItem";
            this.cadastrarConsultaToolStripMenuItem.Size = new System.Drawing.Size(172, 22);
            this.cadastrarConsultaToolStripMenuItem.Text = "Cadastrar consulta";
            this.cadastrarConsultaToolStripMenuItem.Click += new System.EventHandler(this.cadastrarConsultaToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastrarConsultaToolStripMenuItem;
    }
}

