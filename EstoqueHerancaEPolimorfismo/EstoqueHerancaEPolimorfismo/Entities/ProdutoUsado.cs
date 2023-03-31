using System;
using System.Globalization;

namespace EstoqueHerancaEPolimorfismo.Entities
{
    class ProdutoUsado : Produto
    {
        private DateTime DataDeFabricacao { get; set; }

        public ProdutoUsado(string nome, double preco, DateTime dataDeFabricacao) : base(nome, preco)
        {
            DataDeFabricacao = dataDeFabricacao;
        }

        public override string Etiqueta()
        {
            return $"{Nome} (usado) $ {Preco.ToString("F2", CultureInfo.InvariantCulture)} (Data de fabricação: {DataDeFabricacao.ToShortDateString()})";
        }
    }
}
