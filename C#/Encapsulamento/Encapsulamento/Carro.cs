using System;

namespace Encapsulamento
{
    internal class Carro
    {
        private string placa;
        private string marca;
        private string modelo;
        private string cor;

        public Carro()
        {

        }

        public string Placa
        {
            get { return placa; }
            set
            {
                if (value.Length <= 7)
                {
                    Console.WriteLine("Placa inválida! Sua placa precisa ter 8 caracteres.");
                }
                else
                {
                    placa = value;
                }
            }
        }

        public string Marca
        {
            get { return marca; }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Marca inválida! Precisa ter no mínimo 4 caracteres");
                }
                else
                {
                    marca = value;
                }
            }
        }

        public string Modelo
        {
            get { return modelo; }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Modelo inválido! Precisa ter no mínimo 4 caracteres");
                }
                else
                {
                    modelo = value;
                }
            }
        }

        public string Cor
        {
            get { return cor; }
            set
            {
                if (value.Length < 4)
                {
                    Console.WriteLine("Cor inválida! Precisa ter no mínimo 4 caracteres");
                }
                else
                {
                    cor = value;
                }
            }
        }

        public void Mostrar()
        {
            Console.WriteLine($"Placa: {placa}");
            Console.WriteLine($"Marca: {Marca}");
            Console.WriteLine($"Modelo: {Modelo}");
            Console.WriteLine($"Cor: {Cor}");


        }
    }
}
