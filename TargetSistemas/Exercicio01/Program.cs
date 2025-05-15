using Exercicio01.Services;

namespace Exercicio01
{
    public class Program
    {
        /*
         1) Observe o trecho de código abaixo: 
                int INDICE = 13, SOMA = 0, K = 0;
                Enquanto K < INDICE faça
                         { K = K + 1; 
                           SOMA = SOMA + K; 
                          }
                Imprimir(SOMA);
            Ao final do processamento, qual será o valor da variável SOMA?

            Resposta: 91

            K / Soma:
            1 / 1
            2 / 3
            3 / 6
            4 / 10
            5 / 15
            6 / 21
            7 / 28
            8 / 36
            9 / 45
            10 / 55
            11 / 66
            12 / 78
            13 / 91
         */
        static void Main(string[] args)
        {
            int indice = 13;
            int soma = 0;
            int k = 0;

            SomarService service = new SomarService();
            soma = service.SomarComIndice(indice, k);

            Console.WriteLine(soma);
        }
    }
}
