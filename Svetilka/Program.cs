using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Svetilka
{
    class Program
    {
        public static void Menu()
        {
            bool jeKonec = false;

            while (!jeKonec)
            {
                Console.WriteLine("======================================");
                Console.WriteLine("||    Svetilka - v. 0.0.1 (alph)    ||");
                Console.WriteLine("======================================");
                Console.WriteLine("|Izberi orodje, ki ga želiš uporabiti:");
                Console.WriteLine("======================================");
                Console.WriteLine("|P - Pomoč");
                Console.WriteLine("|B - BMI Kalkulator");
                Console.WriteLine("|K - Kruh");
                Console.WriteLine("|I - Izhod");
                Console.Write("\nVnesi svojo izbiro: ");

                char izbira = (char)Console.Read();
                Console.ReadLine();

                switch(izbira)
                {
                    case 'P':
                    case 'p': //Pomoc(); break;
                    case 'B':
                    case 'b': //BMI(); break;
                    case 'K':
                    case 'k': //Kruh(); break;
                    case 'I':
                    case 'i': jeKonec = true; break;
                    default: Console.WriteLine("Vnesi pravilno črko: "); break;
                }
            }
        }
        static void Main(string[] args)
        {
            Menu();
            Console.ReadKey();
        }
    }
}
