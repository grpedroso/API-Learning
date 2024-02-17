using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using System.Xml;

namespace ScreenSound_04.Modelos
{
    internal class Musica
    {
        private string[] tonalidades = {"C", "C#", "D", "Eb", "E", "F", "F#", "G", "Ab", "A", "Bb", "B" };
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
        [JsonPropertyName("key")]
        public int Chave { get; set; }
        public string Tonalidade { get { return tonalidades[Chave]; } }
        
        public void ExibirDetalhesDaMusica()
        {
            Console.WriteLine($"Artista: {Artista}");
            Console.WriteLine($"Música: {Nome}");
            Console.WriteLine($"Duração da música: {Duracao}");
            Console.WriteLine($"Genero: {Genero}");
            Console.WriteLine($"Tonalidade: {Tonalidade}");
        }
        
 
    }
}
