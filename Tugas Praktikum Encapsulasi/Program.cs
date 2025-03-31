using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Praktikum_Encapsulasi
{
    internal class Program
    {
        public static Penampung penampung = new Penampung();
        static void Main(string[] args)
        {
            awal();
        }
        public static void garis()
        {
            Console.WriteLine(new string ('═', 60));
        }
        public static void Header()
        {
            garis();
            Console.WriteLine("Tugas Hari Raya".PadLeft(35));
            garis();
        }
        public static void Enter()
        {
            Console.Write("Tekan [Enter] Untuk Melanjutkan >> ");
            Console.ReadLine();
        }
        public static void awal()
        {
            Console.Clear();
            Header();
            Console.WriteLine("1.Tambahkan Karyawan\n2.Lihat Karyawan\n3.Keluar");
            garis();
            Console.Write("Masukkan Pilihan >> ");
            string pilihan = Console.ReadLine();

            if (pilihan == "1")
            {
                TambahkanKaryawan();
            }
            else if (pilihan == "2") 
            {
                Console.Clear();
                Header();
                Console.WriteLine("");

                penampung.TampilkanKaryawan();

                Console.WriteLine("");
                garis();
                Enter();
                awal();
            }
            else if (pilihan == "3") 
            {
                absen();
            }
            else
            {
                Console.WriteLine("Pilihan Tidak Tersedia");
                Enter();
                awal();
            }

        }
        public static void TambahkanKaryawan()
        {
            Console.Clear();
            Header();
            Console.WriteLine("1.Karyawan Tetap\n2.Karyawan Kontrak\n3.Karyawan Magang");
            garis();
            Console.Write("Masukkan Pilihan >> ");
            string pilihan = Console.ReadLine();
            Console.Clear();
            Header();

            if (pilihan == "1") 
            { 
                KaryawanTetap karyawanTetap = new KaryawanTetap();

                Console.Write("Masukkan Nama Karyawan Tetap >> ");
                karyawanTetap.Nama = Console.ReadLine();

                Console.Write("Masukkan Id Karyawan Tetap >> ");
                karyawanTetap.Id = Console.ReadLine();

                Console.Write("Masukkan Gaji Pokok Karyawan Tetap >> ");
                karyawanTetap.GajiPokok = Convert.ToDouble(Console.ReadLine());
                
                garis();
                penampung.TambahKaryawan(karyawanTetap);
                Console.WriteLine("Karyawan Tetap Berhasil Ditambahkan");
                garis();

                Enter();
                awal();
            }
            else if (pilihan == "2")
            {
                KaryawanKontrak karyawanKontrak = new KaryawanKontrak();

                Console.Write("Masukkan Nama Karyawan Kontrak >> ");
                karyawanKontrak.Nama = Console.ReadLine();

                Console.Write("Masukkan Id Karyawan Kontrak >> ");
                karyawanKontrak.Id = Console.ReadLine();

                Console.Write("Masukkan Gaji Pokok Karyawan Kontrak >> ");
                karyawanKontrak.GajiPokok = Convert.ToDouble(Console.ReadLine());

                penampung.TambahKaryawan(karyawanKontrak);
                garis();
                Console.WriteLine("Karyawan Kontrak Berhasil Ditambahkan");
                garis();

                Enter(); 
                awal();
            }
            else if (pilihan == "3")
            {
                KaryawanMagang karyawanMagang = new KaryawanMagang();
                
                Console.Write("Masukkan Nama Karyawan Magang >> ");
                karyawanMagang.Nama = Console.ReadLine();
                
                Console.Write("Masukkan Id Karyawan Magang >> ");
                karyawanMagang.Id = Console.ReadLine();
                
                Console.Write("Masukkan Gaji Pokok Karyawan Magang >> ");
                karyawanMagang.GajiPokok = Convert.ToDouble(Console.ReadLine());

                penampung.TambahKaryawan(karyawanMagang);

                garis();
                Console.WriteLine("Karyawan Magang Berhasil Ditambahkan");
                garis();
                Enter();
                awal();
            }
            else
            {
                Console.WriteLine("Pilihan Tidak Valid");
                Enter();
                awal();
            }
        }
        public static void absen()
        {
            Console.Clear();
            Header();

            Console.WriteLine("\nAbsen Dulu Bang :");
            Console.WriteLine($"\nNama : Tunggul Abdul Majid" +
                $"\nNIM : 242410102058" +
                $"\nProdi : Teknologi Informasi\n");
            garis();
            Enter();
            exit();

        }
        public static void exit()
        {
            Console.Clear();
            Header();
            Console.WriteLine("\nTerima Kasih\n");
            garis();
            Enter();
        }

    }
}
