using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Praktikum_Encapsulasi
{
    internal class Penampung
    {
        private List<Karyawan> PenampungKaryawan;
        public Penampung()
        {
            PenampungKaryawan = new List<Karyawan>();
        }
        public void TambahKaryawan(Karyawan karyawan)
        {
            if (karyawan.Nama.Length > 0 && karyawan.Id.Length > 2 && karyawan.GajiPokok > 0)
            {
                PenampungKaryawan.Add(karyawan); 
                Console.WriteLine($"{karyawan.jenisKaryawan} Berhasil Ditambahkan");

            }
            else
            {
                Console.WriteLine("Karyawan tidak Berhasil ditambahkan, silahkan ulangi proses");
            }
        }
        public void TampilkanKaryawan()
        {
            if (PenampungKaryawan.Count > 0)
            {
                for (int i = 0; i < PenampungKaryawan.Count; i++)
                {
                    Console.WriteLine($"{PenampungKaryawan[i]}\n");
                }
            }
            else
            {
                Console.WriteLine("Belum Ada Karyawan yang di Inputkan");
            }
        }
    }
}
