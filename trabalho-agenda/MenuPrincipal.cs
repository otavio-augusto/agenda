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
    public partial class MenuPrincipal : Form
    {
        public MenuPrincipal()
        {
            InitializeComponent();
        }

        private void cadastarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPaciente form = new FormCadastroPaciente();
            form.Show();
        }

        private void cadastarMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroMedico form = new FormCadastroMedico();
            form.Show();
        }

        private void cadastarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroConsulta form = new FormCadastroConsulta();
            form.Show();
        }
    }
}
