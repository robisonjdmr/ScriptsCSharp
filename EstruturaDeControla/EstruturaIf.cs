﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.EstruturaDeControla {
    class EstruturaIf {
        public static void Executar() {

            bool bomComportamento = false;
            string entrada;

            Console.Write("Digite a nota do aluno: ");
            entrada = Console.ReadLine();
            Double.TryParse(entrada, out double nota);

            Console.WriteLine("possui bom comportamento (S/N: ");
            entrada = Console.ReadLine();

            if(entrada.ToLower()== "s"){
                bomComportamento = true;
            }
            if(nota >= 9.0 && bomComportamento) {
                Console.WriteLine("Quadro de honra!");
            }
                

        }
    }
}
