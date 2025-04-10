﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tugas_Praktikum_Encapsulasi
{
    internal class Karyawan
    {
        private string _nama, _id;
        private double _gajiPokok;
        public string jenisKaryawan = "Karyawan";
        public string Nama
        {
            get { return _nama; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    _nama = value;
                }
                else 
                {
                    _nama = "";
                    Console.WriteLine("Nama Harus Melebihi 2 Karakter");
                    Program.Enter();
                }
            }
        }
        public string Id
        {
            get { return _id; }
            set
            {
                if (value != null && value.Length > 2)
                {
                    _id = value;
                }
                else 
                {
                    _id = "";
                    Console.WriteLine("Id Tidak Boleh Kosong");
                }
            }
        }
        public double GajiPokok
        {
            get { return _gajiPokok; }
            set
            {
                if (value > 0 && Convert.ToString(value) != null)
                {
                    _gajiPokok = value;
                }
                else
                {
                    Console.WriteLine("Gaji Pokok Tidak boleh Minus");
                }
            }
        }
        public virtual double HitungGaji()
        {
            double gajiTotal = GajiPokok ;
            return gajiTotal;
        }
        public override string ToString()
        {
            double jumlahGaji = HitungGaji();
            return $"Nama Karyawan : {Nama}\nJenis Karyawan : {jenisKaryawan}\nId Karyawan : {Id}\nTotal Gaji : {jumlahGaji}";
        }
    }
}
