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
                string tipoPessoa = Console.ReadLine();
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Renda anual: ");
                double rendaAnual = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (tipoPessoa)
                {
                    case "Física":
                        Console.Write("Gastos com saúde: ");
                        double gastosSaude = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                        break;

                    case "Jurídica":
                        Console.Write("Número de empregados: ");
                        int numEmpre = int.Parse(Console.ReadLine());
                        break;
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
