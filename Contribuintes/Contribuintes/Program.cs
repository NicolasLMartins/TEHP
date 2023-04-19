using Contribuintes.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Contribuintes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Pessoa> lista = new List<Pessoa>();
            
            Console.Write("Digite o número de contribuintes: ");
            int numContr = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numContr; i++)
            {
                Console.WriteLine($"Contribuinte #{i}: ");
                Console.Write("Pessoa física ou jurídica (Física/Jurídica)? ");
                TipoPessoa tipoPessoa = (TipoPessoa)Enum.Parse(typeof(TipoPessoa), Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                int j = (int)tipoPessoa;

                if (j < 4)
                {
                    Console.Write("Gastos com saúde: ");
                    double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    lista.Add(new PessoaFisica(nome, rendaAnual, gastosSaude));
                }
                else if (j < 8)
                {
                    Console.Write("Número de empregados: ");
                    int numFunc = int.Parse(Console.ReadLine());
                    lista.Add(new PessoaJuridica(nome, rendaAnual, numFunc));
                }
            }

            Console.WriteLine();
            Console.WriteLine("Impostos pagos: ");
            foreach (Pessoa item in lista)
            {
                Console.WriteLine(item);
            }
        }
    }
}
