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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            EditorXML<Paciente> editorXML = new EditorXML<Paciente>();
            List<Paciente> lista = new List<Paciente>();
            Paciente paciente = new Paciente();
            paciente.Nome = textBox1.Text;
            paciente.CPF = textBox2.Text;
            lista.Add(paciente);
            editorXML.Serializar(lista, "pacientes.xml");
        }

        private void cadastrarPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroPaciente Form = new FormCadastroPaciente();
            Form.Show();
        }

        private void cadastrarMédicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroMedico Form = new FormCadastroMedico();
            Form.Show();
        }

        private void cadastrarConsultaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormCadastroConsulta Form = new FormCadastroConsulta();
            Form.Show();
        }
    }
}
