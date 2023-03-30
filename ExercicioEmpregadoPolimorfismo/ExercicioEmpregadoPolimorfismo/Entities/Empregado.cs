using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioEmpregadoPolimorfismo.Entities
{
    class Empregado
    {
        public string Nome { get; set; }
        public int Horas { get; set; }
        public double ValorPorHora { get; set; }

        public Empregado()
        {
        }

        public Empregado(string nome, int horas, double valorPorHora)
        {
            Nome = nome;
            Horas = horas;
            ValorPorHora = valorPorHora;
        }

        public virtual double Pagamento()
        {
            return Horas * ValorPorHora;
        }
    }
}
