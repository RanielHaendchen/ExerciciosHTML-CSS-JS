namespace Heranca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            criaClientes();

            Console.ReadKey();
        }

        static void criaClientes()
        {
            Cliente cliente = new Cliente() { Id = 1, Nome = "Maria", Cpf = "123" };
            Console.WriteLine(cliente.ToString());

            Cliente cli = new Cliente(2, "João", "456");
            Console.WriteLine(cli.ToString());
        }
        static void criarVeiculos()
        {
            /* Veiculo veiculo = new Veiculo() { Marca = "Jeep" };
           Console.WriteLine(veiculo.Marca);
           veiculo.ronco();*/

            Carro carro = new Carro() { Modelo = "Renegade" };
            carro.Marca = "Jeep";
            Console.WriteLine(carro.Modelo + " " + carro.Marca);
            carro.ronco();
        }
        
        
    }
}