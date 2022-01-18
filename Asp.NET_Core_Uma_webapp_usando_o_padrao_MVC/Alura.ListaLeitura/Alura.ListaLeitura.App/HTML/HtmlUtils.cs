using System.IO;

namespace Alura.ListaLeitura.App.HTML
{
    public class HtmlUtils
    {
        public static string CarregaArquivoHTML(string nomeArquivo)
        {
            var nomeCompletoDoArquivo = $"HTML/{nomeArquivo}.html";
            using (StreamReader arquivo = File.OpenText(nomeCompletoDoArquivo))
            {
                return arquivo.ReadToEnd();
            }

        }
    }
}
