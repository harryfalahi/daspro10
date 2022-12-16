using System;
using System.IO;
using System.Collections.Generic;

namespace UTS_SOAL_5
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> hurufTebakanUser  = new List<string>{};
            Random rnd = new Random();
            int kesempatan = 10;
            int RNG = rnd.Next(0, 15);
            string [] text = File.ReadAllLines("text.txt");
            string kata = text[RNG];
            
            Console.WriteLine("|=========Hangman=========|");
            Console.WriteLine("|                         |");
            Console.WriteLine("|_________________________|");
            Console.WriteLine("|        |________|       |");
            Console.WriteLine("|             |           |");
            Console.WriteLine("|            (_)          |");
            Console.WriteLine(@"|            /|\          |");
            Console.WriteLine(@"|            / \          |");
            Console.WriteLine("|                         |");
            Console.WriteLine("|=========================|");

            Console.WriteLine("Seseorang akan dieksekusi jika kamu salah menebak");
            Console.WriteLine("Selamat datang di Hangman");
            Console.WriteLine("Kamu memiliki "+kesempatan+" kesempatan menebak");
            Console.WriteLine("Kata yang akan kamu tebak terdiri dari "+kata.Length+" Kata");

            while(true)
            {   
                Console.WriteLine("Tebakan Anda");
                Console.WriteLine("Teks :");
                string input = Console.ReadLine();
                Console.Clear();

                hurufTebakanUser.Add(input);
                if(cekKata(kata,hurufTebakanUser)){
                    Console.WriteLine(" Jawabannya adalah "+kata);
                    break;
                }else if(kata.Contains(input)){
                    Console.WriteLine("Tebakan Anda Benar");
                    Console.WriteLine(cekHuruf(kata,hurufTebakanUser));
                }else{
                    Console.WriteLine("Tebakan Salah");
                    kesempatan = kesempatan-1;
                    Console.WriteLine("Tersisa "+kesempatan+" kesempatan");
                   if(kesempatan==9)
                {
                    Console.WriteLine("|=========Hangman=========|");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|=========================|");
                }
                if(kesempatan==8)
                {
                    Console.WriteLine("|=========Hangman=========|");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|_________________________|");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|=========================|");
                }
                if(kesempatan==7)
                {
                    Console.WriteLine("|=========Hangman=========|");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|_________________________|");
                    Console.WriteLine("|        |        |       |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|=========================|");
                }
                if(kesempatan==6)
                {
                    Console.WriteLine("|=========Hangman=========|");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|_________________________|");
                    Console.WriteLine("|        |________|       |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|=========================|");
                }
                if(kesempatan==5)
                {
                    Console.WriteLine("|=========Hangman=========|");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|_________________________|");
                    Console.WriteLine("|        |________|       |");
                    Console.WriteLine("|             |           |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|=========================|");
                }
                if(kesempatan==4)
                {
                    Console.WriteLine("|=========Hangman=========|");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|_________________________|");
                    Console.WriteLine("|        |________|       |");
                    Console.WriteLine("|             |           |");
                    Console.WriteLine("|            (_)          |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|=========================|");
                }
                if(kesempatan==3)
                {
                    Console.WriteLine("|=========Hangman=========|");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|_________________________|");
                    Console.WriteLine("|        |________|       |");
                    Console.WriteLine("|             |           |");
                    Console.WriteLine("|            (_)          |");
                    Console.WriteLine(@"|             |           |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|=========================|");
                }
                if(kesempatan==2)
                {
                    Console.WriteLine("|=========Hangman=========|");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|_________________________|");
                    Console.WriteLine("|        |________|       |");
                    Console.WriteLine("|             |           |");
                    Console.WriteLine("|            (_)          |");
                    Console.WriteLine(@"|            /|\          |");
                    Console.WriteLine(@"|                         |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|=========================|");
                }
                if(kesempatan==1)
                {
                    Console.WriteLine("|=========Hangman=========|");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|_________________________|");
                    Console.WriteLine("|        |________|       |");
                    Console.WriteLine("|             |           |");
                    Console.WriteLine("|            (_)          |");
                    Console.WriteLine(@"|            /|\          |");
                    Console.WriteLine(@"|            / \          |");
                    Console.WriteLine("|                         |");
                    Console.WriteLine("|=========================|");
                }
                if(kesempatan==0)
                {
                    Console.WriteLine("Game Over, Katanya adalah "+kata);
                    Console.WriteLine("Kamu gagal menyelamatkan orang yang akan dieksekusi");
                    break;
                }
                }
            }
        }
        static string cekHuruf(string text, List<string> tebakanUser)
        {
            string display = "";
            for(int i=0; i<text.Length;i++)
            {
                string s = Convert.ToString(text[i]);
                if(tebakanUser.Contains(s))
                {
                    display += s;
                }else{
                    display += '*';
                }
            }
            return display;
        }
        static bool cekKata(string text, List<string> tebakanUser)
        {
            bool b = false;
            for(int i=0; i<text.Length;i++)
            {
                string s = Convert.ToString(text[i]);
                if(tebakanUser.Contains(s))
                {
                    b = true;
                }else{
                    return b = false;
                }
            }
            return b;
        }
    }
}
