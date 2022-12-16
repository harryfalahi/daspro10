using System;

namespace UTS_SOAL_3
{
    class Program
    {
        static void ticketBioskop(string Nama, int tahunLahir)
        {
            int Usia = 2022-tahunLahir;
            if(Usia<10 && Usia>0 || Usia>60)
            {
                int harga = 10000;
                Console.WriteLine("***************************************");
                Console.WriteLine("|             BIOSKOP XXX             |");
                Console.WriteLine("|               Studio 1              |");
                Console.WriteLine("|*************************************|");
                Console.WriteLine(String.Format("|{0, -10} : {1,24}|"," Nama ", Nama));
                Console.WriteLine(String.Format("|{0,-10} : {1,24}|"," Usia ", Usia));
                Console.WriteLine("|=====================================|");
                Console.WriteLine(String.Format("|{0,-10} : {1,24}|"," Rp.",harga));
                Console.WriteLine("|*************************************|");
            }else if(Usia<0)
            {
                Console.WriteLine("Usia Invalid");
            }else{
                int harga = 25000;
                Console.WriteLine("***************************************");
                Console.WriteLine("|             BIOSKOP XXX             |");
                Console.WriteLine("|               Studio 1              |");
                Console.WriteLine("|*************************************|");
                Console.WriteLine(String.Format("|{0, -10} : {1,24}|"," Nama ", Nama));
                Console.WriteLine(String.Format("|{0,-10} : {1,24}|"," Usia ", Usia));
                Console.WriteLine("|=====================================|");
                Console.WriteLine(String.Format("|{0,-10} : {1,24}|"," Rp.",harga));
                Console.WriteLine("|*************************************|");
            }
        }
        static void Main(string[] args)
        {
            string Nama;
            int tahunLahir;
            Console.WriteLine("Selamat Datang di bioskop XXX");
            Console.WriteLine("Untuk mengecek harga tiket anda, silahkan masukkan data diri anda");
            Console.WriteLine("Nama : ");
            Nama = Console.ReadLine();
            Console.WriteLine("Tahun Lahir : ");
            tahunLahir = Convert.ToInt32(Console.ReadLine());
            ticketBioskop(Nama,tahunLahir);          
        }
    }
}
