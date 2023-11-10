using Encapsulamento;
using System;
using System.Collections.Generic;
using System.IO.Pipes;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Pessoa
    {
        public string nome;
        public int idade;

        public Pessoa()
        {

        }


        public Pessoa(string nome, int idade)
        {
            this.nome = nome;
            this.idade = idade;
        }

        public Pessoa(string nome)
        {
            this.nome = nome;
        }

        public string ToString()
        {
            return $"Nome: {nome} Idade: {idade}";
        }
    }
}


