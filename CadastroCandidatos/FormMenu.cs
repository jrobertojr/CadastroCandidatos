using System;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace CadastroCandidatos
{
    public partial class FormMenu : Form
    {
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;

        [DllImport("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);

        [DllImport("user32.dll")]
        public static extern bool ReleaseCapture();

        public FormMenu(bool adm, string usuario)
        {
            InitializeComponent();
            dadosUsuario(adm, usuario);
            Suprimir_Bt();
        }

        public void dadosUsuario(bool adm, string usuario)
        {
            lbUsuarioLogado.Text = usuario;

            if (adm == false)
            {
                btUsuario.Hide();
            }
            else
            {
                btUsuario.Show();
            }
        }

        private void AbrirFormNoPainel<Forms>() where Forms : Form, new()
        {
            Form formulario;
            formulario = panelConteudo.Controls.OfType<Forms>().FirstOrDefault();

            if (formulario == null)
            {
                formulario = new Forms();
                formulario.TopLevel = false;
                formulario.Dock = DockStyle.Fill;
                panelConteudo.Controls.Add(formulario);
                panelConteudo.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
            }
            else
            {
                if (formulario.WindowState == FormWindowState.Minimized)
                    formulario.WindowState = FormWindowState.Normal;
                formulario.BringToFront();
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btMaximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            Suprimir_Bt();
        }

        private void btRestaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            Suprimir_Bt();
        }

        private void panelCabecalho_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void Suprimir_Bt()
        {
            btMaximizar.Visible = true;
            btRestaurar.Visible = true;

            if (this.WindowState == FormWindowState.Maximized)
                btMaximizar.Visible = false;
            else
                btRestaurar.Visible = false;
        }

        private void btParticipantes_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel<FormParticipantes>();
        }

        private void btUsuario_Click(object sender, EventArgs e)
        {
            AbrirFormNoPainel<FormUsuarios>();
        }
    }
}
