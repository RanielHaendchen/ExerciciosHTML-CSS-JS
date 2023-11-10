using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AulaPOO
{
    internal class Calculadora
    {

        public int n1;
        public int n2;
        public int resultado;

        public void adição()
        {
           resultado = (n1 + n2); 
        }

        public void subtração()
        {
            resultado = (n1 - n2);
        }

        public void multiplicação()
        {
            resultado = (n1 * n2);   
        }

        public void divisão()
        {
            resultado = (n1 / n2);
        }
        

    }
}
