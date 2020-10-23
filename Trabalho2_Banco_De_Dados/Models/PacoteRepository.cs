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
    public class PacoteRepository : Repository
    {
        private string strConn = "Database=agenciaviagem; Data Source=localhost; User Id=root;";
        public void Cadastra(Pacote p)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();
            string sql = "INSERT INTO Pacote (NomePacote, OrigemPacote, DestinoPacote, Atrativos, Saida, Retorno, IdUser) VALUES (@NomePacote, @OrigemPacote, @DestinoPacote, @Atrativos, @Saida, @Retorno, @IdUser) ";
            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@NomePacote", p.NomePacote);
            comando.Parameters.AddWithValue("@OrigemPacote", p.OrigemPacote);
            comando.Parameters.AddWithValue("@DestinoPacote", p.DestinoPacote);
            comando.Parameters.AddWithValue("@Atrativos", p.Atrativos);
            comando.Parameters.AddWithValue("@Saida ", p.Saida);
            comando.Parameters.AddWithValue("@Retorno ", p.Retorno);
            comando.Parameters.AddWithValue("@IdUser ", p.IdUser);


            comando.ExecuteNonQuery();

            conexao.Close();


        }

        public void Atualiza(Pacote p)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);

            conexao.Open();

            string sql = "UPDATE Pacote SET NomePacote = @NomePacote, OrigemPacote=@OrigemPacote, DestinoPacote=@DestinoPacote, Atrativos=@Atrativos, Saida=@Saida,  Retorno=@Retorno, IdUser=@IdUser WHERE IdPacote = @IdPacote";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@NomePacote", p.NomePacote);
            comando.Parameters.AddWithValue("@OrigemPacote", p.OrigemPacote);
            comando.Parameters.AddWithValue("@DestinoPacote", p.DestinoPacote);
            comando.Parameters.AddWithValue("@Atrativos", p.Atrativos);
            comando.Parameters.AddWithValue("@Saida ", p.Saida);
            comando.Parameters.AddWithValue("@Retorno ", p.Retorno);
            comando.Parameters.AddWithValue("@IdUser ", p.IdUser);
            comando.Parameters.AddWithValue("@IdPacote ", p.IdPacote);

            comando.ExecuteNonQuery();

            conexao.Close();


        }

        public List<Pacote> ListaPacotes()
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();

            string sql = "SELECT*FROM Pacote";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            MySqlDataReader resultadoConsulta = comando.ExecuteReader();
            List<Pacote> lista = new List<Pacote>();

            while (resultadoConsulta.Read())
            {
                Pacote novoPacote = new Pacote();
                novoPacote.IdPacote = resultadoConsulta.GetInt32("IdPacote");
                novoPacote.NomePacote = resultadoConsulta.GetString("NomePacote");
                novoPacote.OrigemPacote = resultadoConsulta.GetString("OrigemPacote");
                novoPacote.DestinoPacote = resultadoConsulta.GetString("DestinoPacote");
                novoPacote.Atrativos = resultadoConsulta.GetString("Atrativos");
                novoPacote.Saida = resultadoConsulta.GetString("Saida");
                novoPacote.Retorno = resultadoConsulta.GetString("Retorno");
                novoPacote.IdUser = resultadoConsulta.GetInt32("IdUser");
                


                lista.Add(novoPacote);
            }


            conexao.Close();

            return lista;

        }

        public void Delete(Pacote p)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);

            conexao.Open();

            string sql = "DELETE FROM Pacote WHERE IdPacote = @IdPacote";

            MySqlCommand comando = new MySqlCommand(sql, conexao);
            comando.Parameters.AddWithValue("@IdPacote", p.IdPacote);

            comando.ExecuteNonQuery();

            conexao.Close();


        }



        public Pacote ListaPorId(int id)
        {
            MySqlConnection conexao = new MySqlConnection(strConn);
            conexao.Open();

            string sql = "SELECT*FROM Pacote WHERE IdPacote = @IdPacote";

            MySqlCommand comando = new MySqlCommand(sql, conexao);

            comando.Parameters.AddWithValue("@IdPacote", id);

            MySqlDataReader leitor = comando.ExecuteReader();

            Pacote objetoPacote = null;

            if (leitor.Read())
            {

                objetoPacote = new Pacote();
                objetoPacote.IdPacote = leitor.GetInt32("IdPacote");
                objetoPacote.NomePacote = leitor.GetString("NomePacote");
                objetoPacote.OrigemPacote = leitor.GetString("OrigemPacote");
                objetoPacote.DestinoPacote = leitor.GetString("DestinoPacote");
                objetoPacote.Atrativos = leitor.GetString("Atrativos");
                objetoPacote.Saida = leitor.GetString("Saida");
                objetoPacote.Retorno = leitor.GetString("Retorno");
                objetoPacote.IdUser = leitor.GetInt32("IdUser");


            }

            conexao.Close();

            return objetoPacote;


        }
    }
}