using System;

namespace Tempo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite os segundos");
            var segundosInformado = int.Parse(Console.ReadLine());
            ConversaoDeTempo tempo = new ConversaoDeTempo(segundosInformado);
            tempo.Calculo();
        }
    }
}
