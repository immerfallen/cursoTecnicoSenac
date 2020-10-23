using System;
using System.Collections.Generic;

namespace confirmaPresenca
{
    public class ListaConvidados
    {

        public List<Convidado> lista = new List<Convidado>();

        public bool incluirConvidado(Convidado convidado)
        {
            {

                if (lista.Count == 0 && convidado.ConfirmaPresenca == true)
                {

                    lista.Add(convidado);
                    return true;
                }
                else
                {
                    for (int i = 0; i < lista.Count; i++)
                    {

                        if (convidado.Nome == lista[i].Nome || convidado.ConfirmaPresenca == false)
                        {

                            return false;
                        }

                    lista.Add(convidado);
                    return true;
                    }
                }



            }
            return false;
        }
        public void MostraDados()
        {
            for (int i = 0; i < lista.Count; i++)
            {
                Console.WriteLine("Nome : " + lista[i].Nome);
                Console.WriteLine("Idade : " + lista[i].Idade);
                Console.WriteLine("Telefone : " + lista[i].Telefone);
            }


        }



    }
}







