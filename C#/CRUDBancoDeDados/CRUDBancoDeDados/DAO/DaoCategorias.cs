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
    internal class DaoCategorias
    {
        public bool salvar(Categoria categoria)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*Criando conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_CategoriasProdutos;Integrated Security=True;Connect Timeout=30;Encrypt=False;"; ;
                con.Open();
                /*Monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into Categorias([descricao])values(@descricao)";

                /*Envia os dados a serem gravados*/
                cn.Parameters.Add("descricao", System.Data.SqlDbType.VarChar).Value = categoria.Descricao;
               

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
                cn.CommandText = "select * from Categorias";

                /*abrir a conexaõ*/
                cn.Connection = con;

                /*executa a conexão*/
                SqlDataReader dr;
                dr = cn.ExecuteReader();
                while (dr.Read())
                {
                    Categoria categoria = new Categoria();
                    categoria.Id = Convert.ToInt32(dr["id"]);
                    categoria.Descricao = Convert.ToString(dr["descricao"]);

                    Console.WriteLine(categoria.ToString());
                }
            }
        }
    }
} 
