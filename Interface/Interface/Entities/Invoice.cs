using System.Globalization;

namespace Interface.Entities
{
    internal class Invoice
    {
        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public Invoice(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double PagamentoTotal
        {
            get { return PagamentoBasico + Taxa; }
        }

        public override string ToString()
        {
            return @$"Pagamento básico: {PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)}
            Taxa: {Taxa.ToString("F2", CultureInfo.InvariantCulture)}
            Pagamento total: {PagamentoTotal.ToString("F2", CultureInfo.InvariantCulture)}";
        }
    }
}