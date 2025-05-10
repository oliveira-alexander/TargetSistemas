using Exercicio03.Entities;
using System.Reflection.Metadata.Ecma335;
using System.Text.Json;

namespace Exercicio03
{
    internal class Program
    {
        /*
         3) Dado um vetor que guarda o valor de faturamento diário de uma distribuidora, faça um programa, na linguagem que desejar, que calcule e retorne:
                • O menor valor de faturamento ocorrido em um dia do mês;
                • O maior valor de faturamento ocorrido em um dia do mês;
                • Número de dias no mês em que o valor de faturamento diário foi superior à média mensal.

            IMPORTANTE:
                a) Usar o json ou xml disponível como fonte dos dados do faturamento mensal;
                b) Podem existir dias sem faturamento, como nos finais de semana e feriados. Estes dias devem ser ignorados no cálculo da média;
          */

        static void Main(string[] args)
        {
            string caminhoJson = AppContext.BaseDirectory + "dados.json"; 

            if (File.Exists(caminhoJson))
            {
                var arquivo = File.ReadAllText(caminhoJson);
                var json = JsonSerializer.Deserialize<List<FaturamentoDiarioEntity>>(arquivo);

                var menorValor = json.Where(item => item.valor > 0)
                                     .OrderBy(item => item.valor)
                                     .First();

                var maiorValor = json.OrderByDescending(item => item.valor).First();

                var diasValidos = json.Count(dias => dias.valor > 0);
                var mediaMensal = json.Sum(item => item.valor) / diasValidos;


                var valoresAcimaDaMedia = json.Where(item => item.valor > mediaMensal)
                                              .OrderBy(item => item.dia);


                Console.WriteLine("Menor Valor:");
                Console.WriteLine($"Dia {menorValor.dia} - R${menorValor.valor.ToString("F2")}");

                Console.WriteLine();
                Console.WriteLine("Maior Valor:");
                Console.WriteLine($"Dia {maiorValor.dia} - R${maiorValor.valor.ToString("F2")}");

                Console.WriteLine();
                Console.WriteLine($"Dias em que o faturamento foi acima da média (R${mediaMensal.ToString("F2")}):");
                foreach (var item in valoresAcimaDaMedia)
                {
                    Console.WriteLine($"Dia {item.dia} - R${item.valor.ToString("F2")}");
                }
            }
            else
            {
                Console.WriteLine("Arquivo dados.json não encontrado na pasta do executável!");
                Console.WriteLine("Adicione o arquivo dados.json na pasta em que se encontra o executável e tente novamente!");
            }
        }
    }

}
