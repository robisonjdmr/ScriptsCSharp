using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class Array {

        public static void Executar() {
            string[] alunos = new string[5];
            alunos[0] = "Bruno";
            alunos[1] = "Gustavo";
            alunos[2] = "Emerson";
            alunos[3] = "Bia";
            alunos[4] = "Luana";

            foreach (var aluno in alunos) {
                Console.WriteLine(aluno);
            }

            double somatorio = 0;
            double[] notas = { 9.7, 4.8,8.4, 8.2, 6.8 };

            foreach(var nota in notas) {// este e dorma padrão para utilizar o Array
                somatorio += nota;
            
            }
            //Utilizando o for também funciona como o foreach acima
            //for(int i = 0; i < notas.Length; i++) {
            //    somatorio += notas[i];
            //}

            double media = somatorio / notas.Length;
            Console.WriteLine(media);

            char[] letras = { 'A', 'r', 'r', 'a', 'y' };
            string palavra = new string(letras);
            Console.WriteLine(palavra);

        }
    }
}
