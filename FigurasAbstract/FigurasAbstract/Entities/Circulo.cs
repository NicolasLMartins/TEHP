using FigurasAbstract.Entities.Enum;
using System;

namespace FigurasAbstract.Entities
{
    class Circulo : Figura
    {
        private double Raio { get; set; }

        public Circulo(double raio, Cor cor) : base(cor)
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(Raio, 2);
        }
    }
}
