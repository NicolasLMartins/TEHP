using System.Globalization;

namespace EstoqueHerancaEPolimorfismo.Entities
{
    class ProdutoImportado : Produto
    {
        private double Frete { get; set; }

        public ProdutoImportado(string nome, double preco, double frete) : base(nome, preco)
        {
            Frete = frete;
        }

        public double PrecoTotal()
        {
            return Preco + Frete;
        }

        public override string Etiqueta()
        {
            return $"{Nome} $ {PrecoTotal().ToString("F2", CultureInfo.InvariantCulture)} (Frete: $ {Frete.ToString("F2", CultureInfo.InvariantCulture)})";
        }
    }
}
