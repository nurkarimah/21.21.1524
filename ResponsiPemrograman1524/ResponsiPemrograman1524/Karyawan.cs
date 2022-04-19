namespace ResponsiPemrograman1524
{
    public class Karyawan
    {

        public string Nik { get; set; }
        public string Nama { get; set; }
        public int GajiBulanan { get; set; }

        public void infoGajiKaryawan()
        {
            if (GajiBulanan < 1)
            {
                Console.WriteLine("Gaji Bulanan Tidak Valid");
            }
            else
            {
                Console.WriteLine("No NIK/Nama              Gaji Bulanan");
                Console.WriteLine("-------------------------------------");
                Console.WriteLine("1. {0}/{1}             Rp.{2:#,0}", Nik, Nama, GajiBulanan);
                naikGajiKaryawan();
            }
        }

        public void naikGajiKaryawan()
        {
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");


            Console.WriteLine("Assyikk naik gaji 10% nich");
            int naik = (GajiBulanan / 100) * 10;
            int hasilAkhir = naik + GajiBulanan;
            Console.WriteLine("No NIK/Nama              Gaji Bulanan");
            Console.WriteLine("-------------------------------------");
            Console.WriteLine("1. {0}/{1}             Rp.{2:#,0}", Nik, Nama, hasilAkhir);
        }
    }
}
