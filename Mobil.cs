using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace myApps
{
    public class Mobil
    {
        public string Warna { get; set; }
        public string jumlahPintu { get; set; }
        public string Merk { get; set; }
        public string Model { get; set; }
        public string tahunKeluar { get; set; }
        public double Kecepatan { get; set; }

        // My Method
        public void kecepatanMobil()
        {
            Console.WriteLine($"Mobil {Merk} berjalan dengan kecepatan {Kecepatan}");
        }

        public void klaksonMobil()
        {
            Console.WriteLine("Berklakson Pim pim pim");
        }

        public void tampilInfo()
        {

            Console.WriteLine($"Mobil saya berwarna {Warna}, Merek {Merk}, Model {Model}, Keluaran Tahu {tahunKeluar}, dengan jumlah pintu sebanyak {jumlahPintu} Pintu");
        }



    }

    public class Kecepatan
    {
    }
}