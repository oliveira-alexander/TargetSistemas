using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio04.Services
{
    public class CalcularFaturamentoService
    {
        public double CalcularPercentualFaturamento(double faturamentoCapital, double faturamentoTotal)
        {
            return ((faturamentoCapital / faturamentoTotal) * 100);
        }
    }
}
