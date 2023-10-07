using System;
using System.Collections.Generic;

namespace RoleplayGame
{
    public class Encounter
    {
    
            List<Personaje> heroes;
            List<Personaje> enemigos; 

        public Encounter(List<Personaje> heroes, List<Personaje> enemigos)
        {
            this.heroes = heroes;
            this.enemigos = enemigos;
        }

        public void DoEncounter()
        {
            int numHeroes = heroes.Count;
            int numEnemies = enemigos.Count;

            while (numEnemies > 0 && numHeroes > 0)
            {
                for (int i = 0; i < Math.Max(numHeroes, numEnemies); i++)
                {
                    if (i < numHeroes && i < numEnemies)
                    {
                        Personaje enemy = enemigos[i];
                        Personaje hero = heroes[i];

                        Console.WriteLine($"{enemy.Name} ataca a {hero.Name}.");
                        hero.ReceiveAttack(enemy.AttackValue);

                        Console.WriteLine($"{hero.Name} ataca a {enemy.Name}.");
                        enemy.ReceiveAttack(hero.AttackValue);

                        if (hero.Health <= 0)
                        {
                            Console.WriteLine($"Ha muerto {hero.Name}");
                            heroes.Remove(hero);
                            numHeroes--;
                            i--; 
                        }
                       
                        if (enemy.Health <= 0)
                            {
                                Console.WriteLine($"Ha muerto {enemy.Name}");
                                enemigos.Remove(enemy);
                                numEnemies--;
                                i--;
                            }
                        }
                    }
                }

                foreach (Personaje hero in heroes)
                {
                    if (hero.VP >= 5)
                    {
                        hero.Cure();
                    }
                }
            }
        }
    }
