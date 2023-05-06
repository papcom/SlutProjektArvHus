using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlutProjektArvHus
{
    class Hus
    {
        public string Färg { get; set; }
        public Hus(string färg)
        {
            Färg = färg;
        }
        public void SkrivFärg()
        {
            Console.WriteLine("Detta är ett " + Färg + " hus.");
        }
    }
    class RöttHus : Hus
    {
        public RöttHus() : base("rött") { }
    }
    class BlåttHus : Hus
    {
        public BlåttHus() : base("blått") { }
    }
}