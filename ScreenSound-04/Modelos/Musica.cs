using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace ScreenSound_04.Modelos
{
    internal class Musica
    {
        [JsonPropertyName("song")]
        public string Nome {  get; set; } // song = Nome
        [JsonPropertyName("artist")]
        public string Artista { get; set; } // artist = Artista
        [JsonPropertyName("duration_ms")]
        public int Duracao { get; set; }
        [JsonPropertyName("genre")]
        public string Genero { get; set; }
        [JsonPropertyName("year")]
        public string Ano { get; set; }
        
        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Duração da música: {Duracao}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Ano: {Ano}");
        }
    
    }
}
