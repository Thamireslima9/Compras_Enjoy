using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Compras_Enjoy.Model
{
    internal class Louca
    {
        public int CodLouca { get; set; }

        public string NomeLouca { get; set; }

        public string Tipolouca { get; set; }

        public string DescricaoLouca { get; set; }

        public float Preco { get; set; }




        public Louca(int codLouca, string nomeLouca,
          string tipolouca, string descricao,float preco): this(nomeLouca, tipolouca,descricao, preco)
        {
            CodLouca = codLouca;
        }

        public Louca(string nomeLouca, string tipolouca, string descricao, float preco)
        {
            NomeLouca = nomeLouca;
            Tipolouca = tipolouca;
            DescricaoLouca = descricao;
            Preco = preco;
        }
    }
}
