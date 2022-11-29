using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Prodavac Milijana = new Prodavac("Milijana", 50);
            Milijana.Prodao(100);
            Prodavac Djani = new Prodavac("Djani", 50);
            Sef Maca = new Sef("Maca", 50, 25);
            Maca.Dodeli(Milijana);
            Maca.Dodeli(Djani);
            Console.WriteLine(Maca);
            Console.ReadKey(); 
        }
    }
}
