namespace AulaPOO
{
    class Program
    {
        static void Main(string[] args)
        {
            /*criarCarro();*/
            /*Calculadora();*/
            /*mostraPessoa()*/
            /*Retangulo();*/
            /*Produtos();*/

        }

        private static void mostraPessoa()
        {
            /*Pessoa p1 = new Pessoa();
            p1.nome = "Maria";
            p1.email = "maria@gmail.com";
            p1.senha = "123";
            p1.display();*/
        }
        private static void criarCarro()
        {
            /*Cria o objeto carro*/
            Carro c1 = new Carro();
            c1.placa = "BRA2E19";
            c1.marca = "Nissan";
            c1.modelo = "370Z";
            c1.cor = "Preto";
            c1.capacidadeTanqueCombustivel = 40;
            c1.display();
            double x = c1.autonomia(10);
            Console.WriteLine(x);


            /*Cria outro objeto carro*/
            Carro c2 = new Carro();
            c2.placa = "BRA0193";
            c2.marca = "Volkswagen";
            c2.modelo = "Fusca";
            c2.cor = "Preto";
            c2.capacidadeTanqueCombustivel = 30;
            c2.display();
            double y = c2.autonomia(14);
            Console.WriteLine (y);

        }

        private static void Calculadora()
        {
            Calculadora calc = new Calculadora();

            Console.WriteLine("Escolha seu primeiro número:");
            calc.n1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha seu segundo número:");
            calc.n2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Escolha a conta:");
            Console.WriteLine("1: Adição");
            Console.WriteLine("2: Subtração");
            Console.WriteLine("3: Multiplicação");
            Console.WriteLine("4: Divisão");

            string opcao = Console.ReadLine();


            if (opcao == "1")
            {
                calc.adição();
            }
            else if (opcao == "2")
            {
                calc.subtração();
            }
            else if (opcao == "3")
            {
                calc.multiplicação();
            }
            else if (opcao == "4")
            {
                calc.divisão();
            }

            Console.WriteLine($"O resultado da sua conta é: {calc.resultado} ");

        }
        private static void Retangulo()
        {

            Retangulo retan = new Retangulo();

            Console.WriteLine("Digite a altura do retangulo");
            retan.altura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Digite a largura do retangulo");
            retan.largura = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"A Area do seu retangulo: {retan.calcularArea()}");
            Console.Write($"O Perimetro do seu retangulo: {retan.calcularPerimetro()}");
        }

        private static void Produtos()
        {
            Produtos prod = new Produtos();

            prod.codigo = 1;
            prod.descrição = "Carne";
            prod.estoque = 5;
            prod.display();

            Console.Write("Digite o valor da carne: ");
            prod.valor = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o valor do desconto: ");
            prod.valorDesconto = Convert.ToInt32(Console.ReadLine());


            prod.Desconto();
            Console.WriteLine(prod.valor);

           
        }
    }
}