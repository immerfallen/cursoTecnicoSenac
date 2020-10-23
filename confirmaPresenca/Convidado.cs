using System.Collections.Generic;
using System;
namespace confirmaPresenca
{
    public class Convidado
    {

        
        private bool confirmaPresenca;


        public string Nome { get; set; }
        public int Idade { get; set; }
        public int Telefone { get; set; }

        public bool ConfirmaPresenca
        {
            get { return confirmaPresenca; }
            set { confirmaPresenca = value; }
        }
        public Convidado(string nome, int idade, int telefone, bool presenca)
        {
            this.Nome = nome;
            this.Idade = idade;
            this.Telefone = telefone;
            this.ConfirmaPresenca = presenca;
        }

        public Convidado()
        {
        }
    }
}