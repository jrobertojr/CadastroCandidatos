using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Connection
{
    class Conn
    {

        private MySqlConnection connection;
        private string server;
        private string database;
        private string uid;
        private string password;

        //Constructor
        public Conn()
        {
            Initialize();
        }

        //Initialize values
        public void Initialize()
        {
            string connectionString;

            server = "localhost";
            database = "lpf_sorteio";
            uid = "root";
            password = "123456789";
            connectionString = "SERVER=" + server + ";" + "DATABASE=" + database + ";" + "UID=" + uid + ";" + "PASSWORD=" + password + ";";

            connection = new MySqlConnection(connectionString);
        }

        //open connection to database
        public bool OpenConnection()
        {
            try
            {
                connection.Open();
                return true;
            }
            catch (MySqlException ex)
            {

                switch (ex.Number)
                {
                    case 0:
                        MessageBox.Show("Não foi possível se conectar ao banco de dados.  Contate o administrador");
                        break;

                    case 1045:
                        MessageBox.Show("Usuário e/ou senha inválido, por favor tente novamente");
                        break;
                }
                return false;
            }
        }

        //Close connection
        public bool CloseConnection()
        {
            try
            {
                connection.Close();
                return true;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
        }

        //Insert statement

        public void SqlInsert(String SQLq)
        {
            string query = SQLq;

            //open connection
            if (this.OpenConnection() == true)
            {
                //create command and assign the query and connection from the constructor
                MySqlCommand cmd = new MySqlCommand(query, connection);

                //Execute command
                cmd.ExecuteNonQuery();

                //close connection
                this.CloseConnection();
            }
        }

        public DataTable SqlDataTable(String SQLq)
        {
            string query = SQLq;
            DataTable dTable = new DataTable();

            try
            {
                MySqlDataAdapter adap = new MySqlDataAdapter(query, connection);
                adap.Fill(dTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Impossível estabelecer conexão");
                throw ex;
            }
            return dTable;
        }

    }
}
