using System;

namespace UTS_SOAL_2
{
    class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Konversi mata uang");
                Console.WriteLine("Masukkan Kurs Saat ini :");
                decimal kurs = decimal.Parse(Console.ReadLine());

                Console.WriteLine("");
                Console.WriteLine("Masukkan nilai USD");
                Console.Write("$");
                decimal inputDollar = Convert.ToDecimal(Console.ReadLine());        
                decimal hasil =  inputDollar*kurs;

                Console.WriteLine(string.Format("$"+inputDollar+" -> Rp."+hasil));         
            }
        }
    }

