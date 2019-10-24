using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kubik_bambang
{
    class Program
    {
        static void Main(string[] args)
        {
        masalah:
            //Masalah
            Console.WriteLine("Bambang mempunyai air dengan volume 98 cm^3.");
            Console.WriteLine("Masukkan Nilai wadahnya:");

            //Input ukuran wadah
            Console.WriteLine("Masukkan Nilai Panjang wadahnya:");
            double panjang = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan Nilai Lebar wadahnya:");
            double lebar = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Masukkan Nilai  Tinggi wadahnya:");
            double tinggi = Convert.ToInt32(Console.ReadLine());

            //Deklarasi dan logika
            double kubik = panjang * lebar * tinggi;
            string hasil;
            if (kubik == 98)
            {
                hasil = "Air dan wadah Pas";
            }
            else if (kubik < 98)
            {
                hasil = "Air itu akan tumpah";
            }
            else
            {
                hasil = "Wadah itu menyisakan tempat";
            }

            //Hasil
            Console.WriteLine("Anda memasukkan :");
            Console.WriteLine("Panjang = " + panjang);
            Console.WriteLine("Lebar = " + lebar);
            Console.WriteLine("Tinggi = " + tinggi);
            Console.WriteLine("Maka, " + hasil);

            //pengulangan
            Console.WriteLine("::Apakah Anda ingin mengulang?(Y/N)::");
            string ulang = Console.ReadLine();
            if (ulang == "Y" || ulang == "y")
            {
                goto masalah;
            }
            else if (ulang == "N" || ulang == "n")
            {
                Console.WriteLine("::PROGRAM SELESAI::");
            }
            Console.ReadKey();
        }
    }
}
