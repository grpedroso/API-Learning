using ScreenSound_04.Modelos;

namespace ScreenSound_04.Filtros;

internal class LinqFilter
{
    public static void FiltrarTodosOsGenerosMusicais(List<Musica> musicas)
    {
        var todosOsGenerosMusicais = musicas.Select(generos => generos.Genero).Distinct().ToList(); // .Select seleciona uma lista com base nos generos atraves de uma função anonima
        foreach(var genero in todosOsGenerosMusicais)
        {
            Console.WriteLine("- " + genero);
        }
    }

    public static void FiltrarArtistasPorGeneroMusical(List<Musica> musicas, string genero)
    {
        var artistasPorGeneroMusical = musicas.Where(musica => 
        musica.Genero.Contains(genero)).Select(musica => musica.Artista).Distinct().ToList(); // Seleciona artistas com base no genero musical
        Console.WriteLine("Artistas por genero musical -> " + genero);
        foreach(var artista in artistasPorGeneroMusical)
        {
            Console.WriteLine("- " + artista);
        }
    }
}
