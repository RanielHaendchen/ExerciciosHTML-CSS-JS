using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO
{
    internal class Produtos
    {
        public int codigo;
        public string descrição;
        public int estoque;
        public double valor;
        public double valorDesconto;

        public void Desconto()
        {
            valor = valor - (valor * valorDesconto / 100);
        }

        public void display()
        {
            Console.WriteLine($"Código do produto: {codigo}");
            Console.WriteLine($"Descrição do produto: {descrição}");
            Console.WriteLine($"Estoque do produto: {estoque}");
        }
        

    }
}
