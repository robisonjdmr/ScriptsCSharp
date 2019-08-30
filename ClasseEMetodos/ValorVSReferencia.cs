using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos 
 {

    public class Dependente 
    {
        public string Nome;
        public int Idade;
    }

    class ValorVSReferencia {
        public static void Executar() {
            int numero = 3;
            int copiaNumerp = numero;

            Console.WriteLine($"{numero} {copiaNumerp}");

            numero++;
            Console.WriteLine($"{numero} {copiaNumerp}");

            Dependente dep = new Dependente {
                Nome = "Beto",
                Idade = 20
            };
            Dependente copiaDep = dep;
            Console.WriteLine($"{dep.Nome} {copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade} {copiaDep.Idade}");

            copiaDep.Nome = "Renato";
            dep.Idade = 21;

            Console.WriteLine($"{copiaDep.Nome}");
            Console.WriteLine($"{dep.Idade}");
        }
    }
}
