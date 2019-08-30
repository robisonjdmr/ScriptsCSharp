using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class Conversoes {
        public static void Executar() {

            //conversão inplicita, não ah perta de infomações pelo o tamanho do tipo da variavel
            int inteiro = 10;
            double quebrado;
            quebrado = inteiro;

            Console.WriteLine(quebrado);

            //Conversão explicita, quando ah perigo de perca de informação pelo o tamanho do tipo da varialvel

            double nota = 9.7;
            int notaTruncada = (int)nota;
            Console.WriteLine("Nota truncada {0}", notaTruncada);

            //conversão de string para inteiro

            Console.WriteLine("Digite sua idade: ");
            string idadeString = Console.ReadLine();
            int idadeinteira = int.Parse(idadeString);
            Console.WriteLine("Idade inserida: {0}", idadeString);

            idadeinteira = Convert.ToInt32(idadeString);
            Console.WriteLine("Resultado: {0}", idadeinteira);

            //forma mais segura de converter String para Inteiro

            Console.Write("digite um numero: ");
            string palavra = Console.ReadLine();
            int numero1;
            int.TryParse(palavra, out numero1);
            Console.WriteLine("Resuldo: {0}", numero1);

            Console.Write("digite o segundo numero: ");
            int.TryParse(Console.ReadLine(), out int numero2);
            Console.WriteLine("Resuldo: {0}", numero2);
        }
    }
    
}
