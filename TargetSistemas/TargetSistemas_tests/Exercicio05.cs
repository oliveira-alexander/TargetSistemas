using Exercicio05;
using Exercicio05.Services;

namespace TargetSistemas_tests
{
    public class Exercicio05
    {
        [Fact]
        public void TestarInversaoDeTexto()
        {
            // Arrange
            string textoOriginal = "Hello, Target Sistemas!";
            string textoInvertido = "";
            ManipularStringService service = new ManipularStringService();

            // Act
            textoInvertido = service.InverterTexto(textoOriginal);

            // Assert
            Assert.Equal("!sametsiS tegraT ,olleH", textoInvertido);
        }
    
    }
}
