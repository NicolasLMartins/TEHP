using FigurasAbstract.Entities.Enum;

namespace FigurasAbstract.Entities
{
    abstract class Figura
    {
        public Cor Cor { get; set; }

        public Figura(Cor cor)
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}
