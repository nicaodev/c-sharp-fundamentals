
using Interface.Entities;
using Interface.Services.Interface;
using System;
using System.Reflection.Metadata.Ecma335;

namespace Interface.Services
{
    class RentalService
    {
        public double PricePerHour { get; private set; }
        public double PricePerDay { get; private set; }

        private ITaxService _taxService; // inversao de controle por meio de injeção de dependencia.

        public RentalService(double pricePerHour, double pricePerDay, ITaxService taxService) // inversao de controle por meio de injeção de dependencia.
        {
            PricePerHour = pricePerHour;
            PricePerDay = pricePerDay;
            _taxService = taxService;
        }

        public void ProcessInvoce(CarRental carRental)
        {
            TimeSpan duration = carRental.Finish.Subtract(carRental.Start);

            double basicPayment = 0.0;
            double tax = 0.0;

            if (duration.TotalHours <= 12.0)
                basicPayment = PricePerHour * Math.Ceiling(duration.TotalHours); // Arrendonda para cima.
            else
                basicPayment = PricePerDay * Math.Ceiling(duration.TotalDays);

            tax = _taxService.Tax(basicPayment);

            carRental.Invoice = new Invoice(basicPayment, tax);


        }
    }
}
