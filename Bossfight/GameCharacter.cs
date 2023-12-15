using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bossfight

{
    internal class GameCharacter
    {
        public int Health;
        public int Strength;
        public int Stamina;
        public string Name;
        public int MaxStamina;

        public GameCharacter(int health, int strength, int stamina, string name)
        {

            Health = health;
            Strength = strength;
            Stamina = stamina;
            MaxStamina = stamina;
            Name = name;
        }

        public static void Fight(GameCharacter Hero, GameCharacter Boss)
        {
            if (Hero.Health > 0 && Hero.Stamina > 0 && Boss.Health > 0 && Boss.Stamina > 0)
            {
                Boss.Health -= Hero.Strength;
                Boss.Stamina -= 10;
                Hero.Health -= Boss.Strength;
                Hero.Stamina -= 10;

                if (Boss.Health <= 0)
                {
                    Console.WriteLine("The hero killed the boss! Congratulations! ");
                }
                else if(Hero.Health <= 0)
                Console.WriteLine($"The Boss killed your hero. You suck. Get your ass to NAV.");
                else if (Boss.Health > 0 && Hero.Health > 0)
                {
                    Console.WriteLine($"{Boss.Name} did {Boss.Strength} damage to the {Hero.Name}!{Hero.Name}Now has {Hero.Health} health left. {Boss.Name} now has {Boss.Stamina} stamina left.");
                    Console.WriteLine($"{Hero.Name} did {Hero.Strength} damage to the {Boss.Name}!{Boss.Name}Now has {Boss.Health} health left. {Hero.Name} now has {Hero.Stamina} stamina left.");

                    if (Hero.Stamina <= 0)
                    {
                        Console.WriteLine("Your hero is out of stamina, and needs to recharge!");
                    }
                    else if (Boss.Stamina <= 0)
                    {
                        Console.WriteLine("The boss is out of stamina, and needs to recharge!");
                    }
                    
                }
                
                
            }
        }

        public void Recharge()
        {
            Stamina = MaxStamina;
        }



    }
}
