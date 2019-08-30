using System;
using System.IO;

namespace CursoCSharp.API {
    class ExemploFileInfo {
        public static void ExclirSeExistir(params string[] caminhos) {
            foreach (var caminho in caminhos) {
                FileInfo arquivo = new FileInfo(caminho);

                if (arquivo.Exists) {
                    arquivo.Delete();
                }
            }
        }

        public static void Executar() {
            var caminhoOriginal = @"~/arq_original.xlsx".ParseHome();
            var caminhoDestino = @"~/arq_destino.xlsx".ParseHome();
            var caminhoCopia = @"~/arq_copia.xlsx".ParseHome();
            ExclirSeExistir(caminhoOriginal, caminhoDestino, caminhoCopia);

            using(StreamWriter sw = File.CreateText(caminhoOriginal)) {
                sw.WriteLine("Arquivo original, Mais uma celula, outra");
            }

            FileInfo original = new FileInfo(caminhoOriginal);
            Console.WriteLine(original.Name);
            Console.WriteLine(original.IsReadOnly);
            Console.WriteLine(original.FullName);
            Console.WriteLine(original.Extension);
            Console.WriteLine(original.DirectoryName);

            original.CopyTo(caminhoCopia);
            original.MoveTo(caminhoDestino);
        }
    }
}
