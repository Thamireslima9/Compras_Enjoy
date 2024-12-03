using Compras_Enjoy.Model;

using System;

using System.Collections.Generic;

using System.Data.SqlClient;

using System.Drawing;

using System.Linq;

using System.Text;

using System.Threading.Tasks;
using System.Windows.Forms;

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

             (@preco, @tipo, @nome, @descricao, @marca, @estoque)";


            Command.Parameters.AddWithValue("@nome", prop.NomeLouca);

            Command.Parameters.AddWithValue("@tipo", prop.Tipolouca);

            Command.Parameters.AddWithValue("@descricao", prop.DescricaoLouca);

            Command.Parameters.AddWithValue("@preco", prop.Preco);

            Command.Parameters.AddWithValue("@marca", prop.Marca);

            Command.Parameters.AddWithValue("@estoque", prop.Estoque);

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
            
            Preco = @preco,

            TipoLouca = @tipo, 
            
            NomeLouca = @nome,

            DescricaoLouca = @descricao,
            
            MarcaLouca = @marca,

            Estoque = @estoque

            WHERE CodLouca = @code";

            Command.Parameters.AddWithValue("@code", prop.CodLouca);

            Command.Parameters.AddWithValue("@nome", prop.NomeLouca);

            Command.Parameters.AddWithValue("@tipo", prop.Tipolouca);

            Command.Parameters.AddWithValue("@descricao", prop.DescricaoLouca);

            Command.Parameters.AddWithValue("@preco", prop.Preco);

            Command.Parameters.AddWithValue("@marca", prop.Marca);

            Command.Parameters.AddWithValue("@estoque", prop.Estoque);
            

            try

            {

                Command.ExecuteNonQuery();

            }

            catch (Exception err)

            {

                throw new Exception("Erro: Problemas ao realizar atualização da louça no banco.\n" + err.Message);

            }

            finally

            {

                Connect.CloseConnection();

            }

        }

        public void Excluir(int code)

        {

            Command.Connection = Connect.ReturnConnection();

            Command.CommandText = @"DELETE FROM Loucas 

            WHERE CodLouca = @code";

            Command.Parameters.Clear();

            Command.Parameters.AddWithValue("@code", code);

            try

            {

                Command.ExecuteNonQuery();

            }

            catch (Exception err)

            {

                throw new Exception("Erro: Problemas ao excluir louça no banco.\n" + err.Message);

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

                      (string)rd["NomeLouca"],

                      (string)rd["TipoLouca"],

                      (string)rd["DescricaoLouca"],

                      float.Parse(rd["Preco"].ToString()),

                      (int)rd["Estoque"],

                      (string)rd["MarcaLouca"]);
                      
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


            return listaLoucas;


        }

     
    }

}
