using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public Pessoa() { }
        public Pessoa(int id, string nome)
        {
            Id = id;
            Nome = nome;
        }

        public string ToString()
        {
            return $"ID:{Id}  Nome:{Nome} ";
        }
    }
}