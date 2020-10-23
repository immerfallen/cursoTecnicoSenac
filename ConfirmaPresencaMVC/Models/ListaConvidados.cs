using System.Collections.Generic;



namespace ConfirmaPresencaMVC.Models
{
    public class ListaConvidados
    {
        public static List<Convidado> convidados = new List<Convidado>();
        public static bool Incluir(Convidado convidado)
        {
            if (convidados.Count == 0)
            {

                convidados.Add(convidado);
                return true;
            }
            else
            {
                for (int i = 0; i < convidados.Count; i++)
                    if (convidado.Nome == convidados[i].Nome)
                    {

                        return false;
                    }

                convidados.Add(convidado);
                return true;
               
            }
        }


        public static List<Convidado> Listar()
        {
            return convidados;
        }
    }
}