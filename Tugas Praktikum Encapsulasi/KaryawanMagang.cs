using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Praktikum_Encapsulasi
{
    internal class KaryawanMagang : Karyawan
    {
        public override double HitungGaji()
        {
            double gajiTotal = base.HitungGaji();
            return gajiTotal;
        }
        public override void TampilkanInfo()
        {
            jenisKaryawan = "Karyawan Magang";
            base.TampilkanInfo();
        }
    }
}
