namespace ExercicioEmpregadoPolimorfismo.Entities
{
    class EmpregadoTerceirizado : Empregado
    {
        public double DespesaAdicional { get; set; }

        public EmpregadoTerceirizado()
        {
        }

        public EmpregadoTerceirizado(string nome, int horas, double valorPorHora, double despesaAdicional) : base(nome, horas, valorPorHora)
        {
            DespesaAdicional = despesaAdicional;
        }

        public override double Pagamento()
        {
            return base.Pagamento() + (1.1 * DespesaAdicional);
        }
    }
}
