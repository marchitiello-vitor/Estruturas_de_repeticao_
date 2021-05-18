using System;

namespace ex_1
{
    class Program
    {
        static void Main(string[] args)
        {
        do
        {           
            Console.WriteLine("Digite a nota:");
            int nota = int.Parse(Console.ReadLine());

            if (nota >10)
            {
                Console.WriteLine("no no no, numero errado!");
            }
            else {
                Console.WriteLine("Correto meu nobre");
                Console.WriteLine("Fim do programa");
            }
        } while (false);
        
        }
    }
}
