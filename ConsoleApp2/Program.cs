using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        { 
            try
            {
                Console.Clear();
                Console.WriteLine("Inserez un Entier...");
                var nombreEntier = int.Parse(Console.ReadLine());
               
                
                Console.WriteLine("nombreEntier = "+nombreEntier);
                if (nombreEntier > 0)
                {
                    Console.WriteLine("Nombre positif");
                }
                else if(nombreEntier<0)
                {
                    Console.WriteLine("Nombre négatif");
                }
                else
                {
                    Console.WriteLine("Rien à dire");
                }

                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"MAUVAIS FORMAT! {e.Message}");
                Console.ReadKey();
            }

        }
    }
}
