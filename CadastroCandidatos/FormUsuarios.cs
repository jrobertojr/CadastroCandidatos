using CadastroCandidatos.DataBase;
using CadastroCandidatos.Log;
using System;
using System.Data;
using System.Windows.Forms;

namespace CadastroCandidatos
{
    public partial class FormUsuarios : Form
    {
        private DbUsuario Usuario = new DbUsuario();
        private DataTable Tabela = new DataTable();
        private int idUsuario;

        public FormUsuarios()
        {
            InitializeComponent();
            AtualizaDT();
            AtualizaComboBox();
        }

        private void AtualizaDT()
        {
            try
            {
                dtgUsuarios.DataSource = Usuario.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados");
                RegistraLog.Log($"Erro ao atualizar dados: {ex}");
                throw ex;
            }        
        }

        private void AtualizaComboBox()
        {
            try
            {
                cbEditStatus.Items.Add("Ativo");
                cbEditStatus.Items.Add("Inativo");

                cbEditAdm.Items.Add("Sim");
                cbEditAdm.Items.Add("Não");

                cbAdm.Items.Add("Sim");
                cbAdm.Items.Add("Não");

                Tabela = Usuario.Select();
                if (Tabela.Rows.Count > 0)
                {
                    cboxUsuarios.DataSource = Tabela;
                    cboxUsuarios.DisplayMember = "usuario";
                    cboxUsuarios.ValueMember = "usuario";
                    cboxUsuarios.Enabled = true;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados");
                RegistraLog.Log($"Erro ao atualizar dados: {ex}");
                throw ex;
            }
        }

        private void dtgUsuarios_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linha = int.Parse(e.RowIndex.ToString());
            cboxUsuarios.SelectedValue = dtgUsuarios.Rows[linha].Cells[1].Value.ToString();
        }

        private void btCadastrarUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                if (tboxUsuario.Text == "")
                {
                    MessageBox.Show("Usuario deve ser preenchido");
                }
                else if (tboxSenha.Text.Length < 6)
                {
                    MessageBox.Show("Senha deve ter no minimo 6 caracteres");
                }
                else if (tboxSenha.Text == "")
                {
                    MessageBox.Show("Senha deve ser preenchida");
                }
                else if (tboxNome.Text == "")
                {
                    MessageBox.Show("Nome deve ser preenchido");
                }
                else if (cbAdm.SelectedItem == null)
                {
                    MessageBox.Show("Indique se o usuario será Administrador");
                }
                else
                {
                    bool adm = cbAdm.SelectedItem.ToString() == "Sim" ? true : false;

                    Usuario.Insert(tboxUsuario.Text, tboxSenha.Text, tboxNome.Text, adm);
                    tboxUsuario.Clear();
                    tboxSenha.Clear();
                    tboxNome.Clear();
                    AtualizaDT();
                    AtualizaComboBox();
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao inserir usuario");
                RegistraLog.Log($"Erro ao inserir usuario: {ex}");
                throw ex;
            }
        }

        private void cboxUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)cboxUsuarios.SelectedItem;
                var valor = drv["usuario"].ToString();

                if (valor != "")
                {
                    Tabela = Usuario.SelectPorUsuario(valor);

                    idUsuario = int.Parse(Tabela.Rows[0]["id_usuario"].ToString());
                    tboxEditUsuario.Text = Tabela.Rows[0]["usuario"].ToString();
                    tboxEditSenha.Text = Tabela.Rows[0]["senha"].ToString();
                    tboxEditNome.Text = Tabela.Rows[0]["nome"].ToString();
                    cbEditAdm.SelectedItem = (bool)Tabela.Rows[0]["adm"] == true ? "Sim" : "Não";
                    cbEditStatus.SelectedItem = (bool)Tabela.Rows[0]["status"] == true ? "Ativo" : "Inativo";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao selecionar usuario");
                RegistraLog.Log($"Erro ao selecionar usuario: {ex}");
                throw;
            }
            
        }

        private void btAtualizarUser_Click(object sender, EventArgs e)
        {
            try
            {
                int adm = cbEditAdm.SelectedItem.ToString() == "Sim" ? 1 : 0;
                int status = cbEditStatus.SelectedItem.ToString() == "Ativo" ? 1 : 0;

                Usuario.Update(idUsuario, tboxEditUsuario.Text, tboxEditSenha.Text, tboxEditNome.Text, adm, status);
                AtualizaDT();
                AtualizaComboBox();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados");
                RegistraLog.Log($"Erro ao atualizar dados: {ex}");
                throw ex;
            }
        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
