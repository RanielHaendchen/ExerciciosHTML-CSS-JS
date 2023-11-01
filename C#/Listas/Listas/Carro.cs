using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Listas
{
    internal class Carro
    { /*Criar a classe Carro com os seguintes atributos: placa, marca, modelo, cor, criar o método display;*/
        public string Placa { get; set; }
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public string ToString()
        {
            return $"Placa: {Placa} Marca: {Marca} Modelo: {Modelo} Cor: {Cor}";
        }
    }
}
