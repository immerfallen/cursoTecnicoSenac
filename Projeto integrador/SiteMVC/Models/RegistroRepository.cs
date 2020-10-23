using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SiteMVC.Models
{
    public class RegistroRepository
    {
        private string strConn = "Database=coffeeme; Data Source=localhost; User Id=root;";
        public void Cadastra(Registro r)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();
            string sql = "INSERT INTO registro (nome, email, senha) VALUES (@nome, @email, @senha) ";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", r.Nome);
            comando.Parameters.AddWithValue("@email", r.EMail);
            comando.Parameters.AddWithValue("@senha", r.Senha);
            

            comando.ExecuteNonQuery();

            conexao.Close();

        }

        public Registro QueryLogin(Registro r)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();
            string sql = "SELECT * FROM registro WHERE email = @email AND senha = @senha";
            MySqlCommand comandoQuery = new MySqlCommand(sql, conexao);
            comandoQuery.Parameters.AddWithValue("@email", r.EMail);
            comandoQuery.Parameters.AddWithValue("@senha", r.Senha);
            MySqlDataReader reader = comandoQuery.ExecuteReader();
            Registro rg = null;
            if (reader.Read())
            {
               rg = new Registro();
                rg.IdRegistro = reader.GetInt32("id");               

                if (!reader.IsDBNull(reader.GetOrdinal("email")))
                    rg.EMail = reader.GetString("email");
                if (!reader.IsDBNull(reader.GetOrdinal("senha")))
                    rg.Senha = reader.GetString("senha");
            }

            conexao.Close();
            return rg;
        }
    }
}