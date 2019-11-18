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
            Medico Med = new Medico();
            Med.CPF = mskdCPF.Text;
            Med.Senha = txtSenha.Text;

            EditorXML<Medico> Ed = new EditorXML<Medico>();
            List<Medico> ListMedicos = Ed.Deserializar("medicos.xml");

            bool AchouCPF = false;
            bool AchouSenha = false;

            foreach (Medico x in ListMedicos)
            {
                if (Med.CPF == x.CPF)
                {
                    AchouCPF = true;
                    if (Med.Senha == x.Senha)
                    {
                        AchouSenha = true;                        
                    }
                }
            }
            if (AchouSenha == true && AchouCPF == true)
            {
                
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos!");
            }
       
        }
    }
}
