namespace Trabalho2_Banco_De_Dados.Models
{
    public class Pacote
    {
        public int IdPacote { get; set; }
        public string NomePacote { get; set; }
        public string OrigemPacote { get; set; }
        public string DestinoPacote { get; set; }
        public string Atrativos { get; set; }
        public string Saida { get; set; }
        public string Retorno { get; set; }
        public int IdUser { get; set; }

        public Usuario usuario { get; set; }

    }
}