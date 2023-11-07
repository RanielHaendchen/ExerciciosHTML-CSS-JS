using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Heranca
{
    class Cliente : Pessoa
    {
        public string Cpf { get; set; }

        public string ToString()
        {
            string msgDoPai = base.ToString();
            return $"{msgDoPai} CPF:{Cpf} ";
        }

        public Cliente() { }
        public Cliente(int id, string nome, string cpf) : base(id, nome)
        {
            Cpf = cpf;
        }

    }
}