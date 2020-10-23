namespace Area
{
    public class Area
    {
        public double largura;
        public double altura;

        public double AreaTotal()
        {
            return largura * altura;
        }

        public double Perimetro()
        {
            return largura * 2 + altura * 2;
        }

    }
}