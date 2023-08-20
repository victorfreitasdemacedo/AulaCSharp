namespace Musica
{
    class Musicas
    {
        public string? Nome{get; set;}
        public string? Artista{get; set;}
        public int? Duracao{get; set;}
        public bool Disponivel{get; set;}
        public int DuracaoTotal { get; internal set; }

        public void ExebirFichaTecnica()
        {
            Console.WriteLine($"Nome {Nome}");
            Console.WriteLine($"Artista {Artista}");
            Console.WriteLine($"Duração {Duracao}");
            if (Disponivel)
            {
                Console.WriteLine($"Disponivel no plano");    
            }else
            {
                Console.WriteLine("Adquira o plano plus+");
            }
            
        }
    }
}