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
        public int IDCategoria { get; set; }    

        public Categoria Categoria { get; set; }    


        public Produto() { }  

        public Produto(int id, string nome, int valor, int estoque, int iDCategoria)
        {
            Id = id;    
            Nome = nome;
            Valor = valor;
            Estoque = estoque;
            IDCategoria = iDCategoria;
        }

        public override string ToString()
        {
            return $"idCategoria: {IDCategoria}, DescCat: {Categoria.Descricao.Trim()}, ID_Produto: {Id} Nome: {Nome.Trim()} Valor: {Valor} Estoque: {Estoque}";
        }
    }
}
