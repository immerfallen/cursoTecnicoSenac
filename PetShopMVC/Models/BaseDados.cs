using System.Collections.Generic;

namespace PetShopMVC.Models
{
    public static class BaseDados
    {
        private static List<Cadastro> cadastros = new List<Cadastro>();

        public static void Incluir (Cadastro cadastro)
        {
            cadastros.Add(cadastro);
        }

        public static List<Cadastro> Listar()
        {
            return cadastros;
        }
        
    }
}