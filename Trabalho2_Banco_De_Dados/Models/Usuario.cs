namespace Trabalho2_Banco_De_Dados.Models
{
    public class Usuario
    {
        public int IdUser { get; set; }
        public string NomeUser { get; set; }    
        public string DataNasc { get; set; }
        public string LogIn { get; set; }
        public string Senha { get; set; }
        public bool Tipo { get; set; }
    }
}