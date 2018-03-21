using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ValidandoIMEI
{
    class Program
    {
        private static readonly Regex RegexIMEI = new Regex(@"^[A-Za-z0-9]{15,18}$", RegexOptions.Compiled);

        static void Main(string[] args)
        {
            Console.Write(ValidarIMEI("A355873847928122"));
            Console.Read();
        }

        /// <summary>	
        /// Validando o IMEI passado pelo usuário
        /// </summary>
        /// <param name="string">IMEI para validação.</param>
        /// <returns>Verdadeiro se é um IMEI válido, caso contrário falso.</returns>
        public static bool ValidarIMEI(string _imei)
        {
            return !string.IsNullOrWhiteSpace(_imei) && RegexIMEI.IsMatch(_imei);
        }
    }
}
