using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    class Person
    {
        private string name;

        public string Name
        {
            get { return name; }
            set
            {
                if (value.Length < 3)
                {
                    Console.WriteLine("Nome precisa ter no minimo três caracteres");
                }
                else
                {
                    name = value;
                }
            }
        }

        public int Age { get; set; }
        public string Situacao
        {
            get
            {
                string msg = "maior";
                if (Age < 18) { msg = "menor"; }
                return msg;
            }
        }
        public string ToString()
        {
            return $"Nome: {name}  Idade: {Age}";
        }
    }
}