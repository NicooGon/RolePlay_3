using System.Collections.Generic;
namespace RoleplayGame
{
    public class Caballero: Personaje, Heroe
    {
        public override int Health 
        {
            get {return 130;}
            set
        { 
        }
        }
        public int Puntos {get;}
        public Caballero (string name) : base(name)
        {
            AddItem(new Espada());
            AddItem(new Armadura());
        }
    }
}