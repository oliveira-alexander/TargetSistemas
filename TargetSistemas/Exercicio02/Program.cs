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
            List<int> sequenciaFibonacci = new List<int>();
            int numeroInformado = 986;

            CalcularFibonacciAteNumeroInformado(sequenciaFibonacci, numeroInformado);

            // Escrevendo a sequência de fibonacci até o número informado
            foreach (var numeroSequencia in sequenciaFibonacci)
            {
                Console.Write($" {numeroSequencia} ,");
            }

            Console.WriteLine();

            // Verificando se existe na lista
            bool numeroNaSequenciaFibonacci = sequenciaFibonacci.Contains(numeroInformado);
            
            // Respondendo à pergunta
            if (numeroNaSequenciaFibonacci)
                Console.WriteLine($"O número {numeroInformado} está na sequência de Fibonacci.");
            else
                Console.WriteLine($"O número {numeroInformado} não está na sequência de Fibonacci.");
        }

        private static void CalcularFibonacciAteNumeroInformado(List<int> sequenciaFibonacci, int numeroInformado)
        {
            sequenciaFibonacci.Add(0);
            sequenciaFibonacci.Add(1);
            sequenciaFibonacci.Add(1);

            while (sequenciaFibonacci.Last() < numeroInformado)
            {
                sequenciaFibonacci.Add(
                    sequenciaFibonacci[sequenciaFibonacci.Count - 1] + sequenciaFibonacci[sequenciaFibonacci.Count - 2]
                 );
            }
        }
    }
}
