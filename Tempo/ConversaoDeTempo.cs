using System;
using System.Collections.Generic;
using System.Text;

namespace Tempo
{
    class ConversaoDeTempo
    {
        public int SegundosInformado { get; set; }
        public int Hora { get; set; }
        public int Minutos { get; set; }
        public int Segundo { get; set; }
        public int Resta { get; set; }
        
        public ConversaoDeTempo (int segundosInformado)
        {
            SegundosInformado = segundosInformado;
        }
        public void Calculo()
        {
            Hora = SegundosInformado / 3600;
            Resta = SegundosInformado % 3600;
            Minutos = Resta / 60;
            Segundo = Resta % 60;
            Console.WriteLine(Hora + ":" + Minutos + ":" + Segundo);
        }
    }
}
