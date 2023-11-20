using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoBancoDados.entidades
{
    public class Local
    {
        public int Id { get; set; }

        public string Nome { get; set; }
        public string Rua { get; set; }

        public string Numero { get; set; }

        public string Cidade { get; set; }

        public string UF { get; set; }

        public Local() { }

        public Local(int id, string nome, string rua, string numero, string cidade, string uf)
        {
            Id = id;
            Nome = nome;
            Rua = rua;
            Numero = numero;
            Cidade = cidade;
            UF = uf;
        }
    }
}
    

