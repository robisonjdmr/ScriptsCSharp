﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class Params {
        public static void Recepcionar(params string[] pessoas) {
            foreach(var pessoa in pessoas){
                Console.WriteLine("Ola {0}", pessoa);
            }
        }

        public static void Executar() {
            Recepcionar("Pedro", "Manu", "Roger", "Ana", "Rita");

        }
    }
}
