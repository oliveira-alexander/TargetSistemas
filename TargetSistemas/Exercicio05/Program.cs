namespace Exercicio05
{
    internal class Program
    {
        /*
         5) Escreva um programa que inverta os caracteres de um string.

            IMPORTANTE:
            a) Essa string pode ser informada através de qualquer entrada de sua preferência ou pode ser previamente definida no código;
            b) Evite usar funções prontas, como, por exemplo, reverse;
         */
        static void Main(string[] args)
        {
            string original = "Hello, Target Sistemas!";
            string invertida = string.Empty;

            for (var i = original.Count(); i > 0 ; i--)
            {
                invertida += original[i-1];
            }

            Console.WriteLine($"String original: {original}");
            Console.WriteLine($"String invertida: {invertida}");
        }
    }
}
