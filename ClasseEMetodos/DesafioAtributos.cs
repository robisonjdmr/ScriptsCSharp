using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    class DesafioAtributos {

        int a = 10;


       
        public static void Executar() {
            // Acessar a variavel 'a ' dentro do metodo Executar!

            DesafioAtributos desafio = new DesafioAtributos();
            Console.WriteLine(desafio.a);
        }
    }
}
