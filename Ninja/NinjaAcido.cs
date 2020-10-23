using System;

namespace Ninja
{
    public class NinjaAcido : Ninja
    {
          public void LancarAcido( int tempoAcido)
        {
            Console.WriteLine("Paralisado por: " + tempoAcido + " segundos.");
        }
    }
}