using EstoqueHerancaEPolimorfismo.Entities;
using EstoqueHerancaEPolimorfismo.Entities.Enum;
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
                Console.WriteLine($"\nInformações do produto #{i} ");
                Console.Write("Comum, usado ou importado? (c/u/i) ");
                TipoProduto tipoProd = (TipoProduto)Enum.Parse(typeof(TipoProduto), Console.ReadLine());
                int tipoProdInt = (int)tipoProd;

                while (tipoProdInt < 0 || tipoProdInt > 14)
                {
                    Console.Write("Valor inválido, tente novamente: ");
                }
                
                Console.Write("Nome: ");
                string nome = Console.ReadLine();
                Console.Write("Preço: ");
                double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                

                if (tipoProdInt < 5)
                {
                    lista.Add(new Produto(nome, preco));
                }
                else if (tipoProdInt < 10)
                {
                    Console.Write("Data de fabricação: ");
                    DateTime dataDeFabricacao = DateTime.Parse(Console.ReadLine());

                    lista.Add(new ProdutoUsado(nome, preco, dataDeFabricacao));

                } else if (tipoProdInt < 15)
                {
                    Console.Write("Frete: ");
                    double frete = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    lista.Add(new ProdutoImportado(nome, preco, frete));
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
