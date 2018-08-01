using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXE1
{
    class Program
    {
        static void Main(string[] args)
        {
            string message;

            // traitement de symbole € - entrée et sorti
            Console.InputEncoding = System.Text.Encoding.Unicode;
            Console.OutputEncoding = System.Text.Encoding.Unicode;

            Console.WriteLine("Entrez un symbole de devise(€ / $ / £)");
            string saisie = Console.ReadLine();
            switch (saisie)
            {
                case "€":
                    message = "Euro";
                    break;

                case "$":
                    message = "Dollar";
                    break;

                case "£":
                    message = "Livre";
                    break;

                default:
                    message = "Devise inconnue";
                    break;
            }
            Console.WriteLine(message);
            Console.ReadKey();
        }
    }
}
