using System;

//namespace FibonacciCSharp
//{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime tiempo1 = DateTime.Now;

            int i, n, f1 = 0, f2 = 1, res = 0;
            Console.Write("Introduzca un numero n para marcar el limite de la sucesion: \n");
            n = int.Parse(Console.ReadLine());
            Console.WriteLine("la sucesion resultante es:");
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            for (i = 0; i <= n-3; i++)
            {
                res = f1 + f2;
                Console.WriteLine(res);
                f1 = f2;
                f2 = res;
            }
            DateTime tiempo2 = DateTime.Now;
            TimeSpan total = new TimeSpan(tiempo2.Ticks - tiempo1.Ticks);
            Console.Write("Tiempo en segundos: " + total.ToString());
            Console.ReadLine();
        }
    }
//}
