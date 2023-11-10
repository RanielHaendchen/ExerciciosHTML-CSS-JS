using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Produto
    {
        private string codigo;
        private string descricao;
        private int estoque;
        private double valorUnitario;

        public Produto()
        {
            Codigo = "0001";
            Descricao = "Sem Descrição";
            Estoque = 0;
            ValorUnitario = 1.0;
        }
        public Produto(string codigo, string descricao, int estoque, double valorUnitario)
        {
            Codigo = codigo;
            Descricao = descricao;
            Estoque = estoque;
            ValorUnitario = valorUnitario;
        }

        public string Codigo
        {
            get { return codigo; }
            set
            {
                if (value.Length >= 4)
                {
                    codigo = value;
                }
                else
                {
                    Console.WriteLine("O código deve ter pelo menos 4 caracteres.");
                }
            }
        }

        public string Descricao
        {
            get { return descricao; }
            set
            {
                if (value.Length >= 4)
                {
                    descricao = value;
                }
                else
                {
                    Console.WriteLine("A descrição deve ter pelo menos 4 caracteres.");
                }
            }
        }

        public int Estoque
        {
            get { return estoque; }
            set
            {
                if (value >= 0)
                {
                    estoque = value;
                }
                else
                {
                    Console.WriteLine("O estoque deve ser maior ou igual a zero.");
                }
            }
        }

        public double ValorUnitario
        {
            get { return valorUnitario; }
            set
            {
                if (value > 0)
                {
                    valorUnitario = value;
                }
                else
                {
                    Console.WriteLine("O valor unitário deve ser maior que zero.");
                }
            }
        }

        public double CalcularPrecoComDesconto(double descontoPercentual)
        {
            double desconto = ValorUnitario * (descontoPercentual / 100);
            return ValorUnitario - desconto;
        }

        public double CalcularPrecoComAcrescimo(double acrescimoPercentual)
        {
            double acrescimo = ValorUnitario * (acrescimoPercentual / 100);
            return ValorUnitario + acrescimo;
        }
    }
}

