using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControla {
    class EstruturaSwith {
        public static void Executar() {
            Console.WriteLine("Avalie meu atendimento  com uma nota de 1 a 5:");
            int.TryParse(Console.ReadLine(), out int nota);

            switch (nota) {
                case 0:
                    Console.WriteLine("Pessimo");
                    break;
                case 1:
                case 2:
                    Console.WriteLine("Ruim");
                    break;
                case 3:
                    Console.WriteLine("Regular");
                    break;
                case 4:
                    Console.WriteLine("Bom");
                    break;
                case 5:
                    Console.WriteLine("Ótimo");
                    break;
                default:
                    Console.WriteLine("Nota Invalida");
                    break;
            }

            Console.WriteLine("Obrigado por responder!");
        }
    }
}
