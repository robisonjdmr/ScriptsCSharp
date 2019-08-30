using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControla {
    class EstrturaDoWhile {
        public static void Executar() {
            string entrada;

            do {
                Console.WriteLine("Qual o seu o nome?");
                entrada = Console.ReadLine();

                Console.WriteLine("Seja bem_vindo {0}", entrada);
                Console.WriteLine("Deseja continuar?(S/N)");
                entrada = Console.ReadLine();
            } while (entrada.ToLower() == "s");
        }
    }
}
