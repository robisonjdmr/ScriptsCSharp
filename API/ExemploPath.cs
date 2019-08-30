using System;
using System.IO;

namespace CursoCSharp.API {
    class ExemploPath {
        public static void Executar() {
            var arquivo = @"C:\Users\Robison\Desktop\Curso de C-sharp\CursoSharp\source\repos\CursoCSharp/exemplo_path_arquivo.txt";
            var pasta = @"C:\Users\Robison\Desktop\Curso de C-sharp\CursoSharp\source\repos\CursoCSharp/exemplo_path_pasta";

            if (!File.Exists(arquivo)) {
                using (StreamWriter sw = File.CreateText(arquivo)) {
                sw.WriteLine("Um novo arquivo criado!");
                }
            }
            if (!Directory.Exists(pasta)) {
                Directory.CreateDirectory(pasta);
            }
            Console.WriteLine(Path.GetExtension(arquivo));
            Console.WriteLine(Path.GetFileName(arquivo));
            Console.WriteLine(Path.GetFileNameWithoutExtension(arquivo));
            Console.WriteLine(Path.GetDirectoryName(arquivo));
            Console.WriteLine(Path.HasExtension(arquivo));

            Console.WriteLine(Path.HasExtension(pasta));
            Console.WriteLine(Path.GetFullPath(pasta));
            Console.WriteLine(Path.GetPathRoot(pasta));


        }
    }
}
