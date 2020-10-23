using MySql.Data.MySqlClient;
using System.Collections.Generic;
using System;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Trabalho2_Banco_De_Dados.Models;

namespace Trabalho2_Banco_De_Dados.Models
{
    public class UsuarioRespository : Repository
    {
        private string strConn = "Database=agenciaviagem; Data Source=localhost; User Id=root;";
        public void Cadastra(Usuario u)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();
            string sql = "INSERT INTO Usuario (NomeUser, DataNasc, LogIn, Senha, Tipo) VALUES (@NomeUser, @DataNasc, @LogIn, @Senha, @Tipo) ";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@NomeUser", u.NomeUser);
            comando.Parameters.AddWithValue("@DataNasc", u.DataNasc);
            comando.Parameters.AddWithValue("@LogIn", u.LogIn);
            comando.Parameters.AddWithValue("@Senha", u.Senha);
            comando.Parameters.AddWithValue("@Tipo ", u.Tipo);

            comando.ExecuteNonQuery();

            conexao.Close();


        }

        public List<Usuario> ListaUsuarios()
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();

            string sql = "SELECT*FROM Usuario";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            MySqlDataReader resultadoConsulta = comando.ExecuteReader();
            List<Usuario> lista = new List<Usuario>();

            while (resultadoConsulta.Read())
            {
                Usuario novoUsuario = new Usuario();
                novoUsuario.IdUser = resultadoConsulta.GetInt32("IdUser");
                novoUsuario.NomeUser = resultadoConsulta.GetString("NomeUser");
                novoUsuario.DataNasc = resultadoConsulta.GetString("DataNasc");
                novoUsuario.LogIn = resultadoConsulta.GetString("LogIn");
                novoUsuario.Senha = resultadoConsulta.GetString("Senha");
                novoUsuario.Tipo = resultadoConsulta.GetBoolean("Tipo");
               


                lista.Add(novoUsuario);
            }


            conexao.Close();

            return lista;

        }

        public void Delete(Usuario u)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);

            conexao.Open();

            string sql = "DELETE FROM usuario WHERE iduser = @IdUser";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@IdUser", u.IdUser);

            comando.ExecuteNonQuery();

            conexao.Close();


        }

        public void Atualiza(Usuario u)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);

            conexao.Open();

            string sql = "UPDATE Usuario SET NomeUser = @NomeUser, DataNasc=@DataNasc, LogIn=@LogIn, Senha=@Senha, Tipo=@Tipo WHERE IdUser = @IdUser";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@NomeUser", u.NomeUser);
            comando.Parameters.AddWithValue("@DataNasc", u.DataNasc);
            comando.Parameters.AddWithValue("@LogIn", u.LogIn);
            comando.Parameters.AddWithValue("@Senha", u.Senha);
            comando.Parameters.AddWithValue("@Tipo", u.Tipo);
            comando.Parameters.AddWithValue("@IdUser", u.IdUser);

            comando.ExecuteNonQuery();

            conexao.Close();


        }

        public Usuario ListaPorId(int id)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();

            string sql = "SELECT*FROM Usuario WHERE IdUser = @IdUser";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@IdUser", id);

            MySqlDataReader leitor = comando.ExecuteReader();

            Usuario objetoUsuario = null;

            if (leitor.Read())
            {
                objetoUsuario = new Usuario();
                objetoUsuario.IdUser = leitor.GetInt32("IdUser");
                objetoUsuario.NomeUser = leitor.GetString("NomeUser");
                objetoUsuario.DataNasc = leitor.GetString("DataNasc");
                objetoUsuario.LogIn = leitor.GetString("LogIn");
                objetoUsuario.Senha = leitor.GetString("Senha");
                objetoUsuario.Tipo = leitor.GetBoolean("Tipo");


            }

            conexao.Close();

            return objetoUsuario;

        }

        public Usuario QueryLogin(Usuario u)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();
            string sql = "SELECT * FROM Usuario WHERE login = @Login AND senha = @Senha";
            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
            comandoQuery.Parameters.AddWithValue("@Login", u.LogIn);
            comandoQuery.Parameters.AddWithValue("@Senha", u.Senha);
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            Usuario usr = null;
            if (reader.Read())
            {
                usr = new Usuario();
                usr.IdUser = reader.GetInt32("IdUser");
                if (!reader.IsDBNull(reader.GetOrdinal("NomeUser")))
                    usr.NomeUser = reader.GetString("NomeUser");

                if (!reader.IsDBNull(reader.GetOrdinal("LogIn")))
                    usr.LogIn = reader.GetString("Login");
                if (!reader.IsDBNull(reader.GetOrdinal("Senha")))
                    usr.Senha = reader.GetString("Senha");
            }

            conexao.Close();
            return usr;
        }
    }
}