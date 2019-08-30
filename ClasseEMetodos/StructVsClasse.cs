using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    public struct Sponto {
        public int X;
        public int Y;
    }
    public class Cponto {
        public int X;
        public int Y;
    }

    class StructVsClasse {
        public static void Executar() {
            Sponto ponto1 = new Sponto { X = 1, Y = 3 };
            Sponto copiaPonto1 = ponto1;// Atribuição por VALOR!!!
            ponto1.X = 3;

            Console.WriteLine("Ponto 1 X: {0}", ponto1.X);
            Console.WriteLine("Copia ponto 1 X: {0}", copiaPonto1.X);

            Cponto ponto2 = new Cponto { X = 2, Y = 4 };
            Cponto copiaPont2 = ponto2;// Atribuição por REFERENCIA!!!  
            ponto2.X = 4;

            Console.WriteLine("Ponto 2 X: {0}", ponto2.X);
            Console.WriteLine("Copia ponto 2 X: {0}", copiaPont2.X);
        }
    }
}
