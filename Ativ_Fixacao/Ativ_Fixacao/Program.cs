using System;

namespace Ativ_Fixacao
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = new int[6];
            String[] nome = new string[6];
            for (int i = 0; i < 6; i++)
            {
                Console.Write("Insira um numero: ");
                num[i] = Convert.ToInt16(Console.ReadLine());
                Console.Clear();
            }

            for (int i = 0; i < 6; i++)
            {
                Console.Write("Insira um nome: ");
                nome[i] = Console.ReadLine();
                Console.Clear();
            }

            for (int i = 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i]);
            }
            Console.WriteLine();

            for (int i = 0; i < nome.Length; i++)
            {
                Console.WriteLine(nome[i]);
            }
        }
    }
}
