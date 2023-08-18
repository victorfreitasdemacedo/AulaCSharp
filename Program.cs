using Musica;
namespace AulaCSharp
{
    class AulaCSharp
    {
       public static void Main(string[] args)
        {
            Musicas musical = new()
            {
                Nome = "Roxane",
                Artista = "The Police",
                Duracao = 273,
                Disponivel = true
            };
            musical.ExebirFichaTecnica();
        }
    }
}