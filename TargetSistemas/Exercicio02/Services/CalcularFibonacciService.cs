using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio02.Services
{
    public class CalcularFibonacciService
    {
        public readonly int NumeroInformado = 0;
        public readonly List<int> SequenciaFibonacci;
        
        public CalcularFibonacciService(int numeroInformado)
        {
            this.NumeroInformado = numeroInformado;
            this.SequenciaFibonacci = new List<int>();
        }

        public void CalcularSequenciaFibonacci() 
        {
            this.SequenciaFibonacci.Add(0);
            this.SequenciaFibonacci.Add(1);
            this.SequenciaFibonacci.Add(1);

            while (this.SequenciaFibonacci.Last() < this.NumeroInformado)
            {
                this.SequenciaFibonacci.Add(
                    this.SequenciaFibonacci[this.SequenciaFibonacci.Count - 1] + this.SequenciaFibonacci[this.SequenciaFibonacci.Count - 2]
                 );
            }

        }
        public bool GetSeNumeroPertenceASequencia()
        {
            if (SequenciaFibonacci.Contains(NumeroInformado))
                return true;
            else
                return false;
        }
    }
}
