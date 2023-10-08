using NUnit.Framework;
using RoleplayGame;
using System.Collections.Generic;
using System;

namespace Test.Library
{
    public class PersonajeTests
    {
        [Test]
        public void Test_ReceiveAttack()
        {
            Personaje personaje = new Enano("Thorin");

            personaje.ReceiveAttack(-20);

            Assert.AreEqual(150, personaje.Health);
        }

        [Test]
        public void Test_VP()
        {
            Mago mago = new Mago("Gandalf");

            Assert.AreEqual(0, mago.VP);
        }

        [Test]
        public void Test_health()
        {
            Enano enano = new Enano("Gimli");

            Assert.AreEqual(150, enano.Health);
        }

        [Test]
        public void Heroes_Victory()
        {
            List<Personaje> heroes = new List<Personaje>
            {
                new Caballero("Gervacio"),
                new Elfo("Lego")
            
            };

            List<Personaje> enemigos = new List<Personaje>
            {
                new Hobbit("Gollum"),
                new Araña("Araña")
            };

            Encounter encounter = new Encounter(heroes, enemigos);

            encounter.DoEncounter();

            Assert.IsTrue(enemigos.Count == 0);
        }

        [Test]
        public void Enemigos_Victory()
        {
            List<Personaje> heroes = new List<Personaje>
            {
                new Hobbit("Gollum"),
                new Araña("Araña")
                
            };

            List<Personaje> enemigos = new List<Personaje>
            {
                new Caballero("Gervacio"),
                new Elfo("Lego")
            };

            Encounter encounter = new Encounter(heroes, enemigos);

            encounter.DoEncounter();

            Assert.IsTrue(heroes.Count == 0);
        }

        [Test]
        public void Test_Cure()
        {
            Elfo Lego= new Elfo ("Lego");
            Lego.Cure();
            Assert.AreEqual(150, Lego.Health);
        }
    }
}