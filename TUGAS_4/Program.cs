/*
    M.HARRY FALAHI (2207135755)
    T.Informatika B
*/
using System;
namespace Tugas_Ke_4
{
    class Program
    {
        static void Main(string[] args)
        {
            try{
            //Variabel yang akan digunakan:
            int warZoneLength = 5;
            
            char tank = 't';
            char ground = '#';
            char onPointHit =  'x';
            char missHit = '0';
            int tankTotal = 9;

            //Area perang berupa array 2d yang akan berbentuk koordinat
            char[,] warZone = createdwarZone(warZoneLength, ground, tank, tankTotal);

            //Jumlah tank yang sembunyi di area perang
            int unknownTankDetected = tankTotal;

            //Intro Game
            Console.WriteLine("BATTLE TANK DASPRO\n");
            Console.ReadLine();
            Console.WriteLine("Welcome to Battle Tank!");  
            Console.WriteLine("You will win this game after you guess all tank in the right area!");
            Console.WriteLine("Enjoy and Try to complete the game!");
            Console.WriteLine();
            Console.WriteLine("Enter To Continue");
            Console.ReadLine();
            Console.Clear();
            
            //print array ke bentuk 2d
            printwarZone(warZone, ground, tank);

            //Gameplay
            while(unknownTankDetected > 0){
                int[] guessCoordinates = getUserGuessedCoor(warZoneLength);
                char locationViewUpdate = verifyGuessAndTarget(guessCoordinates, warZone, tank, ground, onPointHit, missHit);           
                if(locationViewUpdate == onPointHit)
                {
                    unknownTankDetected--;
                    if(unknownTankDetected <= 1 ){
                        Console.WriteLine(unknownTankDetected+" Tank Remaining");
                    }else{
                        Console.WriteLine(unknownTankDetected+" Tanks Remaining");
                    }
                }
               warZone =updateWarZone(warZone, guessCoordinates, locationViewUpdate);
                printwarZone(warZone, ground, tank);
            }   
                Console.WriteLine("Good Job                          ");
                Console.WriteLine("You've Guessed All Tanks Position!");
                Console.WriteLine("Thanks For Playing This Game\n");
                Console.WriteLine("See You Laterr");
                Console.Read();
            }
            catch(System.FormatException){
                Console.WriteLine("Please Only Input Number!");
                Console.ReadLine();
            }
            catch(System.Exception){
                Console.WriteLine("Sorry Error");
                Console.WriteLine("Make Sure You Just Inputting Number");
                Console.ReadLine();
            }
        }

        //Print array 2d ke console
        private static void printwarZone(char[,] warZone, char ground, char tank){
            Console.Write("   ");
            for(int i = 0; i < 5; i++)
            {
                Console.Write(i + 1 + "  ");
            }
            Console.WriteLine();

            for (int row = 0; row < 5; row++)
            {
                Console.Write(row + 1 + "  ");
                for (int column = 0; column < 5; column++)
                {
                    char position =warZone[row,column];
                    if(position == tank){
                        Console.Write(ground + "  ");
                    }else{
                        Console.Write(position + "  ");
                    }
                }
                Console.WriteLine();
            }
        }

        //Cek tebakan player (apakah yang ditebak kena / kosong / sudah ditebak)
        private static char verifyGuessAndTarget(int[] guessCoordinates, char[,] warZone, char tank, char ground, char onPointHit, char missHit){
            string message;
            int row = guessCoordinates[0];
            int column = guessCoordinates[1];
            char target =warZone[row,column];

            if(target == tank){
                message = "ONE TANK DESTROYED ! On Point Area Guessed!!";
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                target = onPointHit;
            }else if(target == ground){
                message = "YOU GUESS THE WRONG AREA ! No Tank Here!";
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                target = missHit;
            }else{
                message = "This Area Already Clear!";
                Console.WriteLine(" ");
                Console.WriteLine(" ");
            }

            if (message == "ONE TANK DESTROYED ! On Point Area Guessed!"){
                Console.WriteLine(message);
            }else if(message == "YOU GUESS THE WRONG AREA ! No Tank Here!"){
                Console.WriteLine(message);
            }else{
                Console.WriteLine(message);
            }
            return target;
        }

         //Array 2d Area
        private static char[,] createdwarZone(int warZoneLength, char ground, char tank, int tankTotal){
            char[,]warZone = new char[warZoneLength,warZoneLength];
            for(int row = 0; row <warZoneLength; row++)
            {
                for(int column = 0; column <warZoneLength; column++)
                {
                   warZone[row,column] = ground;
                }
            }
            return placeTanks(warZone, tankTotal, ground, tank);
        }

        //Meletakkan 3 buah tank didalam area perang array 2d secara random
        private static char[,] placeTanks(char[,] warZone, int tankTotal, char ground, char tank){
            int placedTanks = 0;
            int warZoneLength = 5;

            while(placedTanks < tankTotal){
                int[] tankLocation = generateTankCoordinate(warZoneLength);
                char positionFixed = warZone[tankLocation[0], tankLocation[1]];

                if(positionFixed == ground){
                   warZone[tankLocation[0], tankLocation[1]] = tank;
                    placedTanks++;
                }
            }
            return warZone;
        }

        //Membuat Posisi Random Tanks di Dalam Area Perang Array 2d
        private static int[] generateTankCoordinate(int warZoneLength){
            Random rnd = new Random();
            int[] coordinates = new int [2];
            for(int i = 0; i < coordinates.Length; i++){
                coordinates[i] = rnd.Next(warZoneLength);
            }
            return coordinates;
        }

        //Update Tampilan Area Perang Setelah Player Menebak
        private static char[,] updateWarZone(char[,] warZone, int[] guessCoordinates, char locationViewUpdate){

            int row = guessCoordinates[0];
            int column = guessCoordinates[1];
           warZone[row,column] = locationViewUpdate;
            return warZone;
        }

        //Hasil Tebakan Player
        private static int[] getUserGuessedCoor(int warZoneLength){
            int row;
            int column;

            do{
                Console.Write("CHOOSE ROW : ");
                row = Convert.ToInt32(Console.ReadLine());
            }while(row < 0 || row >warZoneLength + 1);

            do{
                Console.Write("CHOOSE COLUMN : ");
                column = Convert.ToInt32(Console.ReadLine());
            }while(column < 0 || column >warZoneLength + 1);

            return new[]{row-1, column -1};
        }
    }
}