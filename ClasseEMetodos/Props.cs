using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    public class CarroOpcional {
        double desconto = 0.1;

        string nome;
        public string Nome {
            get {
                return "Opcional" + nome;
            }
            set {
                nome = value;
            }
        }
        //propriedades autoi´mplementadas

        public double Preco { get; set; }

        // somente Leitura
        public double PrecoComDesconto {
            get => Preco - (desconto * Preco); // Posso fazer com lambda
           
            // Posso fazer com return
            //get {
            //    return Preco - (desconto * Preco);
            //}
        }
        public CarroOpcional() {

        }
        public CarroOpcional(string nome, double preco) {
            Nome = nome;
            Preco = preco;
        }

    }
    class Props {
        public static void Executar() {
            var op1 = new CarroOpcional(" Ar-condicionado", 3499.90);

            Console.WriteLine(op1.PrecoComDesconto);

            var op2 = new CarroOpcional();
            op2.Nome = " Direção idraulica";
            op2.Preco = 3499.99;

            Console.WriteLine(op2.Nome);
            Console.WriteLine(op2.Preco);
            Console.WriteLine(op2.PrecoComDesconto);
            
        }
    }
}
