using System;
using CursoCSharp.ClasseEMetodos;

namespace CursoCSharp.TopicosAvancados {
    public class Caixa<T> {
        T valorPrivado;
        public T Coisa { get; set; }

        public Caixa(T coisa) {
            Coisa = coisa;
            valorPrivado = coisa;
        }
        public T metodoGenerico(T valor) {
            return new Random().Next(0, 2) == 0 ? Coisa : valor;
        }
        public T GetValor() {
            return valorPrivado;
        }
    }
    class Caixaint : Caixa<int> {
        public Caixaint() : base(0) {

        }
    }
    class CaixaProduto : Caixa<Produto> {
        public CaixaProduto() : base(new Produto()) {

        }
    }

    class Genericos {
        public static void Executar() {
            var caixa1 = new Caixa<int>(1000);
            Console.WriteLine(caixa1.metodoGenerico(33));
            Console.WriteLine(caixa1.Coisa.GetType());

            var caixa2 = new Caixa<string>("construtor");
            Console.WriteLine(caixa2.metodoGenerico("metodo"));
            Console.WriteLine(caixa2.Coisa.GetType());

            CaixaProduto caixa3 = new CaixaProduto();
            Console.WriteLine(caixa3.Coisa.GetType().Name);
        }
    }
}
