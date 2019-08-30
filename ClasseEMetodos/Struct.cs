using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    interface Ponto {
        void MoverNaDiagonal(int delta1, int delta2);
    }
    struct Coordenada: Ponto {
        public int X;
        public int Y;

        public Coordenada(int x, int y) {
            X = x;
            Y = y;
        }
        public void MoverNaDiagonal(int delta1, int delta2) {
            X += delta1;
            Y += delta2;
        }
    }
    
        


    class ExemploStruct {
        public static void Executar() {
            Coordenada coordenadaInicial;

            coordenadaInicial.X = 2;
            coordenadaInicial.Y = 2;

            Console.WriteLine("Coordenada inicial:");
            Console.WriteLine("X = {0}", coordenadaInicial.X);
            Console.WriteLine("Y = {0}", coordenadaInicial.Y);

            var coordenadaFinaL = new Coordenada(x: 9, y: 1);
            coordenadaFinaL.MoverNaDiagonal(10, 3);

            Console.WriteLine("coordenada Final:");
            Console.WriteLine("X = {0}", coordenadaFinaL.X);
            Console.WriteLine("Y = {0}", coordenadaFinaL.Y);
        }
    }
}
