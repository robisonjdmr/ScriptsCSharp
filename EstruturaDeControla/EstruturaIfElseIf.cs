using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControla {
    class EstruturaIfElseIf {
        public static void Executar() {
            Console.Write("Digite a Nota do Aluno: ");

            string entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            if(nota < 0 || nota > 10.0) {
                Console.WriteLine("Nota Invalida!");
            }else if(nota >= 8.0) {
                Console.WriteLine("Aluno no quadro de honra!");
            }else if(nota >= 7.0) {
                Console.WriteLine("Aluno Aprovado!");
            }else if(nota >= 5.0) {
                Console.WriteLine("aluno em Recuperação!");
            }else {
                Console.WriteLine("Aluno Reprovado! Te vejo no proximo ano!");
            }

            Console.WriteLine("FIM!!!");
        }
    }
}
