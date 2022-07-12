using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectPenjualan
{
    class Program
    {
        // deklarasi objek collection untuk menampung objek penjualan
        static List<Penjualan> daftarPenjualan = new List<Penjualan>();

        static void Main(string[] args)
        {
            Console.Title = "Responsi UAS Matakuliah Pemrograman";

            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahPenjualan();
                        break;

                    case 2:
                        TampilPenjualan();
                        break;

                    case 3: // keluar dari program
                        System.Environment.Exit(0);
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            Console.Clear();
            Console.WriteLine("Pilih Menu Aplikasi\n");
            Console.WriteLine("1. Tambah Penualan");
            Console.WriteLine("2. Tampilkan Penjualan");
            Console.WriteLine("3. Keluar");
        }

        static void TambahPenjualan()
        {
            Console.Clear();

            string nota;
            string tanggal;
            string customer;
            char jenis;
            int total;

            Console.WriteLine("Tambah Data Penjualan\n");

            Console.Write("Nota: ");
            nota = Console.ReadLine().Trim();
            Console.Write("Tanggal: ");
            tanggal = Console.ReadLine().Trim();
            Console.Write("Customer: ");
            customer = Console.ReadLine().Trim();
            Console.Write("Jenis [T/K]: ");
            jenis = Char.Parse(Console.ReadLine());
            Console.Write("Total Nota: ");
            total = Int32.Parse(Console.ReadLine());

            daftarPenjualan.Add(new Penjualan(nota, tanggal, customer, jenis, total));

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilPenjualan()
        {
            Console.Clear();

            Console.WriteLine("Data Penjualan\n");

            int i = 1;
            foreach(Penjualan p in daftarPenjualan)
            {
                Console.WriteLine("{0}. {1}, {2}, {3}, {4}, {5}", i++, p.Kode, p.Tanggal, p.Customer, p.Jenis, p.Total);
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
