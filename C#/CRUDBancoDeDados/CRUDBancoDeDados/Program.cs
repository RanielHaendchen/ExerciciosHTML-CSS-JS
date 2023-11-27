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
            DaoProdutos daoProd = new DaoProdutos();
            Produto pr = new Produto();



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
                            Console.WriteLine("3- Consultar produto por categoria");
                            Console.WriteLine("4- Atualizar Produto");
                            Console.WriteLine("5- Deletar Produto");
                            Console.WriteLine("6- Voltar");

                            int escolha = int.Parse(Console.ReadLine());

                            switch (escolha)
                            {
                                case 1:
                                    Console.WriteLine("Digite o nome do produto:");                                  
                                    pr.Nome = Console.ReadLine();
                                    Console.WriteLine("Digite o valor do produto: ");
                                    pr.Valor = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Digite o estoque do produto: ");
                                    pr.Estoque = Convert.ToInt32(Console.ReadLine());
                                    Console.WriteLine("Digite ID da Categoria");
                                    pr.IDCategoria = Convert.ToInt32(Console.ReadLine());
                                    daoProd.salvar(pr);
                                    break;


                                case 2:
                                    daoProd.consultar() ;
                                    break;

                                case 3:
                                    Console.WriteLine("Digite o nome da categoria:");
                                    string nomeCategoria = Console.ReadLine();

                                    List<Produto> produtosDaCategoria = daoProd.ConsultarProdutoPorCategoria(nomeCategoria);

                                    foreach (Produto produto in produtosDaCategoria)
                                    {
                                        Console.WriteLine(produto.ToString());
                                    }
                                    break;


                                case 4:
                                    Console.WriteLine("Digite o ID do produto para mudar:");
                                    int id2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Novo nome do produto: ");
                                    string nome2 = Console.ReadLine();
                                    Console.WriteLine("Novo valor do produto: ");
                                    int valor2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Novo estoque do produto: ");
                                    int estoque2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Novo ID Da Categoria");
                                    int idCategoria2 = int.Parse(Console.ReadLine());
                                    Console.WriteLine("Produto mudado com sucesso!");
                                    Produto produto2 = new Produto(id2, nome2, valor2, estoque2, idCategoria2);

                                    daoProd.atualizar(produto2);
                                    break;

                                case 5:
                                    Console.WriteLine("Digite a ID que você quer deletar: ");
                                    pr.Id = Convert.ToInt32(Console.ReadLine());
                                    daoProd.deletar(pr);
                                    Console.WriteLine("Produto deletado com sucesso!");
                                    break;
                                case 6:
                                    voltar2 = true;
                                    break;
                                default:
                                    Console.WriteLine("Opção invalida");
                                    break;

                            }
                        }

                        break;
                    default:
                        Console.WriteLine("Opção invalida!");
                        break;
                }
            }    
        }
    }
}