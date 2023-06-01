﻿namespace Contribuintes.Entities
{
    class PessoaJuridica : Pessoa
    {
        private int NumeroFuncionarios { get; set; }

        public PessoaJuridica(string nome, double rendaAnual, int numeroFuncionarios) : base(nome, rendaAnual)
        {
            NumeroFuncionarios = numeroFuncionarios;
        }

        public override double Imposto()
        {
            if (NumeroFuncionarios > 10)
            {
                return (RendaAnual * 0.14);
            }
            else
            { 
                return RendaAnual * 0.16;
            }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
