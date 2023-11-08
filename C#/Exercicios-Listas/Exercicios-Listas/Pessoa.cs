using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicios_Listas
{
    internal class Pessoa
    {
        public int Peso { get; set; }
        public int Idade { get; set; }

        public string Nome { get; set; }
        public string Sobrenome { get; set; }

        public string ToString()
        {
            return $"Nome: {Nome} Sobrenome: {Sobrenome} Idade: {Idade} Peso: {Peso}";
        }
        



    }
}
