using System.Globalization;

namespace ProjetoAulasPOO
{
    class Retangulo
    {
        public double Largura;
        public double Altura;

        public double CalculoArea()
        {
            return Largura * Altura;
        }

        public double CalculoPerimetro()
        {
            return (Largura * 2) + (Altura * 2);
        }

        public double CalculoDiagonal()
        {
            double d = Math.Sqrt(Math.Pow(Largura, 2) + Math.Pow(Altura, 2));
            return d;
        }

        public override string ToString()
        {
            return CalculoArea().ToString("F2", CultureInfo.InvariantCulture)
                + "Perímetro = "
                + CalculoPerimetro().ToString("F2", CultureInfo.InvariantCulture)
                + "Diagonal = "
                + CalculoDiagonal().ToString("F2", CultureInfo.InvariantCulture);

        }
    }
}
