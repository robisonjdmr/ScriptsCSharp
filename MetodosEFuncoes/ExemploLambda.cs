using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.MetodosEFuncoes {
    class ExemploLambda {
        public static void Executar() {
            Action algoNoConsole = () => {
                Console.WriteLine("Lambida com C#!");
            };
            algoNoConsole();

            Func<int> jogarDado = () => {
                Random randon = new Random();
                return randon.Next(1, 7);
            };
            Console.WriteLine(jogarDado());

            Func<int, string> conversor = numero => numero.ToString("X");
            Console.WriteLine(conversor(1234));

            Func<int, int, int, string> formatarData = (dia, mes, ano) => string.Format("{0:D2}/{1:D2}/{2:D4}", dia, mes, ano);
            Console.WriteLine(formatarData(07, 02, 2019));
        }
    }
}
