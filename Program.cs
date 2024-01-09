using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program {
        static void Main(string[] args) {

            Console.WriteLine("Digite um numero.");
            int n = int.Parse(Console.ReadLine());

            int quadrado = 0;
            int cubo = 0;

            for (int i = 1; i <= n; i++) {
                quadrado = i * i;
                cubo = i * i * i;
                Console.WriteLine(i + " " + quadrado + " " + cubo);
            }

        }
    }
}