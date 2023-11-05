using System;

namespace TextoInvertido
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Digite o texto que deseja inverter:");
            string texto = Console.ReadLine();

            string textoInvertido = InverterLetras(texto);
            Console.WriteLine("Texto invertido: " + textoInvertido);
        }

        static string InverterLetras(string input)
        {
            char[] caracteres = input.ToCharArray();
            Array.Reverse(caracteres);
            return new string(caracteres);
        }
    }
}
