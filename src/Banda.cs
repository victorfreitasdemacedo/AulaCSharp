using Album;
namespace Banda
{
    class Bandas
    {
        private List<AlbumMusica> Albums= new();
        public string? Nome { get; set; }
        
        public void AdicionarAlbum(AlbumMusica albumMusica)
        {
            Albums.Add(albumMusica);
        }
        public void ExibirDiscografica()
        {
            foreach (var item in Albums)
            {
                System.Console.WriteLine(item.Nome);    
            }
        }
    }
}