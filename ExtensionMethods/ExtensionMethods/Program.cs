using ExtensionMethods.Extensions;
using System;

namespace ExtensionMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime dt = new DateTime(2020, 08, 16, 8, 10, 45);
            Console.WriteLine(dt.TempoDecorrido());

            string s1 = "Bom dia querido estudante.";
            Console.WriteLine(s1.Cut(12));
        }
    }
}
