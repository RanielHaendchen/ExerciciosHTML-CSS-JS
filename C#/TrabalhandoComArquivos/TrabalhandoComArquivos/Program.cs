using Microsoft.VisualBasic.FileIO;
using System;
using System.Security.Cryptography;

namespace TrabalhandoComArquivos
{
    internal class Program
    {
        static string path = @"C:\Users\raniel.silva\Desktop\LugarParaColocarArquivoC\produto.txt";

        static void Main(string[] args)
        {
            crudProduto();
            Console.WriteLine("Hello, World!");
        }

        static void crudProduto()
        {
            List<Produto> listaProdutos = new List<Produto>();
            Produto produto = new Produto();

            
            while (true)
            {
                Console.WriteLine("Selecione:");
                Console.WriteLine("1- Adicionar Produto");
                Console.WriteLine("2- Listar todos os produtos");
                Console.WriteLine("3- Procurar produto por ID");
                Console.WriteLine("4- Atualizar dados do Produto");
                Console.WriteLine("5- Deletar Produto");
                Console.WriteLine("6- Sair");

                int opcao = Convert.ToInt32(Console.ReadLine());
                /*            return $"Id: {Id}, Descrição: {Descricao}, Estoque: {Estoque}, Valor Unitário {ValorUnitario}";
*/
                switch (opcao)
                {
                    case 1:
                        Console.WriteLine("Digite o ID do produto: ");
                        produto.Id = Console.ReadLine();

                        Console.WriteLine("Digite a descrição do produto: ");
                        produto.Descricao = Console.ReadLine();

                        Console.WriteLine("Digite o estoque do produto: ");
                        produto.Estoque = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Digite o valor do produto: ");
                        produto.ValorUnitario = Convert.ToInt32(Console.ReadLine());
                        listaProdutos.Add(produto);
                        Console.Clear();

                        if (!File.Exists(path))
                        {
                            using (StreamWriter sw = File.CreateText(path))
                            {
                                sw.WriteLine($"Id do produto: {produto.Id}");
                                sw.WriteLine($"Descricao do produto: {produto.Descricao}");
                                sw.WriteLine($"Estoque do produto: {produto.Estoque}");
                                sw.WriteLine($"Valor do produto: {produto.ValorUnitario}");
                            }

                        }
                        else 
                        {
                            using StreamWriter sw = File.AppendText(path);
                            {
                                sw.WriteLine($"Id do produto: {produto.Id}");
                                sw.WriteLine($"Descricao do produto: {produto.Descricao}");
                                sw.WriteLine($"Estoque do produto: {produto.Estoque}");
                                sw.WriteLine($"Valor do produto: {produto.ValorUnitario}");
                            }
                        }
                        break;
                    case 2:
                        /*foreach (Produto mostraProdutos in listaProdutos)
                        {
                            Console.WriteLine(mostraProdutos.ToString());
                        }*/
                        using (StreamReader sr = File.OpenText(path))
                        {
                            string s;
                            while ((s = sr.ReadLine()) != null)
                            {
                                Console.WriteLine(s);
                            }

                           
                        }

                        break;
                    case 3:
                       /* Console.WriteLine("Digite o ID do produto: ");
                        string buscaId = Console.ReadLine();

                        bool produtoEncontrado = false;

                        foreach (Produto mostraProduto in listaProdutos)
                        {
                            if (mostraProduto.Id == buscaId)
                            {
                                Console.WriteLine(mostraProduto.ToString());
                                produtoEncontrado = true;
                                break;
                            }
                        }

                        if (!produtoEncontrado)
                        {
                            Console.WriteLine("Produto não encontrado");
                        }*/





                        break;

                    case 4:
                        /* Atualizar dados do Produto */
                        Console.WriteLine("Digite o ID do produto que deseja atualizar: ");
                        string idParaAtualizar = Console.ReadLine();

                        bool produtoEncontradoParaAtualizar = false;

                        for (int i = 0; i < listaProdutos.Count; i++)
                        {
                            if (listaProdutos[i].Id == idParaAtualizar)
                            {
                                Console.WriteLine("Digite a nova descrição: ");
                                string novaDescricao = Console.ReadLine();
                                listaProdutos[i].Descricao = novaDescricao;

                                Console.WriteLine("Digite o novo estoque: ");
                                int novoEstoque = Convert.ToInt32(Console.ReadLine());
                                listaProdutos[i].Estoque = novoEstoque;

                                Console.WriteLine("Digite o novo valor unitário: ");
                                int novoValorUnitario = Convert.ToInt32(Console.ReadLine());
                                listaProdutos[i].ValorUnitario = novoValorUnitario;

                                produtoEncontradoParaAtualizar = true;
                                Console.Clear();
                            }
                        }

                        if (!produtoEncontradoParaAtualizar)
                        {
                            Console.WriteLine("Produto não encontrado");
                        }
                        break;

                    case 5:
                        Console.WriteLine("Digite o ID para remover o produto: ");
                        string idParaDeletar = Console.ReadLine();

                        bool produtoEncontradoParaDeletar = false;

                        for (int i = 0; i < listaProdutos.Count; i++)
                        {
                            if (listaProdutos[i].Id == idParaDeletar)
                            {
                                listaProdutos.RemoveAt(i);
                                produtoEncontradoParaDeletar = true;
                                Console.Clear();
                                if (File.Exists(path))
                                {
                                            
                                }
                                break;
                            }
                        }

                        if (!produtoEncontradoParaDeletar)
                        {
                            Console.WriteLine("Produto não encontrado");
                        }
                        break;
                }
            }
        }
    }
}
    
