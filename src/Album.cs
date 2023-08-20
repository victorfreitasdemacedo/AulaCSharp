using Musica;
namespace Album
{
    class AlbumMusica
    {
        private List<Musicas> Musicas = new();
        public string? Nome { get; set; }
        public int DuracaoTotal => Musicas.Sum(x => x.DuracaoTotal);

        public void AdicionarMusica(Musicas Musica)
        {
            Musicas.Add(Musica);
        }    
        
        public void ExibirMusicasDoAlbum()
        {
            foreach (var item in Musicas)
            {
            System.Console.WriteLine(item.Nome);
            }
            System.Console.WriteLine(DuracaoTotal);
        }
    }
}