using Compras_Enjoy.Model;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Drawing;
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
            Command.CommandText =
            @"INSERT INTO
            Loucas VALUES 
            (@nome, @tipo, @descricao, @preco)";

            Command.Parameters.AddWithValue("@nome", prop.NomeLouca);
            Command.Parameters.AddWithValue("@tipo", prop.Tipolouca);
            Command.Parameters.AddWithValue("@descricao", prop.Descricao);
            Command.Parameters.AddWithValue("@preco", prop.Preco);

            try
            {
                //Executa query definida acima.
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao inserir " +
                    "louças no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        
        public void Atualizar(Louca prop)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Loucas SET 
            Nome = @nome,
            Tipo = @tipo, 
            Descricao = @descricao,
            Preco = @preco 
            WHERE CodLouca = @code";
 
            Command.Parameters.AddWithValue("@nome", prop.NomeLouca); 
            Command.Parameters.AddWithValue("@tipo", prop.Tipolouca);
            Command.Parameters.AddWithValue("@descricao", prop.Descricao);
            Command.Parameters.AddWithValue("@preco", prop.Preco);

            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
              
        public void Excluir(int codLouca)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"DELETE FROM Loucas WHERE CodLouca = @cod";
            Command.Parameters.AddWithValue("@cod", codLouca);
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }
        public List<Louca> ListarTodasLoucas()
        {

            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = "SELECT * FROM Loucas";

            List<Louca> listaLoucas = new List<Louca>(); //Instancio a list com o tamanho padrão.
            try
            {
                SqlDataReader rd = Command.ExecuteReader();

                //Enquanto for possível continuar a leitura das linhas que foram retornadas na consulta, execute.
                while (rd.Read())
                {
                    Louca louca = new Louca(
                        (int)rd["CodLouca"],
                        (string)rd["Nome"],
                        (string)rd["Tipo"],
                        (string)rd["Descrição"],
                        (float)rd["Preço"]);
                    listaLoucas.Add(louca);
                }
                rd.Close();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar leitura de usuários no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }
        }

        public void Atualizar(Louca LoucaAtualizada)
        {
            Command.Connection = Connect.ReturnConnection();
            Command.CommandText = @"UPDATE Loucas SET Preco = @preco, Tipo = @tipo, Nome = @nome, DescricaoLouca = @descricao
            WHERE CodLouca = @code";

            Command.Parameters.AddWithValue("@preco", LoucaAtualizada.Preco);
            Command.Parameters.AddWithValue("@tipo", LoucaAtualizada.Tipolouca);
            Command.Parameters.AddWithValue("@nome", LoucaAtualizada.NomeLouca);
            Command.Parameters.AddWithValue("@descricao", LoucaAtualizada.DescricaoLouca);
            Command.Parameters.AddWithValue("@code", LoucaAtualizada.CodLouca);

            
            try
            {
                Command.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao realizar atualização de usuário no banco.\n" + err.Message);
            }
            finally
            {
                Connect.CloseConnection();
            }

            return listaLoucas;
        }
    }
}
