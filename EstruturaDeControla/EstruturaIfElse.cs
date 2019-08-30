using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControla {
    class EstruturaIfElse {
        public static void Executar() {
            double nota;

            Console.Write("Digite o a nota do aluno: ");
            nota = double.Parse(Console.ReadLine());

            if(nota >= 7.0) {
                Console.WriteLine("Aprovado!");
                Console.WriteLine("Não fez mais que a obrigação...");
            } else {
                Console.WriteLine("Reprovado!");
            }
        }
    }
}
