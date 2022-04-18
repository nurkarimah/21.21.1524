namespace LatihanClass
{
    class Program
    {
        static void Main(string[] args)
        {
            // membuat instan class / object
            //Time objTime = new Time();
            // memanggil method pada class tersebut
            //objTime.DisplayCurrentTime();
            //bisa diakses karena access modifier public
            //objTime.year = 2010;

            /*Time objTime = new Time();
            //memberi nilai property
            objTime.Year = 2009;
            objTime.Month = 5;
            objTime.Date = 1;
            //mengambil nilai dengan property
            Console.WriteLine("Year : {0}", objTime.Year.ToString());
            Console.WriteLine("Month : {0}", objTime.Month.ToString());
            Console.WriteLine("Date : {0}", objTime.Date);
            */

            Time objTime = new Time(1999,07,02,05,00,32);
            // mengambil nilai dengan property
            Console.WriteLine("Year : {0}", objTime.Year.ToString());
            Console.WriteLine("Month : {0}", objTime.Month.ToString());
            Console.WriteLine("Date : {0}", objTime.Date);
            Console.WriteLine("Hour : {0}", objTime.Hour);
            Console.WriteLine("Minute : {0}", objTime.Minute);
            Console.WriteLine("Second : {0}", objTime.Second);
        }

    }

}
