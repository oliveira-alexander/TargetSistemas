using Exercicio01;
using Exercicio01.Services;

namespace TargetSistemas_tests
{
    public class Exercicio01
    {
        [Fact]
        public void TestarSomaComIndice10()
        {
            // Arrange
            int indice = 10;
            int k = 0;
            int soma = 0;
            SomarService service = new SomarService();

            // Act
            soma = service.SomarComIndice(indice, k);

            // Assert
            Assert.Equal(55, soma);

        }

        [Fact]
        public void TestarSomaComIndice13()
        {
            // Arrange
            int indice = 13;
            int k = 0;
            int soma = 0;
            SomarService service = new SomarService();

            // Act
            soma = service.SomarComIndice(indice, k);

            // Assert
            Assert.Equal(91, soma);

        }
    }
}