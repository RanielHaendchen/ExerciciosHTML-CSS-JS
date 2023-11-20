using AcessandoBancoDados.entidades;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcessandoBancoDados.dao
{
    internal class DaoLocais
    {
        public bool salvar(Local local)
        {
            using (SqlConnection con = new SqlConnection())
            {
                /*Criando conexão com database*/
                con.ConnectionString = @"Data Source=(localdb)\MSSQLLocalDB; Initial Catalog = bd_agenda; Integrated Security = True; Connect Timeout = 30; Encrypt = False";
                con.Open();
                /*Monta comando DML a ser enviado para o database*/
                SqlCommand cn = new SqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "insert into tb_locais([nome],[rua],[numero],[cidade],[UF])values(@nome,@rua,@numero,@cidade,@uf)";

                /*Envia os dados a serem gravados*/
                cn.Parameters.Add("nome", System.Data.SqlDbType.VarChar).Value = local.Nome;
                cn.Parameters.Add("rua", System.Data.SqlDbType.VarChar).Value = local.Rua;
                cn.Parameters.Add("numero", System.Data.SqlDbType.VarChar).Value = local.Numero;
                cn.Parameters.Add("cidade", System.Data.SqlDbType.VarChar).Value = local.Cidade;
                cn.Parameters.Add("UF", System.Data.SqlDbType.VarChar).Value = local.UF;


                /**Abrir a conexão*/
                cn.Connection = con;

                /*Executa a conexão*/
                return cn.ExecuteNonQuery() > 0;


            }
            /*  Console.WriteLine($"Salvando {contato.Nome}");*/
            return true;
        }
    }
}



    

                
