using CadastroCandidatos.Log;
using Connection;
using System;
using System.Data;
using System.Windows.Forms;

namespace CadastroCandidatos.DataBase
{
    class DbParticipantes
    {
        private Conn Connection = new Conn();

        public DataTable Select()
        {
            try
            {
                return Connection.SqlDataTable(
                @"SELECT 
	                id_candidato AS ID,
                    nome AS NOME,
                    rg AS RG,
                    email AS EMAIL,
                    whatsapp AS WHATSAPP,
                    etapa AS ETAPA,
                    CASE status
		                WHEN 0 THEN 'Inativo'
		                WHEN 1 THEN 'Ativo'
	                END AS STATUS,
                    data AS DATA
                FROM candidatos");
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar SELECT do Usuario: {ex}");
                throw ex;
            }
        }

        public DataTable SelectPorId(string id)
        {
            try
            {
                return Connection.SqlDataTable(
                @"SELECT 
	                id_candidato AS ID,
                    nome AS NOME,
                    rg AS RG,
                    email AS EMAIL,
                    whatsapp AS WHATSAPP,
                    etapa AS ETAPA,
                    status AS STATUS,
                    data AS DATA
                FROM candidatos
                WHERE id_candidato = " + id);
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao retornar SELECT do usuario por Id {ex}");
                throw ex;
            }

        }

        public void Insert(string nome, string rg, string email, string whatsapp, int etapa)
        {
            try
            {
                if (ExisteCadastro(rg, email, whatsapp, etapa))
                {
                    MessageBox.Show("Ja existe cadastro com essas informações");
                }
                else
                {
                    Connection.SqlInsert("INSERT INTO candidatos (nome, rg, email, whatsapp, etapa, status, data) VALUES ('" + nome + "', '" + rg + "', '" + email + "', '" + whatsapp + "', " + etapa + ", 1, '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')");
                    MessageBox.Show("Participante Cadastrado");
                }

            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao INSERIR cadastro do usuario {ex}");
                throw ex;
            }
        }

        public void Update(int id, string nome, string rg, string email, string whatsapp, int etapa, int status)
        {
            try
            {
                if (ExisteCadastro(id, rg, email, whatsapp, etapa))
                {
                    MessageBox.Show("Ja existe cadastro com essas informações");
                }
                else
                {
                    Connection.SqlInsert("UPDATE candidatos SET nome = '" + nome + "', rg = '" + rg + "', email = '" + email + "', whatsapp = '" + whatsapp + "', etapa = " + etapa + ", status = " + status + " WHERE id_candidato = " + id);
                    MessageBox.Show("Usuario Atualizado");
                }
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao UPDATE cadastro do usuario {ex}");
                throw ex;
            }
        }

        private bool ExisteCadastro(string rg, string email, string whatsapp, int etapa)
        {
            try
            {
                DataTable retorno = Connection.SqlDataTable(
                    @"SELECT 
	                    id_candidato AS ID,
                        nome AS NOME,
                        rg AS RG,
                        email AS EMAIL,
                        whatsapp AS WHATSAPP,
                        etapa AS ETAPA,
                        status AS STATUS,
                        data AS DATA
                    FROM candidatos
                    WHERE rg = '" + rg +
                        "' AND etapa = " + etapa +
                        " AND email = '" + email +
                        "' OR whatsapp = '" + whatsapp + "'");

                if (retorno.Rows.Count <= 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao verificar se usuario existe para cadastro: {ex}");
                throw ex;
            }
        }

        private bool ExisteCadastro(int id, string rg, string email, string whatsapp, int etapa)
        {
            try
            {
                DataTable etapaIgual = Connection.SqlDataTable(
                    @"SELECT 
	                    id_candidato AS ID,
                        nome AS NOME,
                        rg AS RG,
                        email AS EMAIL,
                        whatsapp AS WHATSAPP,
                        etapa AS ETAPA,
                        status AS STATUS,
                        data AS DATA
                    FROM candidatos
                    WHERE id_candidato != " + id +
                        " AND rg = '" + rg +
                        "' AND etapa = " + etapa);

                DataTable retorno = Connection.SqlDataTable(
                    @"SELECT 
	                    id_candidato AS ID,
                        nome AS NOME,
                        rg AS RG,
                        email AS EMAIL,
                        whatsapp AS WHATSAPP,
                        etapa AS ETAPA,
                        status AS STATUS,
                        data AS DATA
                    FROM candidatos
                    WHERE id_candidato != " + id +
                        " AND email = '" + email +
                        "' OR whatsapp = '" + whatsapp + "'");

                if (etapaIgual.Rows.Count <= 0 || retorno.Rows.Count <= 0)
                    return false;

                return true;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao verificar se usuario existe para atualização: {ex}");
                throw ex;
            }
        }

    }
}
