using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControla {
    class EstrturaFor {
        public static void Executar() {
            //exemplo basico    

            //for(int i = 1; i <= 10; i++) {
            //    Console.WriteLine($"O valor de 1 é {i}.");
            //    i += 2;
            //}

            //Exercicio

            double somatorio = 0;
            string entrada;

            Console.Write("Informe o tamando da turma: ");
            entrada = Console.ReadLine();
            int.TryParse(entrada, out int tamanhoTurma);

            for(int i = 1; i<=tamanhoTurma; i++) {
                Console.Write("Informe a nota do aluno {0}: ", i);
                entrada = Console.ReadLine();
                double.TryParse(entrada, out double notaAtual);

                somatorio += notaAtual;
            }
            double media = tamanhoTurma > 0 ? somatorio / tamanhoTurma : 0;
            Console.WriteLine("Media da turma {0}: ", media);
        }
    }
}
