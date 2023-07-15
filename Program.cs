using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PERTEMUAN10
{
     internal class Program
    {
        static void Main(string[] args)
        {
            Hewan Ayam = new Ayam();
            Hewan Kucing = new Kucing();

            Console.WriteLine("Pilih jenis hewan yang dimaksud [1...2]: ");
            int Pilih = Convert.ToInt32(Console.ReadLine());

            // Pengkondisian
            if (Pilih == 1)
                Ayam.Bersuara();
            else if (Pilih == 2)
                Kucing.Bersuara();
            else
                Console.WriteLine("Jenis hewan yang kamu pilih tidak valid");

            Console.ReadKey();
        }
    }
}

