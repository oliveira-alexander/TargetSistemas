using Exercicio03.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio03.Services
{
    public class FaturamentoDiarioService
    {
        public FaturamentoDiarioEntity GetMenorValor(List<FaturamentoDiarioEntity> faturamentoDiario)
        {
            var menorFaturamento = faturamentoDiario.Where(item => item.valor > 0)
                                     .OrderBy(item => item.valor)
                                     .First();

            return menorFaturamento;
        }

        public FaturamentoDiarioEntity GetMaiorValor(List<FaturamentoDiarioEntity> faturamentoDiario)
        {
            var maiorValor = faturamentoDiario.OrderByDescending(item => item.valor).First();
            return maiorValor;
        }

        public int GetDiasValidos(List<FaturamentoDiarioEntity> faturamentoDiario)
        { 
            return faturamentoDiario.Count(dias => dias.valor > 0);
        }

        public double GetMediaMensal(int diasValidos, List<FaturamentoDiarioEntity> faturamentoDiario)
        { 
            return faturamentoDiario.Sum(item => item.valor) / diasValidos;
        }

        public IEnumerable<FaturamentoDiarioEntity> GetFaturamentosAcimaDaMedia(double mediaMensal, List<FaturamentoDiarioEntity> faturamentoDiario)
        { 
            var faturamentosAcimaDaMedia = faturamentoDiario.Where(item => item.valor > mediaMensal)
                                              .OrderBy(item => item.dia);

            return faturamentosAcimaDaMedia;
        }
    }
}
