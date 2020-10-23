using System;
using System.Collections.Generic;

namespace Clientes
{
    public class Cliente
    {

        private string nome;
        private string endereco;
        private int idade;



        public List<Cliente> listaCliente = new List<Cliente>();

        public string Nome {get;set;}
        
        public string Endereco
        {
            get { return endereco; }
            set { endereco = value; }
        }
        public int Idade
        {
            get { return idade; }
            set
            {
                if (value > 0)
                    idade = value;
            }
        }

        public Cliente(string nome, string endereco, int idade)
        {
            this.nome = nome;
            this.endereco = endereco;
            this.idade = idade;


        }

        public Cliente()
        {
            
        }


        public void MostraDados()
        {
            if (listaCliente.Count != 0)
            {
                for (int i = 0; i < listaCliente.Count; i++)
                {
                    Console.WriteLine("Nome : " + listaCliente[i].nome);
                    Console.WriteLine("Endereco : " + listaCliente[i].endereco);
                    Console.WriteLine("Idade : " + listaCliente[i].idade);
                }
            }

            /*
            Console.WriteLine("Nome : " + nome);
            Console.WriteLine("Endereco : " + endereco);
            Console.WriteLine("Idade : " + idade);
            */
        }
    }
}