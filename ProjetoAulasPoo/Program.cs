using ProjetoAulasPOO;
using System.Globalization;

namespace Application
{
    public class Program
    {
        static void Main(string[] args)
        {
            Produto a;

            a = new Produto();

            Console.WriteLine("Entre com os dados do Produto: ");
            Console.WriteLine("Nome: ");
            a.NomeProduto = Console.ReadLine();
            Console.WriteLine("Preço: ");
            a.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.WriteLine("Quantidade no estoque: ");
            a.QuantidadeEstoque = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Dados do produto: " + a);

            Console.WriteLine();
            Console.WriteLine("Digite o número a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.AtualizarQuantidadeEstoque(qte);
            Console.WriteLine("Dados Atualizados: " + a);

            Console.WriteLine();
            Console.WriteLine("Digite o número de produtos a ser removido do estoque: ");
            qte = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            a.RemoverQuantidadeEstoque(qte);
            Console.WriteLine("Dados Atualizados: " + a);
        }
        /* static void Main(string[] args)
        {
            Pessoa a, b;

            a = new Pessoa();
            b = new Pessoa();

            Console.WriteLine("Digite o nome e idade da primeira pessoa");
            a.Nome = Console.ReadLine();
            a.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o nome e idade da segunda pessoa");
            b.Nome = Console.ReadLine();
            b.Idade = int.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            if (a.Idade > b.Idade)
            {
                Console.WriteLine("Pessoa mais velha: " + a.Nome);
            }
            else
            {
                Console.WriteLine("Pessoa mais velha: " + b.Nome);
            }

        } */

        /* static void Main(string[] args)
        {
            Triangulo x, y;

            x = new Triangulo();
            y = new Triangulo();

            Console.WriteLine("Entre com as medidas do triângulo X");
            x.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            x.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com as medidas do triângulo Y");
            y.A = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.B = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            y.C = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            double areaX = x.Area();
            double areaY = y.Area();

            Console.WriteLine("Área de x = " + areaX.ToString("F4", CultureInfo.InvariantCulture));
            Console.WriteLine("Área de y = " + areaY.ToString("F4", CultureInfo.InvariantCulture));

            if (areaX > areaY)
            {
                Console.WriteLine("Área de x é maior");
            }
            else
            {
                Console.WriteLine("Área de y é maior");
            }

        } */
    }
}