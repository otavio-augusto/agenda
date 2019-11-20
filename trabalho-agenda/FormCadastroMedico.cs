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
    public partial class FormCadastroMedico : Form
    {
        public FormCadastroMedico()
        {
            InitializeComponent();
        }

        private void buttonCadastrar_Click(object sender, EventArgs e)
        {
            Medico medico = new Medico();
            medico.Nome = textNome.Text;
            medico.CPF = maskedTextCPF.Text;
            medico.DataNasc = dateTimeNascimento.Value;
            medico.Email = textEmail.Text;
            medico.Especialidade = textEspecialidade.Text;
            medico.Telefone = textTelefone.Text;
            Endereco endereco = new Endereco();
            endereco.Bairro = txtBairro.Text;
            endereco.CEP = mskdCep.Text;
            endereco.Cidade = txtCidade.Text;
            endereco.Complemento = txtComp.Text;
            endereco.Estado = txtEstado.Text;
            endereco.Rua = txtRua.Text;
            medico.Endereço = endereco;
            new EditorXML<Medico>().Serializar(medico, "medicos.xml");
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                using (var WS = new WebServiceCEP.AtendeClienteClient())
                {

                    var resultado = WS.consultaCEP(mskdCep.Text);
                    txtBairro.Text = resultado.bairro;
                    txtCidade.Text = resultado.cidade;
                    txtRua.Text = resultado.end;
                    txtEstado.Text = resultado.uf;
                    txtComp.Text = resultado.complemento2;
                }
            }
            catch
            {
                MessageBox.Show("CEP digitado inválido");
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            Medico Med = new Medico();
            Endereco End = new Endereco();
            Med.CPF = maskedTextCPF.Text;



            EditorXML<Medico> Ed = new EditorXML<Medico>();
            List<Medico> ListaPacientes = (List<Medico>)Ed.Deserializar("medicos.xml");

            string Mensagem = "Os dados do usuário de CPF especificado serão alderados";
            string Janela = "Atenção";
            MessageBoxButtons Buttons = MessageBoxButtons.OKCancel;
            DialogResult resultado = MessageBox.Show(Janela, Mensagem, Buttons);
            if (resultado == DialogResult.OK)
            {
                this.Close();
                foreach (Medico x in ListaPacientes)
                {
                    if (Med.CPF == x.CPF)
                    {
                        Med.Nome = textNome.Text;
                        Med.Email = textEmail.Text;
                        Med.CPF = maskedTextCPF.Text;
                        Med.Telefone = textTelefone.Text;
                        Med.DataNasc = dateTimeNascimento.Value;
                        Med.Especialidade = textEspecialidade.Text;

                        End.Rua = txtRua.Text;
                        End.Bairro = txtBairro.Text;
                        End.Cidade = txtCidade.Text;
                        End.Complemento = txtComp.Text;
                        End.Estado = txtEstado.Text;
                        End.CEP = mskdCep.Text;
                        Med.Endereço = End;

                        Ed.Serializar(Med, "medicos.xml");

                        MessageBox.Show("Dados alterados com sucesso", "Mensagem", MessageBoxButtons.OK);
                    }
                    else
                    {
                        MessageBox.Show("CPF não encontrado", "Mensagem", MessageBoxButtons.OK);
                    }
                }

            }
        }
    }
}
