using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControla {
    class EstruturaWhile {
        public static void Executar() {
            int palpite = 0;

            Random random = new Random();

            int numeroSecreto = random.Next(1, 16);
            bool numeroEncontrado = false;
            int tentativaRestante = 5;
            int tentativas = 0;

            while (tentativaRestante > 0 && !numeroEncontrado) {
                Console.Write("Insira o seu palpite: ");
                string entrada = Console.ReadLine();
                int.TryParse(entrada, out palpite);

                tentativas++;
                tentativaRestante--;
                if (numeroSecreto == palpite) {
                    numeroEncontrado = true;
                    var corAnterior = Console.BackgroundColor;
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.WriteLine("Numero encontrado em {0} tentativas", tentativas);
                    Console.BackgroundColor = corAnterior;
                } else if (palpite > numeroSecreto) {
                    Console.WriteLine("Menor... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativaRestante);
                } else {
                    Console.WriteLine("Maior... Tente novamente!");
                    Console.WriteLine("Tentativas restantes: {0}", tentativaRestante);
                }
            }
        }
    }
}
