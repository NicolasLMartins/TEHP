using System.Globalization;

namespace EstoqueHerancaEPolimorfismo.Entities
{
    class Produto
    {
        protected string Nome { get; set; }
        protected double Preco { get; set; }

        public Produto(string nome, double preco)
        {
            Nome = nome;
            Preco = preco;
        }

        public virtual string Etiqueta()
        {
            return $"{Nome} $ {Preco.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}
