using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class OperadoresAritmeticos {
        public static void Executar() {
            // preço desconto

            var preco = 1000.0;
            var imposto = 355;
            var desconto = 0.1;

            double total = preco + imposto;
            var totalComDesconto = total - total * desconto;

            Console.WriteLine("O Preço final é: {0}", totalComDesconto);

            //IMC

            Console.Write("Digite seu peso: ");
            double peso = double.Parse(Console.ReadLine());
            Console.Write("Digite sua Altura: ");
            double altura = double.Parse(Console.ReadLine());
            double imc = peso / Math.Pow(altura, 2);

            Console.WriteLine($"Seu IMC é de: {imc}.");

            // Numero par e Impra

            int par = 24;
            int impar = 55;
            Console.WriteLine("{0}/2 tem resto [1}", par, par % 2);
            Console.WriteLine("{0}/2 tem resto {1}", impar, impar % 2);
        }
    }
}
