using Musica;
namespace Album
{
    class AlbumMusica
    {
        public string? Nome { get; set;}
        private List<Musicas> Music = new List<Musicas>();
        
        public void AdicionarMusica(Musicas musicas)
        {
            Music.Add(musicas); 
        }
    }
}