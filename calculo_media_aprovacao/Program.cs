using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace calculo_media_aprovacao
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("=========================");
            Console.WriteLine("|  ::Calcular Média ::  |");
            Console.WriteLine("=========================");


            for (int d = 0; d < 1; d++)
            {
                double n, media = 0, media_final;
                for (int i = 0; i < 4; i++)
                {
                    Console.Write($"Digite a nota {i + 1}: ");
                    n = Convert.ToDouble(Console.ReadLine());
                    media += n;
                };
                media_final = media /4;
               


                if (media_final >= 7){
                    Console.WriteLine("Você foi aprovado");
                    Console.WriteLine("==========");
                    Console.WriteLine($"|   {media_final}   |");
                    Console.WriteLine("==========");
                }
                else{
                    Console.WriteLine("Você foi reprovado");
                    Console.WriteLine($"|   {media_final}   |");
                }

            }


        }
    }
}
