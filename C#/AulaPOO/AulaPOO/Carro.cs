using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO
{
    internal class Carro
    {

        /*Atributos da classe*/
        public string placa;
        public string marca;
        public string modelo;
        public string cor;
        public int capacidadeTanqueCombustivel;

        /*Metodos*/
        public void display()
        {
            Console.WriteLine($"Placa: {this.placa}");
            Console.WriteLine($"Marca: {this.marca}");
            Console.WriteLine($"Modelo: {this.modelo}");
            Console.WriteLine($"Cor: {this.cor}");
            Console.WriteLine();
        }

        public double autonomia(double mediaKm)
        {
            return capacidadeTanqueCombustivel * mediaKm;
        }
    }
}
