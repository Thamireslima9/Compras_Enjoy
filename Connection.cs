using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras_Enjoy
{
    internal class Connection
    {
        private SqlConnection con; // faz gestão da conexão entre o banco e o desing
        private string DataBase = "PR2CJ3022099LOJAENJOY";
        private string Server= "Sqlexpress";
        private string Username = "aluno"; //Conectado ao servidor, pelo if
        private string Password = "aluno";

        public Connection() {
            string stringConnection = @"Data Source = " + Server
                + "; Initial Catalog = " + DataBase
                + "; User Id = " + Username
                + "; Password = " + Password
                + "; Encrypt = false";

            //String stringConnection = @"Data Source" + Environment.MachineName + @"\SQLEXPRESS;
            //Initial Catalog = " + DataBase +"; Integrated Security = true"

            con = new SqlConnection(stringConnection);
            con.Open(); //abrir a conexão com o banco de dados
         }
        // tenta fechar a conexão com o banco

        public void CloseConnection()
        {
            if(con.State == ConnectionState.Open) 
                con.Close();
        }

        //retorna a conexão que foi aberta

        public SqlConnection ReturnConnection () 
        {
            return con; 
        }

    }
}
