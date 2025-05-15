using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio05.Services
{
    public class ManipularStringService
    {
        public string InverterTexto(string texto)
        {
            string textoInvertido = string.Empty;

            for (var i = texto.Count(); i > 0; i--)
            {
                textoInvertido += texto[i - 1];
            }

            return textoInvertido;
        }
    }
}
