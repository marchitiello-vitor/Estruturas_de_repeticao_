using System;

namespace ex_2
{
    class Program
    {
        static void Main(string[] args)
        
        {
        
           do
           {
            Console.WriteLine("Digite seu username:");
            string user = Console.ReadLine();

            Console.WriteLine("Digite sua senha:");
            string senha = Console.ReadLine();

                do
                {
                if (senha == "")
                {
                    Console.WriteLine("nah nah nah, não tem nenhuma senha digitada!");
                }
                else if (user == senha )
                {
                Console.WriteLine("No no no, os dois não pode ser iguais!, ponha novamente!");                  
                }
                else{
                Console.WriteLine("Correto meu nobre, adicionado!");
                }                                     
                } while (false);

                break;

           } while (true);
        }
    }
}
