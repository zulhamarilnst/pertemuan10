using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PERTEMUAN10
{
     public class Ayam : Hewan
    {
        public Ayam()
        {
            JenisHewan = "Ayam";
            JmlKaki = 2;
        }

        public override void Bersuara()
        {
            Console.WriteLine("Ayam bersuara kukuruyukk");
        }
    }
}