namespace Contribuintes.Entities
{
    class PessoaFisica : Pessoa
    {
        private double GastosSaude { get; set; }

        public PessoaFisica(string nome, double rendaAnual, double gastosSaude) : base(nome, rendaAnual)
        {
            GastosSaude = gastosSaude; 
        }

        public override double Imposto()
        {
            if (RendaAnual > 20000.00)
            {
                return (RendaAnual * 0.25) - (GastosSaude * 0.5);
            }
            else
            {
                return (RendaAnual * 0.15) - (GastosSaude * 0.5);
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
