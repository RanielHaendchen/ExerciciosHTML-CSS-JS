using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO
{
    internal class Pessoa
    {
        public string nome;
        public string email;
        public string senha;

        public void display()
        {
                Console.WriteLine($"Nome: {this.nome}");
                Console.WriteLine($"Email: {this.email}");
                Console.WriteLine($"Senha: {this.senha}"); 
        }
    }
}
