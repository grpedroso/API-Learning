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

        var musicasPreferidasDoGabriel = new MusicaPreferidas("Gabriel");
        //musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[23]);
        //musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[89]);
        // musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[123]);
        // musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[456]);
        //musicasPreferidasDoGabriel.AdicionarMusicasFavoritas(musicas[789]);
        //musicasPreferidasDoGabriel.ExibirMusicasFavoritas();
        musicas[1993].ExibirDetalhesDaMusica();
        //musicasPreferidasDoGabriel.GerarArquivoJson();
        //musicasPreferidasDoGabriel.GerarTxtMusicasPreferidas();

    }
    catch (Exception ex)
    {
        Console.WriteLine($"Problema indentificado: {ex.Message}");
    }
}