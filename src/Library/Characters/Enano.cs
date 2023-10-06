using System.Collections.Generic;
namespace RoleplayGame
{

    public class Enano: Personaje, Heroe
    {
        public override int Health {get; set;} = 150;
        public int Puntos {get;}   
        public Enano (string name) : base(name)
        {
            AddItem(new Hacha());
            AddItem(new Escudo());
        }
    }
}
       
        