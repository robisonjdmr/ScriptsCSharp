﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Fundamentos {
    class NotacaoPonto {
        public static void Executar() {
            var saudacao = "ola".ToUpper().Insert(3, " World!")
                .Replace("World", "Mundo");

            Console.WriteLine(saudacao);

            Console.WriteLine("teste"?.Length);// O sinal de interrogação é uma forma segura de usar a função Length para variavei com valor NUll (nulo)

            //nill
            string valorImportante = null;
            Console.WriteLine(valorImportante?.Length);
        }
    }
}
