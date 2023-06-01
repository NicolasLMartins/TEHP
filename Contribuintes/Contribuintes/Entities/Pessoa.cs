using System.Globalization;

namespace Contribuintes.Entities
{
    abstract class Pessoa
    {

        public string Nome { get; set; }
        public double RendaAnual { get; set; }

        protected Pessoa(string nome, double rendaAnual)
        {
            Nome = nome;
            RendaAnual = rendaAnual;
        }

        public abstract double Imposto();
        public override string ToString()
        {
            return $"{Nome}: $ {Imposto().ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}