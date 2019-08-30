using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.OO {

    public class Comida {
        public double Peso;

        public Comida(double peso) {
            Peso = peso;
        }
        public Comida() {
             
        }
    }
    

    public class Feijao :  Comida {
        //public double Peso; Utilizando o polimorfismo não desta linha já que esta sendo herdada da class COMIDA
    }
    public class Arroz : Comida {
        //public double Peso; Utilizando o polimorfismo não desta linha já que esta sendo herdada da class COMIDA
    }
    public class Carne : Comida {
        //public double Peso; Utilizando o polimorfismo não desta linha já que esta sendo herdada da class COMIDA
    }
    public class Pessoa : Comida {
        //public double Peso; Utilizando o polimorfismo não desta linha já que esta sendo herdada da class COMIDA

        //public void Comer(Feijao feijao) {  ** Utilizando a herança de COMIDA consigo usar um metodo somente, como neste exemplo usei o Metodo Abaixo
        //    Peso += feijao.Peso;
        //}
        //public void Comer(Arroz arroz) { ** Utilizando a herança de COMIDA consigo usar um metodo somente, como neste exemplo usei o Metodo Abaixo
        //    Peso += arroz.Peso;
        //}
        //public void Comer(Carne carne) { ** Utilizando a herança de COMIDA consigo usar um metodo somente, como neste exemplo usei o Metodo Abaixo
        //    Peso += carne.Peso;
        //} 
        public void Comer(Comida comida) {
            Peso += comida.Peso;
        }
    }
    class Polimorfismo {

        public static void Executar() {
            Feijao ingrediente1 = new Feijao();
            ingrediente1.Peso = 0.3;
            Arroz ingrediente2 = new Arroz();
            ingrediente2.Peso = 0.25;
            Carne ingrediente3 = new Carne();
            ingrediente3.Peso = 0.3;

            Pessoa cliente = new Pessoa();
            cliente.Peso = 80.2;
            cliente.Comer(ingrediente1);
            cliente.Comer(ingrediente2);
            cliente.Comer(ingrediente3);

            Console.WriteLine($"Agora o peso do cliente é {cliente.Peso} Kg!");
        }
    }
}
