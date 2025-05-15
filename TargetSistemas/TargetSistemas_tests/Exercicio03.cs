using Exercicio03.Services;
using Exercicio03.Entities;

namespace TargetSistemas_tests
{
    public class Exercicio03
    {
        List<FaturamentoDiarioEntity> faturamentoJson = new List<FaturamentoDiarioEntity>()
        {
            new FaturamentoDiarioEntity{dia = 01, valor = 0},
            new FaturamentoDiarioEntity{dia = 02, valor = 200.50},
            new FaturamentoDiarioEntity{dia = 03, valor = 1000.75},
            new FaturamentoDiarioEntity{dia = 04, valor = 500.50},
            new FaturamentoDiarioEntity{dia = 05, valor = 0.00}
        };

        [Fact]
        public void TestarValorMenorValor()
        {
            // Arrange
            FaturamentoDiarioService service = new FaturamentoDiarioService();
            FaturamentoDiarioEntity menorValor = new FaturamentoDiarioEntity();

            // Act
            menorValor = service.GetMenorValor(faturamentoJson);

            // Assert
            Assert.Equal(200.50, menorValor.valor);
        }

        [Fact]
        public void TestarDiaMenorValor()
        {
            // Arrange
            FaturamentoDiarioService service = new FaturamentoDiarioService();
            FaturamentoDiarioEntity menorValor = new FaturamentoDiarioEntity();

            // Act
            menorValor = service.GetMenorValor(faturamentoJson);

            // Assert
            Assert.Equal(02, menorValor.dia);
        }

        [Fact]
        public void TestarValorMaiorValor()
        {
            // Arrange
            FaturamentoDiarioService service = new FaturamentoDiarioService();
            FaturamentoDiarioEntity maiorValor = new FaturamentoDiarioEntity();

            // Act
            maiorValor = service.GetMaiorValor(faturamentoJson);

            // Assert
            Assert.Equal(1000.75, maiorValor.valor);
        }

        [Fact]
        public void TestarDiaMaiorValor()
        {
            // Arrange
            FaturamentoDiarioService service = new FaturamentoDiarioService();
            FaturamentoDiarioEntity maiorValor = new FaturamentoDiarioEntity();

            // Act
            maiorValor = service.GetMaiorValor(faturamentoJson);

            // Assert
            Assert.Equal(03, maiorValor.dia);
        }

        [Fact]
        public void TestarGetDiasValidos() 
        {
            // Arrange
            FaturamentoDiarioService service = new FaturamentoDiarioService();
            int diasValidos = 0;

            // Act
            diasValidos = service.GetDiasValidos(faturamentoJson);

            // Assert
            Assert.Equal(3, diasValidos);        
        }

        [Fact]
        public void TestarGetMediaMensal()
        {
            // Arrange
            FaturamentoDiarioService service = new FaturamentoDiarioService();
            double mediaMensal = 0;
            double mediaMensalEsperada = 567.25;

            // Act
            mediaMensal = service.GetMediaMensal(3, faturamentoJson);

            // Assert
            Assert.Equal(mediaMensal, mediaMensalEsperada);
        }

        [Fact]
        public void TestarGetFaturamentoAcimaDaMedia()
        {
            // Arrange
            FaturamentoDiarioService service = new FaturamentoDiarioService();

            // Act
            var listaFaturamentos = service.GetFaturamentosAcimaDaMedia(567.25, faturamentoJson);

            // Assert
            Assert.Collection(listaFaturamentos,
                item => {
                    Assert.Equal(03, item.dia);
                    Assert.Equal(1000.75, item.valor);
                }
             );
        }

    }
 }
