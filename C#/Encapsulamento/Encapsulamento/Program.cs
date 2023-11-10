using System.Security.Cryptography;

namespace Encapsulamento
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*MostraCarro();*/
            /*Calculadora();*/
            /*calcularRetangulo();    */
            Produto();

            /*Person p = new Person();
            p.Name = "zé";
            p.Age = 20;
            Console.WriteLine(p.ToString());
            Console.WriteLine($"Situação: {p.Situacao}");*/


            /*  Pessoa p = new Pessoa();
              p.nome = "Raniel";
              p.idade = 19;

              Console.WriteLine(p.ToString());

              Pessoa p2 = new Pessoa() { nome = "Maria", idade = 18 };
              Console.WriteLine(p2.ToString());

              Pessoa p3 = new Pessoa("Joana", 15);
              Console.WriteLine(p3.ToString());

              Pessoa p4 = new Pessoa("Antonio");
              Console.WriteLine(p4.ToString());

              Console.ReadKey();*/

        }

        private static void MostraCarro()
        {
            Carro c1 = new Carro();
            Console.WriteLine("Qual a placa do seu carro?");
            c1.Placa = (Console.ReadLine());

            Console.WriteLine("Qual a marca do seu carro?");
            c1.Marca = Console.ReadLine();

            Console.WriteLine("Qual o modelo do seu carro?");
            c1.Modelo = Console.ReadLine();

            Console.WriteLine("Qual a cor do seu carro?");
            c1.Cor = Console.ReadLine();
            c1.Mostrar();
        }

        private static void Calculadora()
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Digite seu primeiro número: ");
            calc.Num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite seu segundo número: ");
            calc.Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite sua opção:");
            Console.WriteLine("1: Adição");
            Console.WriteLine("2: Subtração");
            Console.WriteLine("3: Multiplicação");
            Console.WriteLine("4: Divisão");

            string opcao = Console.ReadLine();

            if (opcao == "1")
            {
                calc.adicao();
            }            
            else if (opcao == "2")
            {
                calc.subtracao();
            }
            else if (opcao == "3")
            {
                calc.multiplicacao();
            }
            else if (opcao == "4")
            {
                calc.divisao();
            }
            else
            {
                Console.WriteLine("Opção invalida");
            }

        }

        private static void calcularRetangulo()
        {
            Console.WriteLine("Insira o comprimento do retângulo:");
            double comprimento = LerNumero();

            Console.WriteLine("Insira a largura do retângulo:");
            double largura = LerNumero();

            Retangulo meuRetangulo = new Retangulo(comprimento, largura);

            Console.WriteLine($"Comprimento: {meuRetangulo.Comprimento}");
            Console.WriteLine($"Largura: {meuRetangulo.Largura}");

            Console.WriteLine($"Área: {meuRetangulo.CalcularArea()}");
            Console.WriteLine($"Perímetro: {meuRetangulo.CalcularPerimetro()}");
        }

        static double LerNumero()
        {
            double numero;

            while (!double.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("Por favor, insira um número válido.");
            }

            return numero;
        }
        
        private static void Produto()
        {
            // Solicitar ao usuário que insira os detalhes do produto
            Console.Write("Insira o código do produto: ");
            string codigo = Console.ReadLine();

            Console.Write("Insira a descrição do produto: ");
            string descricao = Console.ReadLine();

            Console.Write("Insira a quantidade em estoque do produto: ");
            int estoque = Convert.ToInt32(Console.ReadLine());

            Console.Write("Insira o valor unitário do produto: ");
            double valorUnitario = Convert.ToInt32(Console.ReadLine());

            // Criar um objeto Produto com os valores fornecidos pelo usuário
            Produto meuProduto = new Produto(codigo, descricao, estoque, valorUnitario);

            // Imprimir atributos
            Console.WriteLine($"\nCódigo: {meuProduto.Codigo}\nDescrição: {meuProduto.Descricao}\nEstoque: {meuProduto.Estoque}\nValor Unitário: {meuProduto.ValorUnitario:C}");

            // Calcular e imprimir preço com desconto e acréscimo
            Console.WriteLine($"\nPreço com Desconto (10%): {meuProduto.CalcularPrecoComDesconto(10.0):C}");
            Console.WriteLine($"Preço com Acréscimo (5%): {meuProduto.CalcularPrecoComAcrescimo(5.0):C}");
        }
    }

    
}
