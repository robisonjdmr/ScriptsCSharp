using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.ClasseEMetodos {

    public enum Genero {  Acao, Aventura, Terror, Animacao, Comedia };

    public class Filme {
        public string Titulo;
        public Genero GeneroDoFilme;
    }
    class ExemploEnum {
        public static void Executar() {
            int id = (int)Genero.Animacao;
            Console.WriteLine(id);

            var filmeParaFamilia = new Filme();
            filmeParaFamilia.Titulo = "Tubarão Vermelho 22";
            filmeParaFamilia.GeneroDoFilme = Genero.Comedia;

            Console.WriteLine("{0} é {1}!", filmeParaFamilia.Titulo, filmeParaFamilia.GeneroDoFilme);
        }
    }
}
