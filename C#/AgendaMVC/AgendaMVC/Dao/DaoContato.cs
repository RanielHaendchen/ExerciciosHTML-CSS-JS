using AgendaMVC.Interfaces;
using AgendaMVC.Models;
using System.Data;
using System.Data.SqlClient;
using Microsoft.AspNetCore.Hosting.Server;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AgendaMVC.Dao
{
    public class DaoContato : ICrud<Contato>
    {

                private readonly string conexao = "Server=localhost;Database=agendamvc;Uid=root;Pwd=123456;";

        public bool alterar(Contato contato)
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                MySqlCommand cn = new MySqlCommand();
                cn.CommandType = CommandType.Text;
                cn.CommandText = "UPDATE tb_contatos SET nome=@nome, email=@email, telefone=@telefone WHERE id=@id";

                cn.Parameters.Add("nome", MySqlDbType.VarChar).Value = contato.Nome;
                cn.Parameters.Add("email", MySqlDbType.VarChar).Value = contato.Email;
                cn.Parameters.Add("telefone", MySqlDbType.VarChar).Value = contato.Telefone;
                cn.Parameters.Add("id", MySqlDbType.Int32).Value = contato.Id;

                

                cn.Connection = con;
                return cn.ExecuteNonQuery() > 0;
            }
            throw new NotImplementedException();
        }

        public Contato Consultar(int id)
        {
            Contato ct = new Contato();

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_contatos WHERE id = @id", con))
                {
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        if (dr.Read())
                        {
                            ct.Id = Convert.ToInt32(dr["id"]);
                            ct.Nome = Convert.ToString(dr["nome"]);
                            ct.Email = Convert.ToString(dr["email"]);
                            ct.Telefone = Convert.ToString(dr["telefone"]);
                        }
                    }
                }
            }

            return ct;
            throw new NotImplementedException();
        }

        public List<Contato> Consultar()
        {
            List<Contato> contatos = new List<Contato>();

            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand("SELECT * FROM tb_contatos", con))
                {
                    using (MySqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            Contato ct = new Contato();
                            ct.Id = Convert.ToInt32(dr["id"]);
                            ct.Nome = Convert.ToString(dr["nome"]);
                            ct.Email = Convert.ToString(dr["email"]);
                            ct.Telefone = Convert.ToString(dr["telefone"]);
                            contatos.Add(ct);
                        }
                    }
                }
            }

            return contatos;
            throw new NotImplementedException();
        }

        public void excluir(int id)
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                using (MySqlCommand cmd = new MySqlCommand("DELETE FROM tb_contatos WHERE id = @id", con))
                {
                    cmd.Parameters.Add("@id", MySqlDbType.Int32).Value = id;

                    cmd.ExecuteNonQuery();
                }
            }

            throw new NotImplementedException();
        }

        public bool salvar(Contato contato)
        {
            using (MySqlConnection con = new MySqlConnection(conexao))
            {
                con.Open();

                MySqlCommand cmd = new MySqlCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO tb_contatos(nome, email, telefone) VALUES(@nome, @email, @telefone)";

                cmd.Parameters.Add("@nome", MySqlDbType.VarChar).Value = contato.Nome;
                cmd.Parameters.Add("@email", MySqlDbType.VarChar).Value = contato.Email;
                cmd.Parameters.Add("@telefone", MySqlDbType.VarChar).Value = contato.Telefone;

                cmd.Connection = con;
                return cmd.ExecuteNonQuery() > 0;
            }
        }
    }
}
    
