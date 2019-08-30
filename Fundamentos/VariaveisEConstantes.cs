using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class VariaveisEConstantes {
        public static void Executar() {
            // area da circuferencia
            double Raio = 4.5;
            const double PI = 3.14;

            Raio = 5.5;
            //PI = 3.1415;

            double area = PI * Raio * Raio;
            Console.WriteLine(area);
            Console.WriteLine("Area é " + area);

            // Tipos internos

            bool estaChovendo = true;

            Console.WriteLine("Esta Chovendo " + estaChovendo);

            byte idade = 45;
            Console.WriteLine("Idade " + idade);

            sbyte saldoDeGols = sbyte.MinValue;
            Console.WriteLine("Saldo de Gols " + saldoDeGols);

            short salario = short.MaxValue;
            Console.WriteLine("Salario " + salario);

            int menorValorint = int.MinValue; // mais usados dos inteiros
            Console.WriteLine("Menor int " + menorValorint);

            uint populacaoBrasileira = 207_600_000;
            Console.WriteLine("População Brasileira " + populacaoBrasileira);

            long menorValorLong = long.MinValue;
            Console.WriteLine("Menor long " + menorValorLong);

            ulong populacaoMundial = 7_600_000_000;
            Console.WriteLine("População Mundial " + populacaoMundial);

            float precoComputador = 1299.99f;
            Console.WriteLine("Preço Computador " + precoComputador);

            double valorDeMercadoDaapple = 1_000_000_000_000.00;
            Console.WriteLine("Valor de Marcado da Apple " + valorDeMercadoDaapple);

            decimal distanciaEntreEstrela = decimal.MaxValue;
            Console.WriteLine("Distancia Entre Estrelas " + distanciaEntreEstrela);

            char letra = 'b';
            Console.WriteLine("Letra " + letra);

            string texto = "texto";
            Console.WriteLine(texto);

        }
    }
}
