/*
Tugas Daspro M HARRY FALAHI
*/
using System;

namespace daspro
{
    class Program
    {
        //Main Method  
         static void Main(string[] args)
        {
            //Deklarasi Variabel
            int a = 6;
            int b = 6;
            int c = 6;

            int tambah = a+b+c;
            int kali = a*b*c;

            //Menuliskan Narasi
            Console.WriteLine("Hello, World!");  
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server ");
            Console.WriteLine("Akses ke sever membutuhkan password yang tidak diketahui...");
            Console.WriteLine("- Password terdiri dari 4 angka");
            Console.WriteLine("- Jika ditambahkan maka hasilnya "+tambah);
            Console.WriteLine("- Jika dikalikan maka hasilnya "+kali);
            Console.WriteLine("");
            Console.WriteLine("Enter Code 1 :");
            string jawaban1 = Console.ReadLine();
            Console.WriteLine("Enter Code 2 :");
            string jawaban2 = Console.ReadLine();
            Console.WriteLine("Enter code 3 :");
            string jawaban3 = Console.ReadLine();
            int jawaban11 = Int32.Parse(jawaban1);
            int jawaban22 = Int32.Parse(jawaban2);
            int jawaban33 = Int32.Parse(jawaban3);
            if(jawaban11 == a && jawaban22 == b && jawaban33 == c )
            {
                Console.WriteLine("Kode Benar, Selamat Datang");
            }else
            {
                Console.WriteLine("Kode salah");
        }
    }
    }
}
    