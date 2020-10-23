using MySql.Data.MySqlClient;
using System.Collections.Generic;

namespace ProjetoDB.Models
{
    public class Repository
    {
        private string strConn = "Database=sistemarh; Data Source=localhost; User Id=root;";

        public void Cadastra(Setor s)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();
            string sql = "INSERT INTO Setor (Nome) VALUES (@nome) ";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", s.Nome);

            comando.ExecuteNonQuery();

            conexao.Close();


        }

        public List<Setor> ListaSetores()
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();

            string sql = "SELECT*FROM Setor";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            MySqlDataReader resultadoConsulta = comando.ExecuteReader();
            List<Setor> lista = new List<Setor>();

            while (resultadoConsulta.Read())
            {
                Setor novoSetor = new Setor();
                novoSetor.Id = resultadoConsulta.GetInt32("Id");
                if (!resultadoConsulta.IsDBNull(resultadoConsulta.GetOrdinal("Nome")))
                {
                    novoSetor.Nome = resultadoConsulta.GetString("Nome");
                }

                lista.Add(novoSetor);
            }


            conexao.Close();

            return lista;

        }

        public Setor ListaPorId(int id)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();

            string sql = "SELECT*FROM Setor WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@id", id);

            MySqlDataReader leitor = comando.ExecuteReader();

            Setor objetoSetor = null;

            if (leitor.Read())
            {
                objetoSetor = new Setor();
                objetoSetor.Id = leitor.GetInt32("Id");
                objetoSetor.Nome = leitor.GetString("Nome");
                if (leitor.IsDBNull(leitor.GetOrdinal("Nome")))
                {
                    objetoSetor.Nome = leitor.GetString("Nome");
                }

            }

            conexao.Close();

            return objetoSetor;


        }

        public void Atualiza(Setor s)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);

            conexao.Open();

            string sql = "UPDATE Setor SET Nome = @nome WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@nome", s.Nome);
            comando.Parameters.AddWithValue("@id", s.Id);

            comando.ExecuteNonQuery();

            conexao.Close();


        }

        public void Delete(Setor s)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);

            conexao.Open();

            string sql = "DELETE FROM setor WHERE id = @id";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@id", s.Id);

            comando.ExecuteNonQuery();

            conexao.Close();


        }


    }
}