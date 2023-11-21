using CRUDBancoDeDados.DAO;
using CRUDBancoDeDados.entidades;

namespace CRUDBancoDeDados
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Categoria cr = new Categoria(1, "Grãos");
            DaoCategorias daoCategorias = new DaoCategorias();
            if (daoCategorias.salvar(cr))
            {
                Console.WriteLine("Categoria Salva");

                // Criar e salvar um Produto associado à Categoria
                Produto pr = new Produto(1, "Arroz", 10, 20);
                pr.Categoria = cr; // Associando a categoria ao produto
                DaoProdutos daoProdutos = new DaoProdutos();
                if (daoProdutos.salvar(pr))
                {
                    Console.WriteLine("Produto Salvo");

                    // Consultar e exibir categorias
                    Console.WriteLine("Consultando Categorias:");
                    daoCategorias.consultar();

                    // Consultar e exibir produtos
                    Console.WriteLine("Consultando Produtos:");
                    daoProdutos.consultar();
                }
            }



        }
    }
}