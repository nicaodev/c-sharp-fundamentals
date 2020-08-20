using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExtensionMethods.Extensions
{
    /*
     * Tem que ser: Classe estática, metodo estático e o argumento 'this'. No qual faz referencia ao obj que o instancia.
     */
    static class DateTimeExtensions
    {
        public static string TempoDecorrido(this DateTime thisObj)
        {
            TimeSpan duracao = DateTime.Now.Subtract(thisObj);

            if (duracao.TotalHours < 24.0)
                return duracao.TotalHours.ToString("F1", CultureInfo.InvariantCulture) + " horas.";
            else
                return duracao.TotalDays.ToString("F1", CultureInfo.InvariantCulture) + " dias.";
        }
    }
}
