using System;

namespace Ninja
{
    public class NinjaGelo : Ninja
    {
       
      public void NinjaGeloNome()
      {
          NinjaGelo umNinjaGelo = new NinjaGelo();
          umNinjaGelo.altura = 1.82;
          Console.WriteLine("Altura: " + umNinjaGelo.altura);
      }

        
        public void Congelar( int tempoCongelamento)
        {

            Console.WriteLine("Congelado por: " + tempoCongelamento + " segundos.");
        }
    }
}