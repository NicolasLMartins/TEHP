using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contribuintes.Entities
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
            if (NumeroFuncionarios >= 25)
            {
                return (RendaAnual * 0.14);
            }
            else
            { 
                return RendaAnual * 0.16;
            }
        }
    }
}
