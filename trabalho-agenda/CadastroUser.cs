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
    public partial class CadastroUser : Form
    {
        public CadastroUser()
        {
            InitializeComponent();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            Usuario User = new Usuario();
            User.CPF = mskdCPF.Text;
            User.Nome = txtNome.Text;
            User.Email = txtMail.Text;
            User.Telefone = txtTelefone.Text;
            User.Senha = txtSenha.Text;

            bool AchouUser = false;

            EditorXML<Usuario> Ed = new EditorXML<Usuario>();
            List<Usuario> ListaUser = Ed.Deserializar("usuarios.xml", typeof(Usuario));

            foreach (Usuario x in ListaUser)
            {
                if(x.CPF == User.CPF)
                {
                    AchouUser = true;
                }
            }
            if(AchouUser == true)
            {
                MessageBox.Show("CPF Já cadastrado!");

            }
            else
            {
                List<Usuario> usuarios = new List<Usuario>();
                usuarios.Add(User);
                Ed.Serializar(usuarios, "usuarios.xml");
            }

        }
    }
}
