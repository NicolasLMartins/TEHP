using FigurasAbstract.Entities;
using FigurasAbstract.Entities.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace FigurasAbstract
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Figura> lista = new List<Figura>();

            Console.Write("Digite a quantidade de figuras: ");
            int quantFig = int.Parse(Console.ReadLine());

            for (int i = 1; i <= quantFig; i++)
            {
                Console.WriteLine($"Figura #{i} ");
                Console.Write("Retângulo ou círculo (r/c)? ");
                char tipoFig = char.Parse(Console.ReadLine());
                Console.Write("Cor (Preto/Azul/Vermelho): ");
                Cor cor = (Cor)Enum.Parse(typeof(Cor), Console.ReadLine()); //Converte explicitamente uma string em um enumerador do tipo "Cor"

                switch (tipoFig)
                {
                    case 'r':
                        Console.Write("Largura: ");
                        double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        Console.Write("Altura: ");
                        double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        lista.Add(new Retangulo(largura, altura, cor));
                        break;

                    case 'c':
                        Console.Write("Raio: ");
                        double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                        lista.Add(new Circulo(raio, cor));
                        break;
                }
            }

            Console.WriteLine();
            Console.WriteLine("Áreas das figuras: ");

            foreach (Figura figura in lista)
            {
                Console.WriteLine(figura.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
