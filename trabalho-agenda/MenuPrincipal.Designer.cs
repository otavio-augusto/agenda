﻿namespace trabalho_agenda
{
    partial class MenuPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastarPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastarMédicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cadastarConsultaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // menuToolStripMenuItem
            // 
            this.menuToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cadastarPacienteToolStripMenuItem,
            this.cadastarMédicoToolStripMenuItem,
            this.cadastarConsultaToolStripMenuItem});
            this.menuToolStripMenuItem.Name = "menuToolStripMenuItem";
            this.menuToolStripMenuItem.Size = new System.Drawing.Size(50, 20);
            this.menuToolStripMenuItem.Text = "Menu";
            // 
            // cadastarPacienteToolStripMenuItem
            // 
            this.cadastarPacienteToolStripMenuItem.Name = "cadastarPacienteToolStripMenuItem";
            this.cadastarPacienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastarPacienteToolStripMenuItem.Text = "Cadastar Paciente";
            this.cadastarPacienteToolStripMenuItem.Click += new System.EventHandler(this.cadastarPacienteToolStripMenuItem_Click);
            // 
            // cadastarMédicoToolStripMenuItem
            // 
            this.cadastarMédicoToolStripMenuItem.Name = "cadastarMédicoToolStripMenuItem";
            this.cadastarMédicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastarMédicoToolStripMenuItem.Text = "Cadastar Médico";
            this.cadastarMédicoToolStripMenuItem.Click += new System.EventHandler(this.cadastarMédicoToolStripMenuItem_Click);
            // 
            // cadastarConsultaToolStripMenuItem
            // 
            this.cadastarConsultaToolStripMenuItem.Name = "cadastarConsultaToolStripMenuItem";
            this.cadastarConsultaToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.cadastarConsultaToolStripMenuItem.Text = "Cadastar Consulta";
            this.cadastarConsultaToolStripMenuItem.Click += new System.EventHandler(this.cadastarConsultaToolStripMenuItem_Click);
            // 
            // MenuPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MenuPrincipal";
            this.Text = "MenuPrincipal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem menuToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastarPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastarMédicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cadastarConsultaToolStripMenuItem;
    }
}