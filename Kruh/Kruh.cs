using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

    * Za 1 kg belega kruha potrebujemo:
    *   1 kg bele moke
    *   1 žličko soli
    *   1 žličko sladkorja
    *   42 g kvasa
    *   3 žlice olja
    *   100 ml mleka
    *   voda po potrebi
    * Program prebere koliko kruha želimo speči (kot decimalno št.) in izračuna
    * količino potrebnih sestavin.

*/

namespace Kruh
{
    class Kruh
    {
        static void Main(string[] args)
        {
            double kruh;
            int moka = 1, sol = 1, sladkor = 1, kvas = 42, olje = 3, mleko = 100;
            
            Console.Write("Koliko kruha želiš speči?: ");
            kruh = double.Parse(Console.ReadLine());

            Console.WriteLine($"Za {kruh} kg kruha potrebuješ:");
            Console.WriteLine($"\n- Moka: {kruh * moka} kg\n- Sol: {kruh * sol} žličk\n- Sladkor: {kruh * sladkor} žličk\n- Kvas: {kruh * kvas} g (oz. {kruh * kvas / 1000} kg)\n- Olje: {kruh * olje} žlic\n- Mleko: {kruh * mleko} ml (oz. {kruh * mleko / 1000} l)");

            Console.ReadKey();
        }
    }
}
