using ScreenSound_04.Filtros;
using ScreenSound_04.Modelos;
using System.Text.Json;

using (HttpClient client = new HttpClient())
{
    try
    {
        string resposta = await client.GetStringAsync("https://guilhermeonrails.github.io/api-csharp-songs/songs.json");
        var musicas = JsonSerializer.Deserialize<List<Musica>>(resposta)!; // Transforma o dado/string JSON para objeto manipulavel em C#
        //LinqFilter.FiltrarTodosOsGenerosMusicais(musicas); // Seleciona e filtra todos os generos musicais
        //LinqOrder.ExibirListaDeArtistaOrdenados(musicas);
        //LinqFilter.FiltrarArtistasPorGeneroMusical(musicas, "hip hop");
        //LinqFilter.FiltrarMusicasDeUmArtista(musicas, "50 Cent");
        //LinqFilter.FiltrarMusicasPorAno(musicas, "2003");
        Console.WriteLine("Cade numero representa uma tonalidade sendo 1-C, 2-C#, 3-D, 4-Eb, 5-E, 6-F, 7-F#, 8-G, 9-Ab, 10-A, 11-Bb, 12-B");
        Console.Write("Digite o numero da tonalidade desejada, e pressione ENTER para buscar: ");
        int indice = int.Parse(Console.ReadLine());
        LinqFilter.FiltrarPorIndice(musicas, indice);

        var musicasPreferidasDoGabriel = new MusicaPreferidas("Gabriel");
        //musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[23]);
        //musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[89]);
        // musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[123]);
        // musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[456]);
        //musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[789]);
        //musicasPreferidasDoGabriel.ExibirMusicasFavoritas();
        //musicasPreferidasDoGabriel.GerarArquivoJson();
        //musicasPreferidasDoGabriel.GerarTxtMusicasPreferidas();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Problema indentificado: {ex.Message}");
    }
}