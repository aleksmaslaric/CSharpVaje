using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*

    * Program prebere višino in težo osebe, vrne pa BMI (body mass index).

*/

namespace BMICalc
{
    class BMICalc
    {
        static void Main(string[] args)
        {
            float visina, teza, bmi;

            Console.Write("Vnesi svojo višino v m: ");
            visina = float.Parse(Console.ReadLine());
            Console.Write("Vnesi svojo težo v kg: ");
            teza = float.Parse(Console.ReadLine());

            bmi = teza / (visina * visina);

            if (bmi < 18.5)
            {
                Console.WriteLine($"\nTvoj BMI je premajhen ({bmi}). Tvoja teža je premajhna");
            } else if (bmi >= 18.5 && bmi < 25)
            {
                Console.WriteLine($"\nTvoj BMI je normalen ({bmi}). Tvoja teža je OK :). Congrats!");
            } else if (bmi >= 25 && bmi < 30)
            {
                Console.WriteLine($"\nTvoj BMI je prevelik ({bmi}). Tvoja teža je prevelika. Kakšen trebušnjak ne bi bil odveč :)");
            } else if (bmi > 30)
            {
                Console.WriteLine($"\nTvoj BMI je popolnoma prevelik ({bmi}). Imaš en kup kil preveč.\nAkcija reakcija, telovadba in raznolika hrana sta bistvenega pomena.");
            }
            Console.ReadKey();
        }
    }
}
