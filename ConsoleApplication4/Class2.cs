using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    public class Sef:Radnik
    {
        private Radnik[] podredjeni;
        private int brPod = 0;
        public Sef(string ime, double procenat, int kap)
            : base(ime, procenat) {
                podredjeni = new Radnik[kap];
        }
        public bool Dodeli(Radnik r)
        {
            if (brPod == podredjeni.Length) return false;
            podredjeni[brPod++] = r; return true;
        }
        public override double Prihod
        {
            get { double p = 0; for (int i = 0; i < brPod; p += podredjeni[i++].Prihod);
            return p;
            }
        }
    }
}
