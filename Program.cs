using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApps
{
    class Program
    {
        static void Main(String[] args)
        {

            Mobil mobil = new Mobil();

            Console.WriteLine();

            mobil.Warna = "Merah";
            mobil.Merk = "Tayota";
            mobil.Model = "Nyaris";
            mobil.tahunKeluar = "2022";
            mobil.jumlahPintu = "4";
            mobil.Kecepatan = 150.7;

            mobil.kecepatanMobil();
            mobil.klaksonMobil();
            mobil.tampilInfo();
        }
    }
}