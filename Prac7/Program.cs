using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq.Expressions;
using System.Runtime.Intrinsics.X86;
using System.Security.Cryptography;

namespace Prac7
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }

        public static void createPlayer1()
        {
//            Console.WriteLine("Enter Name: ");
//            string name = Console.ReadLine();
            Console.WriteLine("Enter experience: ");
            int experience = Convert.ToInt16(Console.ReadLine());
            Army army1 = new Army(); 
            addWarriors(army1, experience);
//            Army(name, experience);
//            addWarriors(army1, experience));
        }
        
        public static void createPlayer2()
        {
//            Console.WriteLine("Enter Name: ");
//            string name = Console.ReadLine();
            Console.WriteLine("Enter experience: ");
            int experience = Convert.ToInt16(Console.ReadLine());
            Army army2 = new Army();
            addWarriors(army2, experience);
            
        }
        // adding warriors to a stack
        public static void addWarriors(Army army, int experience)
        {
            int money = 3;
            int numberOfCavalry = 0;
            int numberOfArchers = 0;
            int numberOfSoldiers = 0;
            
            while (money > 0)
            {
                while (money >= Cavalry.getCost() && numberOfCavalry != 0)
                {
                    if (money < numberOfCavalry * Cavalry.getCost());
                    if (money >= numberOfCavalry * Cavalry.getCost())
                    {
                        for (int i = 0; i < numberOfCavalry; i++)
                        {    
                            Cavalry calvary = new Cavalry();
                                
                            army.PushWarriors();
                        }
                    }
                }
            }
        }
    }

    class Soldier
    {
        public Soldier(int life, int experience)
        {
            
            Life = life ;
            Experience = experience;
        }

        public int Experience { get; set; }

        public int Life { get; set; }

        public int Cost { get; set; }
        
        public int Speed { get; set; }

//        
//        public int Life { get; set; }
//
//        public int Experience { get; set; }
//
//        public int cost = 1;
//        private int _name;
//        public string Name { get; set; } = "Soldier";
//
//        public int speed { get; set; };

        public static bool isAlive(Soldier soldier)
        {
            if (soldier.Life > 0)
            {
                return true;
            }
        }

        public static void loseLife(Soldier soldier, int lostLife)
        {
            soldier.Life -= lostLife;    
        }

        public static void gainExperience(Soldier soldier, int gainedExperience)
        {
            soldier.Experience += gainedExperience;
        }

        public static int getCost(Soldier soldier)
        {
            return soldier.Cost;
        }

        public static int getSpeed(Soldier soldier)
        {
            return soldier.Speed;
        }

        public static void Defend(Soldier soldier, int damage)
        {
            if (damage > soldier.Experience)
            {
                soldier.Life -= 1;
            }
        }

        public static string str(Soldier soldier)
        {
            Console.WriteLine("{0} {1} {2}", soldier.Cost, soldier.Life, soldier.Experience);
        }
        
    }

    class Archer
    {
        public Archer(int life, int experience)
        {
            Life = life ;
            Experience = experience;
        }
        
        private int cost = 1;
        public int Life { get; set; }
        public int Experience { get; set; }
        public string Name { get; set; } = "Archer";
        

        public static bool isAlive(Soldier soldier)
        {
            if (soldier.Life > 0)
            {
                return true;
            }
        }

        public static void loseLife(Soldier soldier, int lostLife)
        {
            soldier.Life -= lostLife;    
        }

        public static void gainExperience(Soldier soldier, int gainedExperience)
        {
            soldier.Experience += gainedExperience;
        }

        public static int getCost(Soldier soldier)
        {
            return soldier.Cost;
        }

        public static int getSpeed(Soldier soldier)
        {
            return soldier.Speed;
        }

        public static void Defend(Soldier soldier, int damage)
        {
            if (damage > soldier.Experience)
            {
                soldier.Life -= 1;
            }
        }

        public static string str(Soldier soldier)
        {
            Console.WriteLine("{0} {1} {2}", soldier.Cost, soldier.Life, soldier.Experience);
        }
        
    }
    
    class Cavalry
    {
        public Cavalry(int life, int experience)
        {
            Life = life ;
            Experience = experience;
        }

        private static int cost = 1;
        public int Life { get; set; }
        public int Experience { get; set; }
        public string Name { get; set; } = "Archer";
        
        public static bool isAlive(Soldier soldier)
        {
            if (soldier.Life > 0)
            {
                return true;
            }
        }

        public static void loseLife(Soldier soldier, int lostLife)
        {
            soldier.Life -= lostLife;    
        }

        public static void gainExperience(Soldier soldier, int gainedExperience)
        {
            soldier.Experience += gainedExperience;
        }

        public static int getCost()
        {
            return cost;
        }

        public static int getSpeed(Soldier soldier)
        {
            return soldier.Speed;
        }

        public static void Defend(Soldier soldier, int damage)
        {
            if (damage > soldier.Experience)
            {
                soldier.Life -= 1;
            }
        }

        public static string str(Soldier soldier)
        {
            Console.WriteLine("{0} {1} {2}", soldier.Cost, soldier.Experience, soldier.Experience);
        }
        
    }

    class Army
    {
        
        // Not a list of soldiers
        // List of warrior objects - an army
        // implement a list of warriors
        // soldier is a "type" of warrior!
        public Army(string name, int experience)
        {
            Name = name;
            Experience = experience;
        }

        static List<Army> army = new List<Army>();
        static int Experience { get; set; }
        static string Name { get; set; }
        
        public static bool isEmpty()
        {
            if (army.Count == 0)
            {
                return false;
            }
        }
        
        public static PushWarrior()
    }
}