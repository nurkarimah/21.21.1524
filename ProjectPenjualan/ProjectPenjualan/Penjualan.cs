using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    public class Penjualan
    {
        // PERINTAH: lengkapi property class penjualan, sesuai petunjuk soal
        public string Kode { get; private set; }
        public string Tanggal { get; private set; }
        public string Customer { get; private set; }
        public string Jenis { get; private set; }
        public int Total { get; private set; }

        public Penjualan(string kode, string tanggal, string customer, char jenis, int total)
        {
            Kode = kode;
            Tanggal = tanggal;
            Customer = customer;
            Jenis = jenis == 'T' ? "Tunai" : "Kredit";
            Total = total;
        }
    }
}
