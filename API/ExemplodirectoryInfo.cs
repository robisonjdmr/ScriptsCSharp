using System;
using System.IO;

namespace CursoCSharp.API {
    class ExemplodirectoryInfo {
        public static void Executar() {
            var dirProjeto = @"C:\Users\Robison\Desktop\Curso de C-sharp\CursoSharp\source\repos\CursoCSharp";
            var dirInfo = new DirectoryInfo(dirProjeto);

            if (!dirInfo.Exists) {
                dirInfo.Create();
            }
            Console.WriteLine("==Arquivos =========");
            var arquivos = dirInfo.GetFiles();
            foreach(var arquivo in arquivos) {
                Console.WriteLine(arquivo);
            }
            Console.WriteLine("\n== Diretprios =======");
            var pastas = dirInfo.GetDirectories();
            foreach(var pasta in pastas) {
                Console.WriteLine(pasta);
            }
            Console.WriteLine(dirInfo.CreationTime);
            Console.WriteLine(dirInfo.FullName);
            Console.WriteLine(dirInfo.Root);
            Console.WriteLine(dirInfo.Parent.Parent); 

        }
    }
}
