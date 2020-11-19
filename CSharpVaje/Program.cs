using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
  
    Program, ki prebere dve (int) števili in ju izpiše.
    Izpiše tudi vsoto, razliko, zmnožek, količnik in ostanek pri deljenju.
  
*/
namespace CSharpVaje
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;

            Console.Write("Vnesi prvo število: ");
            a = int.Parse(Console.ReadLine());
            Console.Write("Vnesi drugi število: ");
            b = int.Parse(Console.ReadLine());

            Console.WriteLine($"\nVsota števila {a} in {b} je: {a + b}");
            Console.WriteLine($"Razlika števila {a} in {b} je: {a - b}");
            Console.WriteLine($"Zmnožek števila {a} in {b} je: {a * b}");
            Console.WriteLine($"Količnik števila {a} in {b} je: {(double)a / b}");
            Console.WriteLine($"Ostanek med številoma {a} in {b} je: {(double)a % b}");

            Console.ReadKey();
        }
    }
}
