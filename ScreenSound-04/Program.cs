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
        LinqFilter.FiltrarMusicasDeUmArtista(musicas, "Wiz Khalifa");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Problema indentificado: {ex.Message}");
    }
}