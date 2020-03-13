using CadastroCandidatos.Log;
using CadastroCandidatos.Model;
using Connection;
using System;

namespace CadastroCandidatos.DataBase
{
    class DbLogar
    {
        private Conn Connection = new Conn();

        public UsuarioModel UsuarioExiste(string usuario, string senha )
        {
            try
            {
                var retorno = Connection.SqlDataTable(
                @"SELECT 
                    id_usuario,
                    usuario,
                    senha,
                    nome,
                    adm,
	                status,
                    data
                FROM usuario 
                WHERE usuario = '" + usuario + "'");

                if (retorno.Rows.Count <= 0)
                {
                    return null;
                }

                UsuarioModel Usuario = new UsuarioModel()
                {
                    Id = (int)retorno.Rows[0]["id_usuario"],
                    Usuario = retorno.Rows[0]["usuario"].ToString(),
                    Senha = retorno.Rows[0]["senha"].ToString(),
                    Nome = retorno.Rows[0]["nome"].ToString(),
                    Adm = (bool)retorno.Rows[0]["adm"],
                    Status = (bool)retorno.Rows[0]["status"],
                    Data = retorno.Rows[0]["data"].ToString(),
                };


                return Usuario;
            }
            catch (Exception ex)
            {
                RegistraLog.Log($"Erro ao verificação de usuario ao logar {ex}");
                throw;
            }

        }
    }
}
