using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SWITCH
{
    class Program
    {
        static void Main(string[] args)
        {
            string message= "Tu es ";
            string saisie = Console.ReadLine();
            switch(saisie)
            {
                case "Madame":
                    message += "la bienvenue!";
                    break;

                case "Mademoiselle":
                    message += "la bienvenue!";
                    break;

                default:
                    message += "le bienvenue!";
                    break;
            }
            Console.WriteLine(message);
            Console.ReadKey();
            // ou tu peux faire comme ca
            /*
            switch (saisie)
            {
                case "Mademoiselle":
                case "Madame":
                    message += "la bienvenue!";
                    break;

                default:
                    message += "le bienvenue!";
                    break;
            }
            */
        }
    }
}
