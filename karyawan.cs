using System;
using System.Collections.Generic;
using System.Text;

namespace ResponsiPemograman3394
{
    class karyawan
    {
        public int NIK { get; get; }
        public string Nama { get; get; }
        public double GajiBulanan { get; get; }
        public double NaiikGajiBulanan { get; get; }

        public karyawan (int NIK, string Nama, double GajiBulanan)
        {
            this.NIK = NIK;
            this.Nama = Nama;

            if (GajiBulanan < 0)
            {
                this.GajiBulanan = 0;
            }
            else 
            {
                this.GajiBulanan = GajiBulanan;
            }

            double tambah= 0;
            tambah = 0.1 * GajiBulanan;
            NaikGajiBulanan = Convert.ToInt32(tambah) * GajiBulanan;

        }

      


    }
}
