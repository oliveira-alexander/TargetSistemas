using Exercicio02.Services;

namespace Exercicio02
{
    internal class Program
    {
        /*
         2) Dado a sequência de Fibonacci, onde se inicia por 0 e 1 e o próximo valor sempre será a soma dos 2 valores anteriores 
            (exemplo: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34...),
            escreva um programa na linguagem que desejar onde, informado um número, ele calcule a sequência de Fibonacci e retorne uma 
            mensagem avisando se o número informado pertence ou não a sequência.

         IMPORTANTE: Esse número pode ser informado através de qualquer entrada de sua preferência ou pode ser previamente definido no código;

         */
        static void Main(string[] args)
        {
            int numeroInformado = 986;

            CalcularFibonacciService service = new CalcularFibonacciService(numeroInformado);
            service.CalcularSequenciaFibonacci();

            // Escrevendo a sequência de fibonacci até o número informado
            foreach (var numeroSequencia in service.SequenciaFibonacci)
            {
                Console.Write($" {numeroSequencia} ,");
            }

            Console.WriteLine();
            
            // Respondendo à pergunta
            if (service.GetSeNumeroPertenceASequencia())
                Console.WriteLine($"O número {numeroInformado} está na sequência de Fibonacci.");
            else
                Console.WriteLine($"O número {numeroInformado} não está na sequência de Fibonacci.");
        }
    }
}
