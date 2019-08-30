using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresRelacionais {
        public static void Executar() {
            double nota = 6.0;
            double notaDeCorte = 7.0;

            Console.WriteLine("Nota invalida? {0}", nota > 10.0);
            Console.WriteLine("Nota invalida? {0}", nota < 0.0);
            Console.WriteLine("Pefeito? {0}", nota == 10.0);
            Console.WriteLine("Tem como melhorar? {0}", nota != 10.0);
            Console.WriteLine("Passou por mediar? {0}", nota >= notaDeCorte);
            Console.WriteLine("Recupeção? {0}", nota < notaDeCorte);
            Console.WriteLine("Reprovado? {0}", nota <= 3.0);
            
        }
    }
}
