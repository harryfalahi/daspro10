using System;
using System.Text.RegularExpressions;

namespace UTS
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string teks,Enkripsi = "";

            String huruf = "AaBbCcDdEeFfGgHhIiJjKkLlMmNnOoPpQqRrSsTtUuVvWwXxYyZz";
            Regex rgx = new Regex("[^Az-zA-z ]");
            do
            {
                Console.Write("Teks : ");
                teks = Console.ReadLine();
            } while  (string.IsNullOrEmpty(teks) || rgx.IsMatch(teks));

            foreach (char t in teks)
            {
                char temp = ' ';
                for (int i = 0; i < huruf.Length; i++)
                {
                    char c = huruf[i];
                    if (t.Equals(c)) {
                        temp = huruf[i+3];
                        break;
                    } else if (t.Equals(' ')) {
                        temp = ' ';
                        break;
                    }            
                }
                Enkripsi = Enkripsi + temp;
            }
            Console.WriteLine("Hasil Enkripsi : " + Enkripsi);
              
        }
    }
}