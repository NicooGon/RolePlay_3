using System;
using System.Collections.Generic;

namespace RoleplayGame;

    public class Encounter
    {
        private List<Personaje> heroes;
        private List<Personaje> enemies;

        public Encounter(List<Personaje> heroes, List<Personaje> enemies)
        {
            this.heroes = heroes;
            this.enemies = enemies;
        }

        public void DoEncounter()
        {
            Random random = new Random();

            while (heroes.Count > 0 && enemies.Count > 0)
            {
                Personaje hero = heroes[random.Next(0, heroes.Count)];
                Personaje enemy = enemies[random.Next(0, enemies.Count)];

                Console.WriteLine($"{enemy.Name} attacks {hero.Name}.");
                hero.ReceiveAttack(enemy.AttackValue);

                if (hero.Health <= 0)
                {
                    Console.WriteLine($"{hero.Name} has been defeated!");
                    heroes.Remove(hero);
                }
                
                Console.WriteLine($"{hero.Name} attacks {enemy.Name}.");
                enemy.ReceiveAttack(hero.AttackValue);
                
                if(enemy.Health <= 0)
                {
                    Console.WriteLine($"{enemy.Name} has been defeated!");
                    enemies.Remove(enemy);
                }
            }
        }
    }



