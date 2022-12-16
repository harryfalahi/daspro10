using System;

namespace Nomor_1
{
    class Program
    {
        static void Main(string[] args)
        {
            string Nama;
            string Konsentrasi;
            int NIM;
            Console.WriteLine("");
            Console.WriteLine("Masukkan Data Nametag");
            Console.WriteLine("Nama : ");
            Nama = Console.ReadLine();
            Console.WriteLine("NIM : ");
            NIM = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Konsentrasi : ");
            Konsentrasi = Console.ReadLine().ToUpper();
            Console.WriteLine();
            
            Console.Clear();
            Console.WriteLine("Nama : "+Nama);
            Console.WriteLine("Konsentrasi: "+Konsentrasi);
            Console.WriteLine("NIM : "+NIM);
            Console.WriteLine("***************************************");
            Console.WriteLine("|               NameTag               |");
            Console.WriteLine("|           Universitas Riau          |");
            Console.WriteLine("|*************************************|");
            Console.WriteLine(String.Format("|{0, -10} : {1,24}|"," Nama ", Nama));
            Console.WriteLine(String.Format("|{0,-10} : {1,24}|"," NIM ", NIM));
            Console.WriteLine("|=====================================|");
            Console.WriteLine(String.Format("|{0,-10} : {1,24}|"," Konsen",Konsentrasi));
            Console.WriteLine("|           Thank You                 |");
            Console.WriteLine("|*************************************|");
        }     
    }    
}