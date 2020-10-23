using System;

namespace Ninja
{
    class Program
    {
        static void Main(string[] args)
        {

            NinjaGelo ninjaGelo = new NinjaGelo();
            ninjaGelo.vida = 10;
            ninjaGelo.forca = 8;
            ninjaGelo.velocidade = 9;
            ninjaGelo.Socar();
            ninjaGelo.Chutar();
            ninjaGelo.Congelar(3);
            ninjaGelo.NinjaGeloNome();
            

            NinjaAcido ninjaAcido = new NinjaAcido();
            ninjaAcido.vida = 10;
            ninjaAcido.forca = 8;
            ninjaAcido.velocidade = 9;
            ninjaAcido.Socar();
            ninjaAcido.Chutar();
            ninjaAcido.LancarAcido(7);




        }
    }
}
