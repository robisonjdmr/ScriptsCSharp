using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {
    class Pessoa {
        public string Nome;
        public int Idade;

        public string Apresentar() {
            return string.Format(
                $"Ola! ME chamo {Nome} e tenho {Idade} anos.");
        }

        public void ApresentarNoConsole() {
            Console.WriteLine(Apresentar());
        }
    }
}
