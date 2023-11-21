﻿using CRUDBancoDeDados.entidades;
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
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_CategoriasProdutos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*Monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into Produto([nome],[valor],[estoque],[IDCategoria]) values(@nome,@valor,@estoque,@IDCategoria)";

                cn.Parameters.Add("nome", SqlDbType.VarChar).Value = produto.Nome;
                cn.Parameters.Add("valor", SqlDbType.Int).Value = produto.Valor;
                cn.Parameters.Add("estoque", SqlDbType.Int).Value = produto.Estoque;
                cn.Parameters.Add("IDCategoria", SqlDbType.Int).Value = produto.Categoria.Id;



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
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_CategoriasProdutos;Integrated Security=True;Connect Timeout=30;Encrypt=False;";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "select * from Produto";

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

                    // Verificar se o campo IDCategoria é nulo antes de converter
                    if (dr["IDCategoria"] != DBNull.Value)
                    {
                        produto.Categoria = new Categoria
                        {
                            Id = Convert.ToInt32(dr["IDCategoria"])
                        };
                    }

                    Console.WriteLine(produto.ToString());
                }
            }
        }
    }
}

