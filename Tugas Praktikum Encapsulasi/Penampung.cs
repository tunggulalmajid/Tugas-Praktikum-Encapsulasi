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
            PenampungKaryawan.Add(karyawan);
        }
        public void TampilkanKaryawan()
        {
            for (int i = 0; i < PenampungKaryawan.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {PenampungKaryawan[i]}");
            }
        }
    }
}
