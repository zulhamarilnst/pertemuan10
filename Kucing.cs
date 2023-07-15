using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PERTEMUAN10
{
    public class Kucing : Hewan
    {
        public Kucing()
        {
            JenisHewan = "Kucing";
            JmlKaki = 4;
        }

        public override void Bersuara()
        {
            Console.WriteLine("Kucing bersuara meongg");
        }
    }
}