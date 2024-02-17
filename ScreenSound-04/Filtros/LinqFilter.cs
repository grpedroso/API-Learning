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
}
