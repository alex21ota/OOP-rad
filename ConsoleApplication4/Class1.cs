using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Prodavac:Radnik
    {
        private double prihod;
        public Prodavac(string ime, double procenat) : base(ime, procenat) { }
        public void Prodao(double vrednost)
        {
            prihod += vrednost;
        }
        public override double Prihod
        {
            get { return prihod; }
        }

    }
    
}
