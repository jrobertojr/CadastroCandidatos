using Connection;
using System;
using System.Data;
using System.Windows.Forms;

namespace CadastroCandidatos.DataBase
{
    public class DbUsuario
    {
        private Conn Connection = new Conn();

        public DataTable Select()
        {
            return Connection.SqlDataTable(
                @"SELECT 
	                id_usuario AS ID,
	                usuario AS USUARIO,
	                senha AS SENHA,
	                nome AS NOME,
                    CASE adm
		                WHEN 0 THEN 'Não'
                        WHEN 1 THEN 'Sim'
	                END AS ADM,
	                CASE status
		                WHEN 0 THEN 'Inativo'
                        WHEN 1 THEN 'Ativo'
	                END AS STATUS,
	                data AS DATA
                FROM usuario");
        }

        public DataTable SelectPorUsuario(string usuario)
        {
            return Connection.SqlDataTable(
                @"SELECT 
                    id_usuario,
                    usuario,
                    senha,nome,
                    adm,
                    status,
                    data 
                FROM usuario 
                WHERE usuario = '" + usuario + "'");
        }

        public void Insert(string usuario, string senha, string nome, bool adm)
        {
            if (ExisteCadastro(usuario))
            {
                MessageBox.Show("Ja existe cadastro com essas informações");
            }
            else
            {
                Connection.SqlInsert("INSERT INTO usuario (usuario, senha, nome, adm, status, data) VALUES ('" + usuario + "', '" + senha + "', '" + nome + "', " + adm + ", 1, '" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss") + "')");
                MessageBox.Show("Usuario Cadastrado");
            }
            
        }

        public void Update(int id, string usuario, string senha, string nome, int adm, int status)
        {
            if (ExisteCadastro(id, usuario))
            {
                MessageBox.Show("Ja existe cadastro com essas informações");
            }
            else
            {
                Connection.SqlInsert("UPDATE usuario SET usuario = '" + usuario + "', senha = '" + senha + "', nome = '" + nome + "', adm = "+ adm +", status = "+ status +" WHERE id_usuario = " + id);
                MessageBox.Show("Usuario Atualizado");
            }
            
        }

        private bool ExisteCadastro(string usuario)
        {
            DataTable retorno = Connection.SqlDataTable(
                @"SELECT 
                    id_usuario,
                    usuario,senha,
                    nome,
                    data 
                FROM usuario 
                WHERE usuario = '" + usuario + "'");

            if (retorno.Rows.Count <= 0)
                return false;

            return true;
        }

        private bool ExisteCadastro(int id, string usuario)
        {
            DataTable retorno = Connection.SqlDataTable(
                @"SELECT 
                    id_usuario,
                    usuario,
                    senha,
                    nome,
                    data 
                FROM usuario 
                WHERE id_usuario != " + id + " AND usuario = '" + usuario + "'");

            if (retorno.Rows.Count <= 0)
                return false;

            return true;
        }
    }
}
