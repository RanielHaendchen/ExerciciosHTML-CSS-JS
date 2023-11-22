using CRUDBancoDeDados.DAO;
using CRUDBancoDeDados.entidades;

namespace CRUDBancoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DaoCategorias daoCat = new DaoCategorias();
            Categoria cat = new Categoria();


            while (true)
            {
                Console.WriteLine("Selecione:");
                Console.WriteLine("1- Categorias");
                Console.WriteLine("2- Produtos");

                int opcao1 = Convert.ToInt32(Console.ReadLine());
                Console.Clear();

                switch (opcao1)
                {
                    case 1:
                        bool voltar = false;

                        while (!voltar)
                        {
                            Console.WriteLine("Menu Categoria:");
                            Console.WriteLine("1- Adicionar Categoria");
                            Console.WriteLine("2- Consultar Categoria");
                            Console.WriteLine("3- Atualizar Categoria");
                            Console.WriteLine("4- Deletar Categoria");
                            Console.WriteLine("5- Voltar");

                            int escolhaCategoria = Convert.ToInt32(Console.ReadLine());

                            switch (escolhaCategoria)
                            {
                                case 1:
                                    Console.WriteLine("Digite o nome da categoria: ");
                                    Categoria cr = new Categoria(Console.ReadLine());

                                    if (daoCat.salvar(cr))
                                    {
                                        Console.WriteLine("Categoria salva");

                                    }
                                    break;

                                case 2:
                                    daoCat.consultar();
                                    break;


                                case 3:
                                    Console.WriteLine("ID Da categoria: ");
                                    int id2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Nova descrição da categoria");
                                    string descricao2 = Console.ReadLine();
                                    Console.WriteLine("Descrição mudada com sucesso!");
                                    Categoria categoria2 = new Categoria(id2, descricao2);

                                    daoCat.atualizar(categoria2);

                                    break;
                                case 4:
                                    Console.WriteLine("Digite a ID que você quer deletar: ");
                                    cat.Id = Convert.ToInt32(Console.ReadLine());
                                    daoCat.deletar(cat);
                                    Console.WriteLine("Deletado com sucesso!");
                                    break;
                                case 5:
                                    voltar = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção invalida");
                                    break;

                            }
                        }
                        break;
                    case 2:
                        bool voltar2 = false;

                        while (!voltar2)
                        {
                            Console.WriteLine("Menu Produto:");
                            Console.WriteLine("1- Adicionar Produto");
                            Console.WriteLine("2- Consultar Produto");
                            Console.WriteLine("3- Atualizar Produto");
                            Console.WriteLine("4- Deletar Produto");
                            Console.WriteLine("5- Voltar");

                            int escolha = int.Parse(Console.ReadLine());

                            switch (escolha)
                            {
                                case 1:

                                    break;





                            }
                        }

                        break;
                }
            }    
        }
    }
}
    


    
