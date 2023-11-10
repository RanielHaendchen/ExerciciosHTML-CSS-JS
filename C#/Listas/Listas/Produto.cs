using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Produto
    {
        public string Id { get; set; }
        public string Descricao { get; set; }
        public int Estoque { get; set; }
        public int ValorUnitario { get; set; }
        
        public string ToString()
        {
            return $"Id: {Id}, Descrição: {Descricao}, Estoque: {Estoque}, Valor Unitário {ValorUnitario}";


        }
    }
}
