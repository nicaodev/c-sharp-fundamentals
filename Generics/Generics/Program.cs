using Generics.Entities;
using Generics.Services;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.ExceptionServices;
using System.Security.Principal;

namespace Generics
{
    class Program
    {

        Process[] cmdAberto = Process.GetProcessesByName("cmd");
        Boolean controle = false;

            foreach (var item in cmdAberto)
            {
                controle = item.MainWindowTitle == "ng" ? true : controle;
            }
            if (!controle)
                System.Diagnostics.Process.Start(@"cmd.exe", @"/k cd D:\Users\est11396\Documents\TFS\New\SisRe\SisReWeb & ng serve");


        static void Main(string[] args)
        {
            Console.WriteLine("Escolha a opcao desejada: ");
            Console.WriteLine("First: 1 ");
            Console.WriteLine("Max: 2");
            int opcao = int.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1:
                    MetodoFirst();
                    break;
                case 2:
                    MetodoMax();
                    break;

                default:
                    Console.WriteLine("Opção inválida");
                    break;
            }
        }

        private static void MetodoMax()
        {
            List<Product> list = new List<Product>();

            Console.Write("Quantos elementos: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string[] vect = Console.ReadLine().Split(',');
                string name = vect[0];
                double price = double.Parse(vect[1], CultureInfo.InvariantCulture);

                list.Add(new Product(name, price));
            }

            CalculationService cs = new CalculationService();
            Product max = cs.Max(list);

            Console.Write("Max: ");
            Console.WriteLine(max);
        }

        private static void MetodoFirst()
        {
            PrintService<int> ps = new PrintService<int>(); // Tipo 'T' int, pode mudar nas chamadas dinamicamente.
            //PrintService<string> printService2 = new PrintService<string>();

            Console.Write("Quantos valores você vai digitar: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                int x = int.Parse(Console.ReadLine());
                ps.AddValue(x);
            }

            ps.Print();
            Console.WriteLine("First: " + ps.First());
        }
    }
}
