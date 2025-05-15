using Exercicio02.Services;

namespace TargetSistemas_tests
{
    public class Exercicio02
    {
        [Fact]
        public void TestarSequenciaFibonacciFalse() 
        {
            // Arrange
            int numeroInformado = 376;
            bool numeroPertenceASequencia = false;
            CalcularFibonacciService service = new CalcularFibonacciService(numeroInformado);

            // Act
            service.CalcularSequenciaFibonacci();
            numeroPertenceASequencia = service.GetSeNumeroPertenceASequencia();

            // Assert
            Assert.False(numeroPertenceASequencia);
        }

        [Fact]
        public void TestarSequenciaFibonacciTrue()
        {
            // Arrange
            int numeroInformado = 987;
            bool numeroPertenceASequencia = false;
            CalcularFibonacciService service = new CalcularFibonacciService(numeroInformado);

            // Act
            service.CalcularSequenciaFibonacci();
            numeroPertenceASequencia = service.GetSeNumeroPertenceASequencia();

            // Assert
            Assert.True(numeroPertenceASequencia);
        }

    }
}
