using System.IO;
using System.Collections.Generic;
using Entities;
using System.Globalization;

namespace arquivos {
    class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite o caminho do diretório: ");
            string sourceFile = Console.ReadLine();

            try {
                string[] linhas = File.ReadAllLines(sourceFile);

                string diretorioDoArquivo = Path.GetDirectoryName(sourceFile);
                string diretorioFinal = diretorioDoArquivo + @"\out";
                string ArquivoDestino = diretorioFinal + @"\summary.txt";

                Directory.CreateDirectory(diretorioFinal);


                using (StreamWriter sw = File.AppendText(ArquivoDestino)) {

                    foreach (string linha in linhas) {

                        string[] produtos = linha.Split(',');

                        string nome = produtos[0];
                        double preco = double.Parse(produtos[1], CultureInfo.InvariantCulture);
                        int quantidade = int.Parse(produtos[2]);


                        Product produto = new Product(nome, quantidade, preco);

                        sw.Write(produto.Nome + ", " + produto.Total().ToString("F2", CultureInfo.InvariantCulture) + "\n");

                    }
                }
            }
            catch(IOException e) {
                Console.WriteLine("ERRO");
                Console.WriteLine(e.Message);
            }
        }
    }
}


