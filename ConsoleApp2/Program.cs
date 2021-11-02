using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            
            {
                double polomer;
                double obvod;
                double obsah;
                double prumer;
                double vyber;
                
                Console.WriteLine("Obvod kruhu :");
                Console.ReadLine();
                Console.WriteLine("Vyber si z možností : 1 - Poloměr   2 - Průměr");

                double.TryParse(Console.ReadLine(), out vyber);

                if (vyber == 1)
                {
                    Console.WriteLine("Zadej poloměr");
                    double.TryParse(Console.ReadLine(), out polomer);

                    obvod = 2 * 3.14 * polomer;
                    Console.WriteLine($"Obvod kruhu je : {obvod}");
                    Console.ReadLine();
                    obsah = 3.14 * (polomer * polomer);
                    Console.WriteLine($"Obsah kruhu je : {obsah}");

                }
                else if (vyber == 1) ;
                {
                    Console.WriteLine("Zadej průměr");
                    double.TryParse(Console.ReadLine(), out prumer);

                    obvod = 3.14 * prumer;
                    Console.WriteLine($"Obvod kruhu je : {obvod}");
                    Console.ReadLine();
                    obsah = 3.14 * (prumer * prumer) / 4;
                    Console.WriteLine($"Obsah kruhu je : {obsah} ");


                }
                
            }
        }
    }
}
