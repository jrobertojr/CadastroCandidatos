using CadastroCandidatos.DataBase;
using CadastroCandidatos.Log;
using ClosedXML.Excel;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;

namespace CadastroCandidatos
{
    public partial class FormParticipantes : Form
    {
        private DbParticipantes Participante = new DbParticipantes();
        private DataTable Tabela = new DataTable();
        private int idUsuario;


        public FormParticipantes()
        {
            InitializeComponent();
            AtualizaDT();
            AtualizaCBCadastro();
            AtualizaCDEditarParticipante();
        }

        private void AtualizaDT()
        {
            try
            {
                dtgParticipantes.DataSource = Participante.Select();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados");
                RegistraLog.Log($"Erro ao atualizar dados: {ex}");
                throw ex;
            }
        }

        private void AtualizaCBCadastro()
        {
            try
            {

                cbEtapa.Items.Clear();
                cbEditEtapa.Items.Clear();

                cbEtapa.Items.Add("1");
                cbEtapa.Items.Add("2");
                cbEtapa.Items.Add("3");
                cbEtapa.Items.Add("4");
                cbEtapa.Items.Add("5");
                cbEtapa.Items.Add("6");
                cbEtapa.Items.Add("7");
                cbEtapa.Items.Add("8");
                cbEtapa.Items.Add("9");
                cbEtapa.Items.Add("10");

                cbEditEtapa.Items.Add("1");
                cbEditEtapa.Items.Add("2");
                cbEditEtapa.Items.Add("3");
                cbEditEtapa.Items.Add("4");
                cbEditEtapa.Items.Add("5");
                cbEditEtapa.Items.Add("6");
                cbEditEtapa.Items.Add("7");
                cbEditEtapa.Items.Add("8");
                cbEditEtapa.Items.Add("9");
                cbEditEtapa.Items.Add("10");

                cbEditStatus.Items.Add("Ativo");
                cbEditStatus.Items.Add("Inativo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados");
                RegistraLog.Log($"Erro ao atualizar dados Combobox de Cadastro: {ex}");
                throw ex;
            }
        }

        private void AtualizaCDEditarParticipante()
        {
            try
            {
                Tabela = Participante.Select();
                if (Tabela.Rows.Count > 0)
                {
                    cbSelecionarParticipante.DataSource = Tabela;
                    cbSelecionarParticipante.DisplayMember = "ID";
                    cbSelecionarParticipante.ValueMember = "ID";
                    cbSelecionarParticipante.Enabled = true;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados");
                RegistraLog.Log($"Erro ao atualizar dados Combobox de Atualização: {ex}");
                throw ex;
            }
        }

        private void dtgParticipantes_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int linha = int.Parse(e.RowIndex.ToString());
            cbSelecionarParticipante.SelectedValue = (int)dtgParticipantes.Rows[linha].Cells[0].Value;
        }

        private void cbSelecionarParticipante_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataRowView drv = (DataRowView)cbSelecionarParticipante.SelectedItem;
                var valor = drv["ID"].ToString();

                if (valor != "")
                {
                    Tabela = Participante.SelectPorId(valor);

                    idUsuario = int.Parse(Tabela.Rows[0]["ID"].ToString());
                    tboxEditNome.Text = Tabela.Rows[0]["NOME"].ToString();
                    mtbEditRg.Text = Tabela.Rows[0]["RG"].ToString();
                    tboxEditEmail.Text = Tabela.Rows[0]["EMAIL"].ToString();
                    mtbEdirWhatsapp.Text = Tabela.Rows[0]["WHATSAPP"].ToString();
                    cbEditEtapa.SelectedItem = Tabela.Rows[0]["ETAPA"].ToString();
                    cbEditStatus.SelectedItem = Tabela.Rows[0]["STATUS"].ToString() == "True" ? "Ativo" : "Inativo";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Erro ao selecionar Participante");
                RegistraLog.Log($"Erro do ComboBox ao selecionar Participante: {ex}");
                throw ex;
            }
        }

        private void btCadastrarParticipante_Click(object sender, EventArgs e)
        {
            try
            {
                string rg = mtbRg.Text.Trim(new Char[] { ' ', '-', '.' });

                if (tboxNome.Text == "")
                {
                    MessageBox.Show("Nome deve ser preenchido");
                }
                else if (rg == "" || rg.Length < 12)
                {
                    MessageBox.Show("RG deve ser preenchido corretamente");
                }
                else if (cbEtapa.SelectedItem == null)
                {
                    MessageBox.Show("Selecione a etapa");
                }
                else
                {
                    Participante.Insert(tboxNome.Text, mtbRg.Text, tboxEmail.Text, mtbWhatsapp.Text, int.Parse(cbEtapa.SelectedItem.ToString()));
                    tboxNome.Clear();
                    mtbRg.Clear();
                    tboxEmail.Clear();
                    mtbWhatsapp.Clear();
                    AtualizaDT();
                    AtualizaCBCadastro();
                    AtualizaCDEditarParticipante();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao cadastrar participante");
                RegistraLog.Log($"Erro ao cadastrar participante: {ex}");
                throw ex;
            }
        }

        private void btAtualizarParticipante_Click(object sender, EventArgs e)
        {
            try
            {
                string rg = mtbEditRg.Text.Trim(new Char[] { ' ', '-', '.' });

                if (tboxEditNome.Text == "")
                {
                    MessageBox.Show("Nome deve ser preenchido");
                }
                else if (rg == "" || rg.Length < 12)
                {
                    MessageBox.Show("RG deve ser preenchido corretamente");
                }
                else if (cbEditEtapa.SelectedItem == null)
                {
                    MessageBox.Show("Selecione a etapa");
                }
                else
                {
                    int status = cbEditStatus.SelectedItem.ToString() == "Ativo" ? 1 : 0;

                    Participante.Update(idUsuario, tboxEditNome.Text, mtbEditRg.Text, tboxEditEmail.Text, mtbEdirWhatsapp.Text, int.Parse(cbEditEtapa.SelectedItem.ToString()), status);
                    AtualizaDT();
                    AtualizaCBCadastro();
                    AtualizaCDEditarParticipante();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao atualizar dados");
                RegistraLog.Log($"Erro ao atualizar dados: {ex}");
                throw ex;
            }
        }

        private void btExportarExel_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable datatable = Participante.Select();

                string folderPath = "C:\\Excel\\";

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }
                using (XLWorkbook wb = new XLWorkbook())
                {
                    wb.Worksheets.Add(datatable, "Customers");
                    wb.SaveAs(folderPath + $"Participantes{DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")}.xlsx");
                }

                MessageBox.Show($"Arquivo Participantes{DateTime.Now.ToString("dd-MM-yyyy HH-mm-ss")}.xlsx exportado para {folderPath}");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao exportar para Excel");
                RegistraLog.Log($"Erro ao gerar arquivo .xlsx: {ex}");
                throw;
            }

        }

        private void btFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
