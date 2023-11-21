using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBancoDeDados.entidades
{
    public class Produto
    { 

        public int Id { get; set; }
        public string Nome { get; set; } 
        public int Valor { get; set; }
        public int Estoque { get; set; }

        public Categoria Categoria { get; set; } = new Categoria(); 


        public Produto() { }  

        public Produto(int id, string nome, int valor, int estoque)
        {
            Id = id;
            Nome = nome;
            Valor = valor;
            Estoque = estoque;
        }

        public override string ToString()
        {
            return $"{Categoria.ToString()} ID_Produto: {Id} Nome: {Nome.Trim()} Valor: {Valor} Estoque: {Estoque}";
        }
    }
}
