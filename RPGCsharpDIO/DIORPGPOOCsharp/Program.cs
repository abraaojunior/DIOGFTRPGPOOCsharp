using System;
using DIORPGPOOCsharp.src.Entities;

namespace DIORPGPOOCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            {
            /*
            string nome1 = "Arus";
            int level1 = 12;
            string tipoHeroi1 = "Guereiro";
            string nome2 = "Wedge";
            int level2 = 20;
            string tipoHeroi2 = "Ninja";
            Console.WriteLine(nome1 + " " + level1 + " " + tipoHeroi1);
            Console.WriteLine(nome2 + " " + level2 + " " + tipoHeroi2);
            */

            /*
            Arus hero = new Arus();
            hero.Name = "Arus";
            hero.Level = 12;
            hero.HeroType = "Guerreiro";
            Console.WriteLine(hero.Name + " " + hero.Level + " " + hero.HeroType);
            */

            /*
            Arus hero = new Arus("Arus", 12, "Guerreiro");
            Arus oponnet = new Arus("Malefius", 99, "Devil");
            Arus wizard = new Arus("Jennica", 23, "White Wizard");
            Console.WriteLine(hero);
            Console.WriteLine(hero.Name + " " + hero.Level + " " + hero.HeroType);
            Console.WriteLine(hero.Attack());
            Console.WriteLine(wizard.Attack());
            */

            /*
            Hero arus = new Hero("Arus", 12, "Guerreiro");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            Console.WriteLine(arus.Name + " " + arus.Level + " " + arus.HeroType);
            Console.WriteLine(wizard.Name + " " + wizard.Level + " " + wizard.HeroType);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack(10));
            */

            Knight arus = new Knight("Arus", 12, "Guerreiro");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            Console.WriteLine(arus.Name + " " + arus.Level + " " + arus.HeroType);
            Console.WriteLine(wizard.Name + " " + wizard.Level + " " + wizard.HeroType);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(wizard.Attack());
            Console.WriteLine(wizard.Attack(10));
        } 
        }
    }
}
