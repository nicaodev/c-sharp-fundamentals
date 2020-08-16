using Interface.Entities;
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
            DateTime start = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            Console.WriteLine("Entre com a data e horário de DEVOLUÇÃO do carro:  ");
            DateTime finish = DateTime.ParseExact(Console.ReadLine(), "dd/MM/yyyy hh:mm", CultureInfo.InvariantCulture);

            CarRental carRental = new CarRental(start, finish, new Vehicle(model));
        }
    }
}