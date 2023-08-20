using Musica;
using Album;
using Banda;

namespace AulaCSharp
{
    class AulaCSharp
    {
       public static void Main(string[] args)
        {       
            AlbumMusica AlbumQueen = new();
            AlbumQueen.Nome = "A night at the opera";

            Musicas Musica1 = new();
            Musica1.Nome = "Love of my life";
            Musica1.Duracao = 203;

            Musicas Musicas2 = new();
            Musicas2.Nome = "Bohemian Rhasposdy";
            Musicas2.Duracao = 354;
            
            AlbumQueen.AdicionarMusica(Musica1);
            AlbumQueen.AdicionarMusica(Musicas2);

            Bandas queen = new();
            queen.Nome = "Queen";
            queen.AdicionarAlbum(AlbumQueen);
            queen.ExibirDiscografica();
            
        }
    }
}