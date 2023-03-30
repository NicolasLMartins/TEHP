using ExercicioEmpregadoPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace ExercicioEmpregadoPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Empregado> lista = new List<Empregado>();

            Console.Write("Digite o número de empregados: ");
            int num = int.Parse(Console.ReadLine());

            for (int i = 1; i <= num; i++)
            {
                Console.WriteLine($"Dados do empregado #{i}: ");
                Console.Write("Terceirizados? ");
                char resp = char.Parse(Console.ReadLine());

                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Horas: ");
                int horas = int.Parse(Console.ReadLine());
                Console.Write("Valor por hora: ");
                double valorPorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (resp == 's' || resp == 'S')
                {
                    Console.Write("Despesa adicional: ");
                    double despesaAdicional = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new EmpregadoTerceirizado(nome, horas, valorPorHora, despesaAdicional));
                }
                else
                {
                    lista.Add(new Empregado(nome, horas, valorPorHora));
                }
            }
            Console.WriteLine("\nPagamentos: ");

            foreach (Empregado emp in lista)
            {
                Console.WriteLine($"{emp.Nome} - $ {emp.Pagamento().ToString("F2", CultureInfo.InvariantCulture)}");
            }
        }
    }
}
