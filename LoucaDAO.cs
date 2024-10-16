using Compras_Enjoy.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Compras_Enjoy
{
    internal class LoucaDAO
    {
        private Connection Connect { get; set; }
        private SqlCommand Command { get; set; }
        //Sempre o nome da classe
        public LoucaDAO()
        {
            Connect = new Connection();
            Command = new SqlCommand();
        }
        public void Insert(Louca prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"INSERT INTO Loucas VALUES 
            (@preco, @tipo, @nome, @descricao)";

            Command.Parameters.AddWithValue("@preco", prop.Preco);
            Command.Parameters.AddWithValue("@tipo", prop.Tipolouca);
            Command.Parameters.AddWithValue("@nome", prop.NomeLouca);
            Command.Parameters.AddWithValue("@descricao", prop.Descricao);


            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "louças.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
    }
}
