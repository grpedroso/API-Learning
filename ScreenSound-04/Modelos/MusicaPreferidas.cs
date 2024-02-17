using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
        }
    }
}
