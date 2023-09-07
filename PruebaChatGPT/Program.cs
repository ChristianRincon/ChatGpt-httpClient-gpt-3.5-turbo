using BL;

namespace extraerDatos
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nUsuario: ");
            string input = Console.ReadLine();

            ChatGPT.Consulta(input);
        }
    }
}