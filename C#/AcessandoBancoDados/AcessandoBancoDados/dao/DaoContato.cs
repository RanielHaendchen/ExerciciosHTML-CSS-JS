using AcessandoBancoDados.entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace AcessandoBancoDados.dao
{
    public class DaoContato
    {
        public bool salvar(Contato contato)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*Criando conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = bd_agenda; Integrated Security = True; Connect Timeout = 30; Encrypt = False";
                con.Open();
                /*Monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into tb_contatos([nome],[email],[telefone])values(@nome,@email,@telefone)";

                /*Envia os dados a serem gravados*/
                cn.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = contato.Nome;
                cn.Parameters.Add("email", System.Data.SqlDbType.VarChar).Value = contato.Email;
                cn.Parameters.Add("telefone", System.Data.SqlDbType.VarChar).Value = contato.Telefone;


                /**Abrir a conexão*/
                cn.Connection = con;

                /*Executa a conexão*/
                return cn.ExecuteNonQuery() > 0;
                

            }
            /*  Console.WriteLine($"Salvando {contato.Nome}");*/
            return true;
        }
        public void consultar()
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*criado conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=bd_agenda;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
                con.Open();
                /*monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "select * from tb_contatos";

                /*abrir a conexaõ*/
                cn.Connection = con;

                /*executa a conexão*/
                SqlDataReader dr;
                dr = cn.ExecuteReader();
                while (dr.Read())
                {
                    Contato ct = new Contato();
                    ct.Id = Convert.ToInt32(dr["id"]);
                    ct.Nome = Convert.ToString(dr["nome"]);
                    ct.Email = Convert.ToString(dr["email"]);
                    ct.Telefone = Convert.ToString(dr["telefone"]);
                    Console.WriteLine(ct.ToString());
                }
            }
        }
    }

    
}
