using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Praktikum_Encapsulasi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            KaryawanTetap Tetap = new KaryawanTetap();
            Tetap.Nama = "Tunggul Abdul Majid";
            Tetap.Id = "242410102058";
            Tetap.GajiPokok = 5500000;
            Tetap.TampilkanInfo();

            KaryawanKontrak Kontrak = new KaryawanKontrak();
            Kontrak.Nama = "Rafi Hadianto Aribowo";
            Kontrak.Id = "242410102006";
            Kontrak.GajiPokok = 5500000;
            Kontrak.TampilkanInfo();

            KaryawanMagang Magang = new KaryawanMagang();
            Magang.Nama = "Roihan Nadzif";
            Magang.Id = "242410102028";
            Magang.GajiPokok = 5500000;
            Magang.TampilkanInfo();
        }
    }
}
