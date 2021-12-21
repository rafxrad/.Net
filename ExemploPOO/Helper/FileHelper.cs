using System.IO;

namespace ExemploPOO.Helper
{
    public class FileHelper
    {
        public void ListarDiretorios(string path)
        {
            var retornoCaminho = Directory.GetDirectories(path);
            foreach (var caminho in retornoCaminho)
            {
                System.Console.WriteLine(caminho);
            }

        }
    }
}