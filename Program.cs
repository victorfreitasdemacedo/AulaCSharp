using Musica;
namespace AulaCSharp
{
    class AulaCSharp
    {
       public static void Main(string[] args)
        {       
            Musicas musical = new Musicas();
            musical.Nome = "Roxane";
            musical.Artista = "The Police";
            musical.Duracao = 273;
            musical.Disponivel = true;
            musical.ExebirFichaTecnica();
        }
    }
}