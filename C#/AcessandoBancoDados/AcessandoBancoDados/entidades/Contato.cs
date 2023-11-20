using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoBancoDados.entidades
{
    public class Contato
    {
        public int Id { get; set; }

        public string Nome { get; set; }
         public string Email { get; set;}

        public string Telefone { get; set;} 

        public Contato() { }

        public Contato(int id, string nome, string email, string telefone)
        {
            Id = id;
            Nome = nome;
            Email = email;
            Telefone = telefone;
        }

        public override string ToString()
        {
            return $"Id: {Id}, Nome: {Nome.Trim()}, Email: {Email.Trim()}, Telefone: {Telefone.Trim()}";  
        }

    }
}
