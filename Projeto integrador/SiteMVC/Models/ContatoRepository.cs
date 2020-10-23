using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace SiteMVC.Models
{
    public class ContatoRepository
    {
        private string strConn = "Database=coffeeme; Data Source=localhost; User Id=root;";
        public void Cadastra(Contato c)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();
            string sql = "INSERT INTO contato (nome, email, assunto) VALUES (@nome, @email, @assunto) ";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", c.Nome);
            comando.Parameters.AddWithValue("@email", c.EMail);
            comando.Parameters.AddWithValue("@assunto", c.Assunto);
            

            comando.ExecuteNonQuery();

            conexao.Close();

        }
               
    }
}
