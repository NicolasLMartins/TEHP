using FigurasAbstract.Entities.Enum;

namespace FigurasAbstract.Entities
{
    class Retangulo : Figura
    {
        private double Largura { get; set; }
        private double Altura { get; set; }

        public Retangulo(double largura, double altura, Cor cor) : base(cor)
        {
            Largura = largura;
            Altura = altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
