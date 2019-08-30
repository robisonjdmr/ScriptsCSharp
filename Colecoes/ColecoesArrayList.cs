using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace CursoCSharp.Colecoes {
    class ColecoesArrayList {
        public static void Executar() {
            var arrayLista = new ArrayList {
                "Palavra",
                3,
                true
            };
            arrayLista.Add(3.14);

            foreach(var item in arrayLista) {
                Console.WriteLine("{0} => {1}", item, item.GetType());
            }
             
        }
    }
}
