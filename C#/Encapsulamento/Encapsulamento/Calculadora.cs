using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulamento
{
    internal class Calculadora
    {
        private int num1;

        private int num2;

        public Calculadora()
        {

        }

        public int Num1
        {
            get { return num1; }
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("Por favor, insira um número maior ou igual a zero para N1:");
                    value = int.Parse(Console.ReadLine());
                }

                num1 = value;
            }
        }

        public int Num2
        {
            get { return num2; }
            set
            {
                while (value < 0)
                {
                    Console.WriteLine("Por favor, insira um número maior ou igual a zero para N1:");
                    value = int.Parse(Console.ReadLine());
                }

                num2 = value;
            }
        }

        public void adicao()
        {
            Console.WriteLine(num1  + num2);
        }

        public void subtracao()
        {
            Console.WriteLine(num1 - num2);
        }

        public void multiplicacao()
        {
            Console.WriteLine(num1 * num2);
        }

        public void divisao()
        {
            Console.WriteLine(num1 / num2); 
        }
        

    }
}
