using System.Globalization;

namespace ProjetoAulasPOO
{
    class Produto
    {
        public String NomeProduto;
        public double Preco;
        public int QuantidadeEstoque;

        public double ValorTotalEmEstoque()
        {
            return Preco * QuantidadeEstoque;
        }

        public void AtualizarQuantidadeEstoque(int quantidade)
        {
            QuantidadeEstoque += quantidade;
        }

        public void RemoverQuantidadeEstoque(int quantidade)
        {
            QuantidadeEstoque -= quantidade;
        }

        public override string ToString()
        {
            return NomeProduto
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + QuantidadeEstoque
                + " unidade, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}