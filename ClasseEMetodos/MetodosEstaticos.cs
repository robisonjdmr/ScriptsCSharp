using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    class CalculadoraEstatica {

        //metodo por classe. Acesso o construtor pela classe direta
        public static int Multiplicar(int a, int b) {
            return a * b;
        }

        //metodo de instancia. Acesso pela instancia, ou seja tenho que chamar a classe criar uma identificaçao e depois estanciar
        //Ex: CalculadoraEstatica calc = new CalculadoraEstatica();
        public int Somar(int a , int b) {
            return a + b;
        }
    }
    class MetodosEstaticos {

        public static void Executar() {
            var resultado = CalculadoraEstatica.Multiplicar(2, 2);
            Console.WriteLine("Resultado: {0}", resultado);

            CalculadoraEstatica calc = new CalculadoraEstatica();
            Console.WriteLine(calc.Somar(2, 2));
        }
    }
}
