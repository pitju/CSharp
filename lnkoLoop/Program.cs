using System;

namespace lnkoLoop
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // Egy konzol program bezárul, ha a program lefutott.
            // Arra való a ReadKey(), hogy a program várjon az ablak becsukásával addig, amíg a user nem üt le egy
            // billentyűt. 
            do
            {
                Console.WriteLine("Adj meg egy számot");
                var a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Adj meg még egy számot!");
                var b = Convert.ToInt32(Console.ReadLine());

                if (a != b)
                {
                    while (a != b)
                    {
                        if (a > b)
                            a = a - b;
                        else
                            b = b - a;
                    }
                }

                if (a == b)
                    Console.WriteLine("lnko " + a);
                // A KeyAvaiable metódus csak a ReadKey metódussal együtt használható.
                // Arra való, hogy amíg nincs újraindító billentyűleütés, addig állítsa meg a programot egy ideig
                // nézz majd utána, hogy ez mire jó!!!
                /*while (Console.KeyAvailable == false)
                    Thread.Sleep(250); */
                // A Do While végére mindig kell pontosvessző!!!
            } while (Console.ReadKey().Key != ConsoleKey.X);
        }
    }
}