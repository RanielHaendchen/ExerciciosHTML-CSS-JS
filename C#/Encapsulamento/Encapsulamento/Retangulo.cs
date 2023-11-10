using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Retangulo
    {
        private double comprimento;
        private double largura;

       
        public Retangulo()
        {
            Comprimento = 1.0;
            Largura = 1.0;
        }

        
        public Retangulo(double comprimento, double largura)
        {
            Comprimento = comprimento;
            Largura = largura;
        }

        
        public double Comprimento
        {
            get { return comprimento; }
            set
            {
                if (value > 0)
                {
                    comprimento = value;
                }
                else
                {
                    Console.WriteLine("O comprimento deve ser maior que zero.");
                }
            }
        }

        public double Largura
        {
            get { return largura; }
            set
            {
                if (value > 0)
                {
                    largura = value;
                }
                else
                {
                    Console.WriteLine("A largura deve ser maior que zero.");
                }
            }
        }

        public double CalcularArea()
        {
            return Comprimento * Largura;
        }

        public double CalcularPerimetro()
        {
            return 2 * (Comprimento + Largura);
        }
    }
}

