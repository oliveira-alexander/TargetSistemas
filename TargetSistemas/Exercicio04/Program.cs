using Exercicio04.Services;

namespace Exercicio04
{
    internal class Program
    {
        /*
         4) Dado o valor de faturamento mensal de uma distribuidora, detalhado por estado:
                    • SP – R$67.836,43
                    • RJ – R$36.678,66
                    • MG – R$29.229,88
                    • ES – R$27.165,48
                    • Outros – R$19.849,53

                Escreva um programa na linguagem que desejar onde calcule o percentual de representação que cada estado teve dentro do valor total mensal da distribuidora.  

         */
        static void Main(string[] args)
        {
            double faturamentoSP = 67836.43;
            double faturamentoRJ = 36678.66;
            double faturamentoMG = 29229.88;
            double faturamentoES = 27175.48;
            double faturamentoOutros = 19849.53;

            double faturamentoTotal = faturamentoSP + faturamentoRJ + faturamentoMG + faturamentoES + faturamentoOutros;

            CalcularFaturamentoService service = new CalcularFaturamentoService();

            Console.WriteLine($"Faturamento total: R${faturamentoTotal.ToString("F2")}");
            Console.WriteLine();
            Console.WriteLine($"Faturamento SP - R${faturamentoSP.ToString("F2")} - Percentual: {service.CalcularPercentualFaturamento(faturamentoSP, faturamentoTotal).ToString("F4")}%");
            Console.WriteLine($"Faturamento RJ - R${faturamentoRJ.ToString("F2")} - Percentual: {service.CalcularPercentualFaturamento(faturamentoRJ, faturamentoTotal).ToString("F4")}%");
            Console.WriteLine($"Faturamento MG - R${faturamentoMG.ToString("F2")} - Percentual: {service.CalcularPercentualFaturamento(faturamentoMG, faturamentoTotal).ToString("F4")}%");
            Console.WriteLine($"Faturamento ES - R${faturamentoES.ToString("F2")} - Percentual: {service.CalcularPercentualFaturamento(faturamentoES, faturamentoTotal).ToString("F4")}%");
            Console.WriteLine($"Faturamento Outros - R${faturamentoOutros.ToString("F2")} - Percentual: {service.CalcularPercentualFaturamento(faturamentoOutros, faturamentoTotal).ToString("F4")}%");
        }
    }
}
