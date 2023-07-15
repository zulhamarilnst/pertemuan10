using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PERTEMUAN10
{
    public abstract class Hewan
    {
        public string JenisHewan { get; set; }
        public int JmlKaki { get; set; }
        public abstract void Bersuara();
    }
}