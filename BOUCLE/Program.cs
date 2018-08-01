using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
//
continue => increment du boucle
break => sort de la boucle

//for
    for(int i = 0; i<n; i++)
    {
        //Traitements...
    }
//while
    while( <condition> ) 
    {
        //Traitements...
    }
//do .. while
    do
    {
        //Traitements...
    }while( <condition> )
//foreach(<type> <nom de variable> in <collection>)
    {
        //Traitements...
    }
*/
namespace BOUCLE
{
    class Program
    {
        static void PremiereNumPar()
        {
            for (int i = 2; i < 22; i = i + 2)
            {
                Console.WriteLine(i);
            }            
        }
        static void DeuxiemeNumPar()
        {
            for (int i = 1; i <= 20; i++)
            {
                if (i % 2 == 0)//verification de nombre par
                {
                    Console.WriteLine(i);
                }                
            }            
        }
        static void EspererNombreWhile()
        {
            int nombre;
            while(true)// tant que ma condition et vrais..
            {
                Console.Clear();
                Console.WriteLine("Vous pouvez taper 2018, svp?");
                nombre = int.Parse(Console.ReadLine());
                if (nombre == 2018)
                {
                    Console.WriteLine("Merci et au revoir!");
                    break;
                }                
            }
        }
        static void EspererNombreDoWhile()
        {
            string nombre;
            do // tant que ma condition et vrais..
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("--Vous pouvez taper 2018, svp?--");
                Console.WriteLine("--------------------------------");
                nombre = Console.ReadLine();
                if (nombre == "2018")
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("------Merci et au revoir!------");
                    Console.WriteLine("-------------------------------");
                    break;
                }
            } while (true);
        }

        static void EspererNombreForeach()
        {
            string nombre;
            do // tant que ma condition et vrais..
            {
                Console.Clear();
                Console.WriteLine("--------------------------------");
                Console.WriteLine("--Vous pouvez taper 2018, svp?--");
                Console.WriteLine("--------------------------------");
                nombre = Console.ReadLine();
                if (nombre == "2018")
                {
                    Console.Clear();
                    Console.WriteLine("-------------------------------");
                    Console.WriteLine("------Merci et au revoir!------");
                    Console.WriteLine("-------------------------------");
                    break;
                }
            } while (true);
        }

        static void Main(string[] args)
        {
            //PremiereNumPar();
            //DeuxiemeNumPar();
            EspererNombreDoWhile();
            Console.ReadKey();
        }
    }
}
