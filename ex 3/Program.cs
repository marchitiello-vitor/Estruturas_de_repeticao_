using System;

namespace ex_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("insira seu nome: ");
            string nome = Console.ReadLine();

            Console.WriteLine("Digite sua idade: ");
            int idade = int.Parse(Console.ReadLine());

            Console.WriteLine("insira seu salario:");
            int salario = int.Parse(Console.ReadLine());

            Console.WriteLine("insira seu estado civil, tal como s(solteiro), c(casado), v(viuvo) ou d(divorciado:");
            string estadoCivil = Console.ReadLine();

           if (nome == "" )
           {
               Console.WriteLine("não tem nada escrito!");
           } 
           else if (idade >=150)
           {
               Console.WriteLine("você é muito velho!");
           }
           else if (salario == 0 ) 
           {
               Console.WriteLine("va ganhar algum dinheiro!");
           } 
           else
           {
               Console.WriteLine("validado!");
           }        
        }
    }
}
