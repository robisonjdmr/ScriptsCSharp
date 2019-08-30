using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Inferencia {
        public static void Executar() {
            var nome = "Leonardo";
            //nome = 123;
            Console.WriteLine(nome);

            // int idade;
            var idade = 32;
            Console.WriteLine(idade);

            int a;
            a = 3;

            int b = 2;

            Console.WriteLine(a + b);
            // quando for deito uma inferencia no c# a variavel tem que ser iniciada
        }
    }
}
