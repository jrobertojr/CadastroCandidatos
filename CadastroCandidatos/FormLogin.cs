using CadastroCandidatos.DataBase;
using CadastroCandidatos.Model;
using System;
using System.Windows.Forms;

namespace CadastroCandidatos
{
    public partial class FormLogin : Form
    {
        DbLogar Logar = new DbLogar();
        UsuarioModel Usuario = new UsuarioModel();

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btLogar_Click(object sender, EventArgs e)
        {
            Usuario = Logar.UsuarioExiste(txUsuario.Text, mtxSenha.Text);

            if (txUsuario.Text == "" && mtxSenha.Text == "")
            {
                MessageBox.Show("Preencha usuario e senha");
            }
            else if (Usuario == null)
            {
                MessageBox.Show("Usuario não existe");
            }
            else if(Usuario.Senha != mtxSenha.Text)
            {
                MessageBox.Show("Senha incorreta");
            }
            else if(Usuario.Status == false)
            {
                MessageBox.Show("Usuario inativo");
            }
            else
            {
                MessageBox.Show($@"Bem vindo {Usuario.Nome}");
                this.Hide();
                FormMenu FormMenu = new FormMenu(Usuario.Adm, Usuario.Usuario);
                FormMenu.Show();
            }
        }
    }
}
