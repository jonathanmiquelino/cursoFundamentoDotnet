using ProjetoAulasPOO;
using System.Globalization;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Exercicio1();

        }

        private static void Exercicio1()
        {
            Retangulo r;
            r = new Retangulo();

            Console.WriteLine("Entre com a largura e altura do retangulo: ");
            r.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            r.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            r.CalculoArea();

            Console.WriteLine("Area = " + r);
        }
    }
}