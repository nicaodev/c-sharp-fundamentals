using Interface.Entities;
using Interface.Services;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Globalization;

namespace Interface
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("Entre com os dados do aluguel: ");
            Console.WriteLine("Modelo do Carro: ");
            string model = Console.ReadLine();
            Console.WriteLine("Entre com a data e horário de retirada do carro:  ");
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com a data e horário de DEVOLUÇÃO do carro:  ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy HH:ss", CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor por hora:  ");
            double hour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Console.WriteLine("Digite o valor por dia:  ");
            double day = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));

            RentalService rentalService = new RentalService(hour, day, new BrazilTaxService());

            rentalService.ProcessInvoce(carRental);

            Console.WriteLine("INVOCE: ");
            Console.WriteLine(carRental.Invoice);
        }
    }
}