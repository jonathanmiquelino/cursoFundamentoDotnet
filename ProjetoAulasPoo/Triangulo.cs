namespace ProjetoAulasPOO
{
    class Triangulo
    {
        public double A;
        public double B;
        public double C;

        public double Area()
        {
            double p = (A + B + C) / 2.0;
            //calculo da area de x
            return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
        }
    }
}