using System;

namespace ResponsiPemograman3394
{
    class Program
    {
        static void Main(string[] args)
        {
            Karyawan karyawan1 = new Karyawan(190302123, "paijo", 3000000);
            Karyawan karyawan2 = new Karyawan(190302124, "jono", 2000000);

            Console.WriteLine("\n");
            Console.WriteLine("|No.\t NIK \t  NIM \t Nama \t \t Gaji|");
            Console.WriteLine("\n");
            Console.WriteLine(karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);

            Console.WriteLine("\n Selamat Kamu mendapatkan kenaikan gaji sebesar 10% \n");

            Console.WriteLine("|No.\t NIK \t  NIM \t Nama \t \t Gaji|");
            Console.WriteLine("\n");
            Console.WriteLine(karyawan1.NIK, karyawan1.Nama, karyawan1.GajiBulanan);
            Console.WriteLine(karyawan2.NIK, karyawan2.Nama, karyawan2.GajiBulanan);
            Console.ReadKey();

        }
    }
}
