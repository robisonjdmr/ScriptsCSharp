﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {
    public class Carro {
        protected readonly int VelocidadeMaxima;
        int VelocidadeAtual;



        public Carro(int velocidadeMaxima) {
            VelocidadeMaxima = velocidadeMaxima;
        }

        protected int AlternarVelocidade( int delta) {
            int novaVelocidade = VelocidadeAtual + delta;

            if(novaVelocidade < 0) {
                VelocidadeAtual = 0;
            }else if(novaVelocidade > VelocidadeMaxima) {
                VelocidadeAtual = VelocidadeMaxima;
            } else {
                VelocidadeAtual = novaVelocidade;
            }
            return VelocidadeAtual; 
        }
        public virtual int Acelerar() {
            return AlternarVelocidade(5);
        }
        public int Frear() {
            return AlternarVelocidade(-5);
        }
    }
    public class Uno : Carro {
        public Uno() : base(200) {

        }        
    }
    public class Ferrari : Carro {
        public Ferrari() : base(350) {

        }
        public override int Acelerar() {
            return AlternarVelocidade(15);
        }
        public new int Frear() {
            return AlternarVelocidade(-15);
        }
    }
    
    class Heranca {
        public static void Executar() {
            Console.WriteLine("Uno...");
            Uno carro1 = new Uno();
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Acelerar());
            Console.WriteLine(carro1.Frear());
            Console.WriteLine(carro1.Frear());

            Console.WriteLine("Ferrari...");
            Ferrari carro2 = new Ferrari();
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Acelerar());
            Console.WriteLine(carro2.Frear());
            Console.WriteLine(carro2.Frear());

            Console.WriteLine("Ferrari com tipo Carro...");
            Carro carro3 = new Ferrari(); // Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

            carro3 = new Uno();// Polimorfismo
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Acelerar());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());
            Console.WriteLine(carro3.Frear());

        }
    }
}
