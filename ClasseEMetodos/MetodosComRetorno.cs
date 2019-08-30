using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    class CalculadoraComum {
        public int Somar(int a, int b) {
            return a + b;
        }
        public int Subtrair(int a, int b) {
            return a - b;
        }
        public int Mutlplicacao(int a, int b) {
            return a * b;
        }
    }

    class CalculadoraCadeia {
        int memoria;

        public CalculadoraCadeia Somar(int a) {
            memoria += a;
            return this;
        }
        public CalculadoraCadeia Multiplicacao(int a) {
            memoria *= a;
            return this;
        }
        public CalculadoraCadeia Limpar() {
            memoria = 0;
            return this;
        }
        public CalculadoraCadeia imprimir() {
            Console.WriteLine(memoria);
            return this;
        }
        public int Resultado() {
            return memoria;
        }
    }
    class MetodosComRetorno {
        public static void Executar() {
            var calculadoraComum = new CalculadoraComum();
            var resultado = calculadoraComum.Somar(5, 5);

            Console.WriteLine(resultado);
            Console.WriteLine(calculadoraComum.Subtrair(2, 7));
            Console.WriteLine(calculadoraComum.Mutlplicacao(10, 3));

            var calculadoraCadeia = new CalculadoraCadeia();
            calculadoraCadeia.Somar(3).Multiplicacao(3).imprimir().Limpar().imprimir();

            resultado = calculadoraCadeia.Somar(3).Multiplicacao(3).Resultado();
            Console.WriteLine(resultado);

        }
    }
}
