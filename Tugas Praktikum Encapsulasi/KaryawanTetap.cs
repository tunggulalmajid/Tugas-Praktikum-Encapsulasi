using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Praktikum_Encapsulasi
{
    internal class KaryawanTetap : Karyawan
    {
        private double bonusTetap = 500000;
        public KaryawanTetap()
        {
            jenisKaryawan = "Karyawan Tetap";
        }
        public override double HitungGaji()
        {
            double gajiTotal = GajiPokok + bonusTetap;
            return gajiTotal;
        }
        
    }
}
