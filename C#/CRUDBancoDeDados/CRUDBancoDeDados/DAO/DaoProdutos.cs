using CRUDBancoDeDados.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CRUDBancoDeDados.DAO
{
    internal class DaoProdutos
    {
        public bool salvar(Produto produto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*Criando conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_CategoriaProdutos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*Monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into Produto([nome],[valor],[estoque],[IDCategoria]) values(@nome,@valor,@estoque,@IDCategoria)";

                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = produto.Nome;
                cn.Parameters.Add("valor", SqlDbType.Int).Value = produto.Valor;
                cn.Parameters.Add("estoque", SqlDbType.Int).Value = produto.Estoque;
                cn.Parameters.Add("IDCategoria", SqlDbType.Int).Value = produto.IDCategoria;



                /**Abrir a conexão*/
                cn.Connection = con;

                /*Executa a conexão*/
                return cn.ExecuteNonQuery() > 0;


            }
        }
        public void consultar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_CategoriaProdutos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "SELECT p.Id, p.Nome, p.Valor, p.Estoque, p.IDCategoria, c.Descricao AS DescCategoria FROM Produto p INNER JOIN Categorias c ON p.IDCategoria = c.Id";

                //cn.CommandText = "select * from Produto";

                /*abrir a conexão*/
                cn.Connection = con;

                /*executa a conexão*/
                SqlDataReader dr;
                dr = cn.ExecuteReader();
                while (dr.Read())
                {
                    Produto produto = new Produto();
                    produto.Id = Convert.ToInt32(dr["ID"]);
                    produto.Nome = Convert.ToString(dr["Nome"]);
                    produto.Valor = Convert.ToInt32(dr["Valor"]);
                    produto.Estoque = Convert.ToInt32(dr["Estoque"]);
                    produto.IDCategoria = Convert.ToInt32(dr["IDCategoria"]);

                    Categoria cat = new Categoria();
                    cat.Id = Convert.ToInt32(dr["IDCategoria"]);
                    cat.Descricao = Convert.ToString(dr["DescCategoria"]);


                    produto.Categoria = cat;
                    Console.WriteLine(produto.ToString());
                }
            }
        }
        public void atualizar(Produto produto)
        {
            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_CategoriaProdutos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();

                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = $"UPDATE Produto SET nome = @nome, valor = @valor, estoque = @estoque, IDCategoria = @IDCategoria WHERE Id = @Id;";

                cn.Parameters.Add("@nome", System.Data.SqlDbType.VarChar).Value = produto.Nome;
                cn.Parameters.Add("@valor", System.Data.SqlDbType.Int).Value = produto.Valor;
                cn.Parameters.Add("estoque", System.Data.SqlDbType.Int).Value = produto.Estoque;
                cn.Parameters.Add("IDCategoria", System.Data.SqlDbType.Int).Value = produto.IDCategoria;
                cn.Parameters.Add("@Id", System.Data.SqlDbType.VarChar).Value = produto.Id;



                cn.Connection = con; 
                cn.ExecuteNonQuery();
            }


        }

        public List<Produto> ConsultarProdutoPorCategoria(string nomeCategoria)
        {
            List<Produto> produtos = new List<Produto>();

            using (SqlConnection con = new SqlConnection())
            {
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_CategoriaProdutos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();

                SqlCommand cmd = new SqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT p.Id, p.Nome, p.Valor, p.Estoque, p.IDCategoria, c.Descricao AS DescCategoria " +
                                  "FROM Produto p INNER JOIN Categorias c ON p.IDCategoria = c.Id " +
                                  "WHERE c.Descricao = @NomeCategoria";

                cmd.Parameters.Add("@NomeCategoria", SqlDbType.NVarChar).Value = nomeCategoria;
                cmd.Connection = con;

                SqlDataReader dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Produto produto = new Produto();
                    produto.Id = Convert.ToInt32(dr["Id"]);
                    produto.Nome = Convert.ToString(dr["Nome"]);
                    produto.Valor = Convert.ToInt32(dr["Valor"]); 
                    produto.Estoque = Convert.ToInt32(dr["Estoque"]);
                    produto.IDCategoria = Convert.ToInt32(dr["IDCategoria"]);

                    Categoria cat = new Categoria();
                    cat.Id = Convert.ToInt32(dr["IDCategoria"]);
                    cat.Descricao = Convert.ToString(dr["DescCategoria"]);

                    produto.Categoria = cat;
                    produtos.Add(produto);
                }
            }

            return produtos;
        }

        public void deletar(Produto produto)
        {      
                using (SqlConnection con = new SqlConnection())
                {
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=db_CategoriaProdutos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();

                    SqlCommand cn = new SqlCommand();
                    cn.CommandType = CommandType.Text;
                    cn.CommandText = $"DELETE from Produto WHERE Id = @Id";

                    cn.Parameters.Add("@Id", System.Data.SqlDbType.Int).Value = produto.Id;



                    cn.Connection = con;
                    cn.ExecuteNonQuery();

                }
            
        }
    }
}

