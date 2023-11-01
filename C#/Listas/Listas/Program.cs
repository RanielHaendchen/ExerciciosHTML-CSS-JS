using System.Numerics;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Security.Cryptography.X509Certificates;
using System.Text.RegularExpressions;

namespace Listas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Carro> carros = new List<Carro>();

            while (true)
            {
                Console.WriteLine("Selecione:");
                Console.WriteLine("1- Criar carro");
                Console.WriteLine("2- Listar todos os carro");
                Console.WriteLine("3- Procurar carro por placa");
                Console.WriteLine("4- Atualizar dados do carro");
                Console.WriteLine("5- Deletar carro");
                Console.WriteLine("6- Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao)
                {
                    case 1:
                        Carro car = new Carro();

                        Console.WriteLine("Digite a placa do carro: ");
                        car.Placa = Console.ReadLine();

                        Console.WriteLine("Digite a marca do carro: ");
                        car.Marca = Console.ReadLine();

                        Console.WriteLine("Digite o modelo do carro: ");
                        car.Modelo = Console.ReadLine();

                        Console.WriteLine("Digite a cor do carro: ");
                        car.Cor = Console.ReadLine();

                        carros.Add(car);
                        Console.Clear();
                    break;

                    case 2:
                        foreach (Carro mostraCarro in carros)
                        {
                            Console.WriteLine(mostraCarro.ToString());
                        }                        

                    break;

                   case 3:
                        Console.WriteLine("Digite a placa do carro: ");
                        string procuraPlaca = Console.ReadLine();

                        bool placaEncontrada = false;

                        foreach (Carro mostraCarro in carros)
                        {
                            if (mostraCarro.Placa == procuraPlaca)
                            {
                                Console.WriteLine("Placa: " + mostraCarro.Placa);
                                Console.WriteLine("Marca: " + mostraCarro.Marca);
                                Console.WriteLine("Modelo: " + mostraCarro.Modelo);
                                Console.WriteLine("Cor: " + mostraCarro.Cor);

                                placaEncontrada = true;
                                break;
                            }
                        }

                        if (!placaEncontrada)
                        {
                            Console.WriteLine("Carro não encontrado");
                        }

                   break;

                    case 4:
                        /*Atualizar dados*/
                        Console.WriteLine("Digite a placa do carro que deseja atualizar");
                        string placaParaAtualizar = Console.ReadLine();

                        bool carroEncontrado = false;

                        for (int i = 0; i < carros.Count; i++)
                        {
                            if (carros[i].Placa ==  placaParaAtualizar)
                            {
                                Console.WriteLine("Digite a nova placa: ");
                                string novaPlaca = Console.ReadLine();
                                carros[i].Placa = novaPlaca;

                                Console.WriteLine("Digite a nova marca: ");
                                string novaMarca = Console.ReadLine();
                                carros[i].Marca = novaMarca;

                                Console.WriteLine("Digite o novo modelo: ");
                                string novoModelo = Console.ReadLine();
                                carros[i].Modelo = novoModelo;

                                Console.WriteLine("Digite a nova cor: ");
                                string novaCor = Console.ReadLine();
                                carros[i].Cor = novaCor;
                                carroEncontrado = true;

                                Console.Clear();
                                
                            }
                        }
                        if (!carroEncontrado)
                        {
                            Console.WriteLine("Carro não encontrado");
                        }


                    break;

                    case 5:
                        Console.WriteLine("Digite a placa para remover o carro: ");
                        string placaParaDeletar = Console.ReadLine();

                        bool carroEncontradoParaDeletar = false;

                        for (int i = 0; i < carros.Count; i++)
                        {
                            if (carros[i].Placa == placaParaDeletar)
                            {
                                carros.RemoveAt(i);
                                carroEncontradoParaDeletar = true;
                                Console.Clear();
                                break;
                            }
                        }

                        if (!carroEncontradoParaDeletar)
                        {
                            Console.WriteLine("Carro não encontrado");
                        }
                    break;

                    case 6:
                        Console.WriteLine("Saindo do programa");
                    return;

                    default:
                        Console.WriteLine("Opção invalida. Digite um número de 1 a 6");
                    break;

                }
            }
        }
     

     }
}