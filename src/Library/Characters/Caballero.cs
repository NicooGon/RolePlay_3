using System.Collections.Generic;
namespace RoleplayGame
{
    public class Caballero: Personaje
    {
        public override int VP {get; set;} = 0;
        public Caballero (string name) : base(name)
        {
            Health = 130;
            AddItem(new Espada());
            AddItem(new Armadura());
        }
    }
}