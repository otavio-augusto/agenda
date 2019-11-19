using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace trabalho_agenda
{
    public partial class TelaLogin : Form
    {
        public TelaLogin()
        {
            InitializeComponent();

        }

        private void cadastrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPaciente Form = new FormCadastroPaciente();
            Form.Show();
        }

        private void cadastrarMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void cadastrarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroConsulta Form = new FormCadastroConsulta();
            Form.Show();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            Usuario User = new Usuario();
            User.CPF = mskdCPF.Text;
            User.Senha = txtSenha.Text;

            EditorXML<Usuario> Ed = new EditorXML<Usuario>();
            List<Usuario> ListUsuarios = Ed.Deserializar("usuarios.xml");

            bool AchouCPF = false;
            bool AchouSenha = false;

            foreach (Usuario x in ListUsuarios)
            {
                if (User.CPF == x.CPF)
                {
                    if (User.Senha == x.Senha)
                    {
                        MenuPrincipal Form = new MenuPrincipal();
                        Form.Show();
                    }
                }
            }
       
        }

        private void linkPrim_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            CadastroUser PrimeiroAcesso = new CadastroUser();
            PrimeiroAcesso.Show();
        }
    }
}
