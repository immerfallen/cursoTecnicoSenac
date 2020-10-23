using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;

namespace CadProdutos
{
    public class ProdutoRepository
    {
        private const string enderecoConexao = "Database=admprodutos;Data Source=localhost;User Id=root;";
        public Produto Insert()
        {


            string enderecoConexao = "Database=admprodutos;Data Source=localhost;User Id=root;";
            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            Produto produto = new Produto();
            produto.Nome = Console.ReadLine();
            produto.Fabricante = Console.ReadLine();
            produto.Preco = decimal.Parse(Console.ReadLine());
            produto.Disponivel = bool.Parse(Console.ReadLine());
           
            string sqlInsert = "INSERT INTO produto (nome, fabricante, preco, dataCadastro, disponivel) " + "VALUES ('" + produto.Nome + "','" + produto.Fabricante + "','" + produto.Preco + "', NOW(), 1)";
            MySqlCommand comando = new MySqlCommand(sqlInsert, conexao);
            comando.ExecuteNonQuery();
            conexao.Close();

            return produto;



        }
        public List<Produto> Query()
        {

            MySqlConnection conexao = new MySqlConnection(enderecoConexao);
            conexao.Open();

            string sqlSelect = "SELECT*FROM produto";
            MySqlCommand comandoQuery = new MySqlCommand(sqlSelect, conexao);
            MySqlDataReader resultado = comandoQuery.ExecuteReader();

            List<Produto> listaProdutos = new List<Produto>();

            while (resultado.Read())
            {
                Produto item = new Produto();
                item.Id = resultado.GetInt32("Id");
                item.Nome = resultado.GetString("Nome");
                item.Fabricante = resultado.GetString("Fabricante");
                item.Preco = resultado.GetDecimal("preco");
                item.Disponivel = resultado.GetBoolean("disponivel");
                item.DataCadastro = resultado.GetDateTime("dataCadastro");

                listaProdutos.Add(item);
            }


            resultado.Close();
            conexao.Close();

            return listaProdutos;

        }
    }
}