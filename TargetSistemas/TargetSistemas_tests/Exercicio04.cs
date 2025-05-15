using Exercicio04.Services;

namespace TargetSistemas_tests
{
    public class Exercicio04
    {
        [Fact]
        public void TestarCalculoPercentualFaturamento()
        {
            // Arrange
            double faturamentoSP = 67836.43;
            double faturamentoRJ = 36678.66;
            double faturamentoMG = 29229.88;
            double faturamentoES = 27175.48;
            double faturamentoOutros = 19849.53;

            double faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

            double percentual = 0;
            double percentualEsperado = 37.526380209811379;
            CalcularFaturamentoService service = new CalcularFaturamentoService();

            // Act
            percentual = service.CalcularPercentualFaturamento(faturamentoSP, faturamentoTotal);

            // Assert
            Assert.Equal(percentual, percentualEsperado);
        }
    }
}
