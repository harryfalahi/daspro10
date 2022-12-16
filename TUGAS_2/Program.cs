/*
M HARRY FALAHI (2207135755)
Teknik Informatika B
*/

using System;
namespace DasPro
{
    class Program
    {
        //Deklarasi variable
        static Random rnd = new Random();
        static int level =1;
        static int kodeA ;
        static int kodeB ;
        static int kodeC ; 
        static int hasilTambah;
        static int hasilKali;
        static int hasilTambah2;
        static int hasilKali2;
        static int hasilTambah3;
        static int hasilKali3;
        static int hasilTambah4;
        static int hasilKali4;
        static int kesempatan = 3;
        static int tebakanA =0 ;
        static int tebakanB =0 ;
        static int tebakanC =0 ;
        static bool bGameStart ;
        static void Init()
        {
            //Operasi Aritmatika
            kodeA =rnd.Next(0, 3*level);
            kodeB =rnd.Next(0, 3*level);
            kodeC =rnd.Next(0, 3*level);
            hasilTambah = kodeA+kodeB+kodeC;
            hasilKali = kodeA*kodeB*kodeC;
            hasilTambah2 = kodeA+kodeB;
            hasilKali2 = kodeA*kodeB;
            hasilTambah3 = kodeA+kodeC;
            hasilKali3 = kodeA*kodeC;
            hasilTambah4 = kodeB+kodeC;
            hasilKali4 = kodeB*kodeC;
        }

        static void Intro()
        {
            //Ini awal mula game
            Console.WriteLine("______________________________________________");
            Console.WriteLine("          [T][E][B][A][K] [K][O][D][E]");
            Console.WriteLine("^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^^");
            Console.WriteLine("      Dibuat oleh M.HARRY FALAHI 2207135755 ");
            Console.WriteLine("      Dosen Pembimbing :Rahmat Rizal, ST, MT");
            Console.WriteLine(" ");
            Console.WriteLine(" ");
            Console.WriteLine("Anda adalah agen rahasia yang bertugas mendapatkan data dari server");
            Console.WriteLine("Akses ke server membutuhkan password yang tidak diketahui...");      
        }

        static void PlayGame()
        {   
            Init();
            //Inti Gamenya         
            Console.WriteLine(" ");
            Console.WriteLine("Kode terdiri dari 3 angka");
            Console.WriteLine(" ");
            Console.WriteLine("> Jika Semua Kode Ditambahkan Hasilnya "+hasilTambah);
            Console.WriteLine("> Jika Semua Kode Dikalikan Hasilnya "+hasilKali);
            Console.WriteLine("> Jika Kode 1 dan 2 Ditambahkan Hasilnya "+hasilTambah2);
            Console.WriteLine("> Jika Kode 1 dan 2 Dikalikan Hasilnya "+hasilKali2);
            Console.WriteLine("> Jika Kode 1 dan 3 Ditambahkan Hasilnya "+hasilTambah3);
            Console.WriteLine("> Jika Kode 1 dan 3 Dikalikan Hasilnya "+hasilKali3);
            Console.WriteLine("> Jika Kode 2 dan 3 Ditambahkan Hasilnya "+hasilTambah4);
            Console.WriteLine("> Jika Kode 2 dan 3 Dikalikan Hasilnya "+hasilKali4);
            Console.WriteLine(" ");
            Console.Write("-Kode pertama :");
            tebakanA = Convert.ToInt32 (Console.ReadLine());
            Console.Write("-Kode kedua : ");
            tebakanB = Convert.ToInt32 (Console.ReadLine());
            Console.Write("-Kode ketiga : ");
            tebakanC = Convert.ToInt32 (Console.ReadLine());
            Console.WriteLine("Tebakan anda "+tebakanA+" "+tebakanB+" "+tebakanC+" ?");

            if(tebakanA == kodeA  && tebakanB == kodeB && tebakanC == kodeC)
            {
                Console.WriteLine(" ");
                Console.WriteLine("Tebakan anda benar");
                level ++;
                Console.WriteLine(" ");
                if(level <6) 
                {
                    Console.WriteLine("Naik Level "+level);
                }
                Console.WriteLine("Enter untuk lanjut");
                Console.ReadLine();
                Console.Clear();
            }
            else
            {
                kesempatan-- ;
                Console.WriteLine(" ");
                Console.WriteLine("Tebakan anda salah...");
                Console.WriteLine("Sisa Percobaan: "+kesempatan);
                Console.WriteLine("Enter untuk lanjut");
                Console.ReadLine();
                Console.Clear();
            }                
        }

        static void ShowEnd()
        {
            Console.Clear();
            if(kesempatan ==0)
            {
                Console.WriteLine("KODE SALAH");
                Console.WriteLine("Anda Kurang Pintar!");
                Console.WriteLine("Silahkan Coba Lagi Dilain Waktu");
                Console.ReadLine();
                bGameStart = false;
            }            
        }
        static void Menang()
        {      
                Console.WriteLine("KODE BENAR ");
                Console.WriteLine("");
                Console.WriteLine("Selamat anda orang terpintar di dunia!");
                Console.WriteLine("tekan enter buat keluar");
                Console.ReadLine(); 
                Console.Clear();
                bGameStart = false;
        }         

         //Main Method
        static void Main(string[] args)
        {
            bGameStart = true;
            Intro();
            Console.WriteLine("Silahkan Enter");
            Console.ReadLine();
            Console.Clear();
            while(bGameStart)
            {     
                if(kesempatan >0)
                {
                    if(bGameStart==true)
                    {
                    PlayGame();
                    }
                    if (level ==6)
                    {
                        Menang();
                    }
                    Console.Clear();
                }
                else
                {
                    ShowEnd();
                    Console.Clear();
                }
            }
            Console.WriteLine("Tekan enter untuk lanjut");
            Console.ReadLine();
        }    
    }
}