using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio01.Services
{
    public class SomarService
    {
        public int SomarComIndice(int indice, int k)
        {
            var soma = 0;

            while (k < indice)
            {
                k++;
                soma += k;
            }

            return soma;
        }
    }
}
