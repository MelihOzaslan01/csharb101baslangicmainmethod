using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleProgramlama
{
    internal class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            Console.WriteLine("İsminizi Girin");
            string name = Console.ReadLine();
            Console.WriteLine("Soy İsminizi Girin");
            string surname = Console.ReadLine();
            Console.WriteLine("Merhaba" +" " + name + " " + surname);
            

        }
    }
}
