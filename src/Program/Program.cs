using System;
using System.Collections.Generic;
using RoleplayGame;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {

            List<Personaje> heroes = new List<Personaje>();
            List<Personaje> enemigos = new List<Personaje>();
          
            Mago Rasagast = new Mago("Rasagast");
            heroes.Add(Rasagast);

            Enano Thorin = new Enano("Thorin");
            heroes.Add(Thorin);

            Caballero Gervacio= new Caballero("Gervacio");
            heroes.Add (Gervacio);

            Elfo Lego= new Elfo("Lego");
            heroes.Add (Lego);

            Hobbit Gollum = new Hobbit("Gollum");
            enemigos.Add(Gollum);

            Araña araña = new Araña("Araña");
            enemigos.Add(araña);

            Bandido Vale = new Bandido("Vale");
            enemigos.Add(Vale);

            Orco Hervi = new Orco("Hervi");
            enemigos.Add(Hervi);

            Console.WriteLine("El encuentro ha comenzado");

            Encounter encounter = new Encounter(heroes, enemigos);
            encounter.DoEncounter();
            
        }
    }
}