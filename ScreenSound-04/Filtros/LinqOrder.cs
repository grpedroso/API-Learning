using ScreenSound_04.Modelos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound_04.Filtros
{
    internal class LinqOrder
    {
        public static void ExibirListaDeArtistaOrdenados(List<Musica> musicas) 
        {
            var artistasOrdenados = musicas.OrderBy(musica => // Ordeno a lista de artistas
            musica.Artista).Select(musica => musica.Artista).Distinct().ToList(); // Crio uma lista de strings, tira os repetidos, e guarda.
            Console.WriteLine("Lista de artistas ordenados:");
            foreach(var artista in artistasOrdenados)
            {
                Console.WriteLine("- " + artista);
            }
        }
    }
}
