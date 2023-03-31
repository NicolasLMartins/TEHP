using EstoqueHerancaEPolimorfismo.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EstoqueHerancaEPolimorfismo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Produto> lista = new List<Produto>();

            Console.Write("Digite a quantidade de produtos: ");
            int quantProd = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantProd; i++)
            {
                Console.WriteLine($"Informações do produto #{i} ");
                Console.Write("Comum, usado ou importado? (c/u/i) ");
                char tipoProd = char.Parse(Console.ReadLine());
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                switch (tipoProd)
                {
                    case 'u':
                        Console.Write("Data de fabricação: ");
                        DateTime dataDeFabricacao = DateTime.Parse(Console.ReadLine());

                        lista.Add(new ProdutoUsado(nome, preco, dataDeFabricacao));
                        break;

                    case 'i':
                        Console.Write("Frete: ");
                        double frete = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        lista.Add(new ProdutoImportado(nome, preco, frete));
                        break;

                    case 'c':
                        lista.Add(new Produto(nome, preco));
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Etiquetas de preço: ");

            foreach (Produto prod in lista)
            {
                Console.WriteLine(prod.Etiqueta());
            }

            Console.ReadKey();
        }
    }
}
