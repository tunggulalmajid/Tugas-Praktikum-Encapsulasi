using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Praktikum_Encapsulasi
{
    internal class KaryawanKontrak : Karyawan
    {
        private double PotonganKontrak = 200000;
        public override double HitungGaji()
        {
            double gajiTotal = GajiPokok - PotonganKontrak;
            return gajiTotal;
        }
        public override void TampilkanInfo()
        {
            jenisKaryawan = "Karyawan Kontrak";
            base.TampilkanInfo();
        }
    }
}
