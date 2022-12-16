using System;

namespace _2207135755_M.HARRY_FALAHI_TUGAS_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("World Voice :Welcome To Inzugama");
            Console.WriteLine("World Voice :Tell Me Your Name Master");
            MagicCaster player = new MagicCaster();
            player.Name = Console.ReadLine();
            Console.WriteLine("\nHello Master "+player.Name+"!!, Are you ready to enter this world?\nUR CHOICE (Y = YES) (N=NO)");
            string bReady = Console.ReadLine().ToUpper();
            if(bReady == "Y")
            {
                Console.WriteLine("World Voice :"+player.Name+", now you entering this world!");
                Console.WriteLine("World Voice :Watch Out Something Evil Here");
                Console.WriteLine("World Voice :Thats Elta , The Strongest Minotaur, Be Carefull");
                Enemy enemy1 = new Enemy("Elta");
                Console.WriteLine(player.Name+" is encountering "+enemy1.Name);
                Console.WriteLine(enemy1.Name+" is attacking you... ");
                Console.WriteLine("Choose an action : ");
                Console.WriteLine("1. Normal Attack");
                Console.WriteLine("2. Special Attack");
                Console.WriteLine("3. Rest");
                Console.WriteLine("4. Run Away");

                while (!player.IsDead && !enemy1.IsDead)
                {
                    string playerAction = Console.ReadLine();
                    switch(playerAction)
                    {
                        case "1":
                        Console.WriteLine("");
                        Console.WriteLine(player.Name+" is doing normal attack");
                        enemy1.Hitted(player.AtkPwr);
                        player.Exp += 0.3f;
                        enemy1.Attack(enemy1.AtkPwr);
                        player.Hitted(enemy1.AtkPwr);
                        Console.Write("Player Health : "+player.Health+" \nEnemy Health : "+enemy1.Health);
                        break;
                        case "2":
                        player.SpecialAtk();
                        player.Exp += 0.8f;
                        enemy1.Hitted(player.AtkPwr);
                        Console.Write("Player Health : "+player.Health+" \nEnemy Health : "+enemy1.Health);
                        break;
                        case "3":
                        player.Rest();
                        Console.WriteLine("You Are Resting");
                        Console.WriteLine("Energy is being restored...");
                        Console.WriteLine("Energy : "+player.SkillSlot);
                        enemy1.Attack(enemy1.AtkPwr);
                        player.Hitted(enemy1.AtkPwr);
                        Console.Write("Player Health : "+player.Health+" \nEnemy Health : "+enemy1.Health);
                        break;
                        case "4":
                        Console.WriteLine("");
                        Console.WriteLine(player.Name+" is running away...");
                        goto GAMEOVER;
                    }
                }
                Console.WriteLine(player.Name+" has "+player.Exp+" Exp point...");
                Console.Clear();
                goto GOODENDING;
            }
            else
            {
                Console.WriteLine("Okayy "+player.Name+", See you when you ready to enter this world!\nGoodbye Master!!!");
                Console.Read();
                goto NOENDING;
            } 
          GAMEOVER :
          Console.WriteLine("==========GAME OVER==========");
          Console.WriteLine("To Play Again Please Restart ");
          goto NOENDING;

          GOODENDING :
          Console.WriteLine("==========VICTORY==========");
          Console.WriteLine("Thanks For Playing The Game");

          NOENDING :
          Console.WriteLine("Goodbye and have a nice day");
        }
    }

    class MagicCaster
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AtkPwr { get; set; }
        public int SkillSlot { get; set; }
        public bool IsDead { get; set; }
        public float Exp { get; set; }
        Random rnd = new Random();

        public MagicCaster()
        {
            Health = 150;
            SkillSlot = 1;
            AtkPwr = 5;
            IsDead = false;
            Exp = 0;
            Name = "Newbie";
        }

        public void SpecialAtk()
        {
            if(SkillSlot > 1)
            {
                Console.WriteLine("SPECIAL ATTACK : METEOR STRIKE!!");
                AtkPwr = AtkPwr + rnd.Next(8,20);
                SkillSlot--; 
            }
            else
            {
                Console.WriteLine("Need More Energy!");
            }           
        }

        public void Hitted(int hitValue)
        {
            Console.WriteLine(Name+" Hitted by "+hitValue);
            Health = Health - hitValue;
            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Rest()
        {
            SkillSlot += 4;
        }

        public void Die()
        {
            Console.WriteLine("You're dead!!\n The game is over!!!\nGoodbyee! ");
            IsDead = true;
        }
    }

    class Enemy
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AtkPwr { get; set; }
        public bool IsDead { get; set; }
        Random rnd = new Random();

        public Enemy(string name)
        {
            Name = name;
            Health = 100;
        }

        public void Attack(int damage)
        {
            AtkPwr = rnd.Next(1,15);
        }

        public void Hitted(int hitValue)
        {
            Console.WriteLine(Name+" get hit by "+hitValue);
            Health = Health - hitValue;

            if(Health <= 0)
            {
                Health = 0;
                Die();
            }
        }

        public void Die()
        {
            Console.WriteLine(Name+" is dead!");
            IsDead = true;
        }
    }
}