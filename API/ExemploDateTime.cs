using System;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.API {
    class ExemploDateTime {
        public static void Executar() {
            var dateTime = new DateTime(year: 2030, month: 2, day: 6);

            Console.WriteLine(dateTime.Day);
            Console.WriteLine(dateTime.Month);
            Console.WriteLine(dateTime.Year);


            //sem horas
            var hoje = DateTime.Today;
            Console.WriteLine(hoje);

            // Com hora
            var diaAtual = DateTime.Now;
            Console.WriteLine(diaAtual);
            Console.WriteLine("Hora: " + diaAtual.Hour);
            Console.WriteLine("Minutos: " + diaAtual.Minute);

            //Adicionar ou remover dias nas datas
            var ontem = diaAtual.AddDays(-1);
            Console.WriteLine(ontem);

            var amanha = diaAtual.AddDays(1);
            Console.WriteLine(amanha);

            //pegar uma data e mostrar ela como tostring
            Console.WriteLine("");
            Console.WriteLine(diaAtual.ToString("dd"));//Mostra somente o dia
            Console.WriteLine(diaAtual.ToString("d"));//mostra dia/mes/ano no formado padrão no caso aqui em portugues sistema 00/00/0000
            Console.WriteLine(diaAtual.ToString("D"));//mostra a data completa no formato do Ex: quarta-feira, 13 de fevereiro de 2019
            Console.WriteLine(diaAtual.ToString("g"));//mostra dia/mes/ano a hora e minutos no formado padrão no caso aqui em portugues sistema 00/00/0000 09:24
            Console.WriteLine(diaAtual.ToString("G"));//mostra dia/mes/ano a hora e minutos e segundos no formado padrão no caso aqui em portugues sistema 00/00/0000 09:24:38
            Console.WriteLine(diaAtual.ToString("dd-MM-yyyy HH:mm"));//Mostra no formato que queremos posso usar barras ou ifem

        }
    }
}
