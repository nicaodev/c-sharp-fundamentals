namespace Interface.Entities
{
    internal class Vehicle
    {
        public string Modelo { get; set; }

        public Vehicle(string modelo)
        {
            Modelo = modelo;
        }
    }
}