using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos
{
    internal class MusicaPreferidas
    {
        public string Nome {  get; set; }
        public List<Musica> ListaDeMusicasFavoritas { get; }

        public MusicaPreferidas(string nome)
        {
            Nome = nome;
            ListaDeMusicasFavoritas = new List<Musica>();
        }

        public void AdicionarMusicasFavoritas(Musica musica)
        {
            ListaDeMusicasFavoritas.Add(musica);
        }

        public void ExibirMusicasFavoritas()
        {
            Console.WriteLine($"Essas são as músicas favoritas do {Nome}: ");
            foreach (var musica in ListaDeMusicasFavoritas)
            {
                Console.WriteLine("- " + musica.Nome+  " de " + musica.Artista );
            }
            Console.WriteLine();
        }

        public void GerarArquivoJson()
        {
            string json = JsonSerializer.Serialize(new 
            { Nome = Nome, musicas = ListaDeMusicasFavoritas // converte o dado manipulavel em C# para string
            });
            string nomeDoArquivo = $"musicas-favoritas-{Nome}.json";
            File.WriteAllText(nomeDoArquivo, json); // criar o arquivo JSON
            Console.WriteLine($"O arquivo .json foi criado com sucesso! " +
                $"{Path.GetFullPath(nomeDoArquivo)}"); // Obtem a direção de onde foi salvo
        }

        public void GerarTxtMusicasPreferidas()
        {
            string nomeDoArquivo = $"musica-favoritas-{Nome}.txt";
            using (StreamWriter arquivo = new StreamWriter(nomeDoArquivo))
            {
                arquivo.WriteLine($"Músicas favoritas do {Nome}\n");
                foreach (var musica in ListaDeMusicasFavoritas )
                {
                    arquivo.WriteLine("- " + musica.Nome + " de " + musica.Artista); // escreve a lista no arquivo
                }
            }
            Console.WriteLine("TXT gerado com sucesso! " + Path.GetFullPath(nomeDoArquivo));
        }
    }
}
